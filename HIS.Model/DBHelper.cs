using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Collections.Concurrent;
using System.Configuration;
using HIS.Utility;
using HIS.Core;

namespace HIS.Model
{
    /// <summary>
    /// 数据库访问器
    /// </summary>
    public class DBHelper : Singleton<DBHelper>
    {
        private ConcurrentDictionary<string, string> _connDict = new ConcurrentDictionary<string, string>();
        private ConcurrentDictionary<string, DbSession> _dbDict = new ConcurrentDictionary<string, DbSession>();

        /// <summary>
        /// 排队叫号数据库访问对象
        /// </summary>
        public DbSession HIS
        {
            get
            {
                return DBHelper.Instance["HIS".ToUpper()];
            }
        }

        /// <summary>
        /// 通过app.config注册连接
        /// </summary>
        /// <param name="encrypt"></param>
        public void RegisterConn(bool encrypt, Configuration configuration)
        {
            foreach (ConnectionStringSettings item in configuration.ConnectionStrings.ConnectionStrings)
            {
                //屏蔽内置的数据库连接
                if (item.Name.StartsWith("Local")) continue;
                DatabaseType databaseType = DatabaseType.SqlServer9;
                if (this.TryGetDatabaseType(item, out databaseType))
                {
                    try
                    {
                        DBHelper.Instance.RegisterDB(item.Name, databaseType, this.GetConnectionString(item, encrypt));
                    }
                    catch { }
                }
            }
        }

        /// <summary>
        /// 获取服务器时间
        /// </summary>
        public DateTime ServerTime { get { return DBHelper.Instance.HIS.FromSql("select getdate()").ToScalar<DateTime>(); } }

        private string GetConnectionString(ConnectionStringSettings connectionStringSettings, bool encrypt)
        {
            if (encrypt)
                return NetCryptoHelper.DecryptDes(connectionStringSettings.ConnectionString, NetCryptoHelper.DesKey, NetCryptoHelper.DesIv);
            return connectionStringSettings.ConnectionString;
        }
        private bool TryGetDatabaseType(ConnectionStringSettings connectionStringSettings, out DatabaseType databaseType)
        {
            databaseType = DatabaseType.SqlServer9;
            if (connectionStringSettings.ProviderName.IsNullOrEmpty()) return true;
            return Enum.TryParse<DatabaseType>(connectionStringSettings.ProviderName.Replace("Dos.ORM.", ""), out databaseType);
        }

        /// <summary>
        /// 注册数据库访问对象
        /// </summary>
        /// <param name="dbName"></param>
        /// <param name="ds"></param>
        private void RegisterDB(string dbName, DatabaseType databaseType, string connectionString)
        {
            string connId = $"{Enum.GetName(typeof(DatabaseType), databaseType)}_{connectionString.Trim().ToUpper()}";
            _connDict[dbName.ToUpper()] = connId;
            if (_dbDict.ContainsKey(connId)) return;
            _dbDict[connId] = new DbSession(databaseType, connectionString);
#if DEBUG
            _dbDict[connId].RegisterSqlLogger(sql =>
            {
                System.Diagnostics.Trace.WriteLine($"{connId} SQL 脚本:{sql}");
            });
#endif
        }

        public DbSession this[string dataBaseName]
        {

            get
            {
                string key = dataBaseName.ToUpper();
                if (!_connDict.ContainsKey(key))
                    throw new ArgumentException(nameof(dataBaseName));
                var dbSession = _dbDict[_connDict[dataBaseName]];
                if (dbSession == null)
                    throw new Exception(string.Format("不存在{0}数据库访问对象,可能系统未注册", dataBaseName));
                return dbSession as DbSession;
            }
        }
    }
}