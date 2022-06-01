using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Model
{
    /// <summary>
    /// 数据库访问器
    /// </summary>
    public class DbAccessor
    {
        private DbSession _session = null;
        private DbTrans _trans = null;
        private DbAccessor(DbSession session)
        {
            _session = session;
        }
        private DbAccessor(DbTrans trans)
        {
            _trans = trans;
        }
        /// <summary>
        /// 创建访问器
        /// </summary>
        /// <param name="session"></param>
        /// <returns></returns>
        public static DbAccessor Create(DbSession session)
        {
            return new DbAccessor(session);
        }
        /// <summary>
        /// 创建访问器
        /// </summary>
        /// <param name="trans"></param>
        /// <returns></returns>
        public static DbAccessor Create(DbTrans trans)
        {
            return new DbAccessor(trans);
        }
        public static DbAccessor Choose(DbTrans trans,DbSession session)
        {
            if (trans == null)
                return new DbAccessor(session);
            else
                return new DbAccessor(trans);
        }
        //
        // 参数:
        //   lambdaWhere:
        //
        // 类型参数:
        //   TEntity:
        public int Delete<TEntity>(Expression<Func<TEntity, bool>> lambdaWhere) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Delete(lambdaWhere);
            else
                return _trans.Delete(lambdaWhere);
        }
        //
        // 参数:
        //   entities:
        //
        // 类型参数:
        //   TEntity:
        public int Delete<TEntity>(List<TEntity> entities) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Delete<TEntity>(entities);
            else
                return _trans.Delete(entities);
        }
        //
        // 摘要:
        //     删除
        //
        // 参数:
        //   pkValues:
        //
        // 类型参数:
        //   TEntity:
        public int Delete<TEntity>(params string[] pkValues) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Delete<TEntity>(pkValues);
            else
                return _trans.Delete<TEntity>(pkValues);
        }
        public int Delete<TEntity>(params Guid[] pkValues) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Delete<TEntity>(pkValues);
            else
                return _trans.Delete<TEntity>(pkValues);
        }
        public int Delete<TEntity>(params long[] pkValues) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Delete<TEntity>(pkValues);
            else
                return _trans.Delete<TEntity>(pkValues);
        }
        public int Delete<TEntity>(params int[] pkValues) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Delete<TEntity>(pkValues);
            else
                return _trans.Delete<TEntity>(pkValues);
        }
        //
        // 摘要:
        //     删除
        //
        // 参数:
        //   where:
        //
        // 类型参数:
        //   TEntity:
        public int Delete<TEntity>(WhereClip where) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Delete<TEntity>(where);
            else
                return _trans.Delete<TEntity>(where);
        }
        //
        // 参数:
        //   where:
        //
        // 类型参数:
        //   TEntity:
        public int Delete<TEntity>(Where where) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Delete<TEntity>(where);
            else
                return _trans.Delete<TEntity>(where);
        }
        //
        // 摘要:
        //     删除
        //
        // 参数:
        //   entity:
        //
        // 类型参数:
        //   TEntity:
        public int Delete<TEntity>(TEntity entity) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Delete<TEntity>(entity);
            else
                return _trans.Delete<TEntity>(entity);
        }
        //
        // 参数:
        //   entities:
        //
        // 类型参数:
        //   TEntity:
        public int Delete<TEntity>(IEnumerable<TEntity> entities) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Delete<TEntity>(entities);
            else
                return _trans.Delete<TEntity>(entities);
        }
       
        //
        // 摘要:
        //     查询
        //
        // 参数:
        //   tableName:
        public FromSection From(string tableName)
        {
            if (_trans == null)
                return _session.From(tableName);
            else
                return _trans.From(tableName);
        }
        //
        // 摘要:
        //     查询
        //
        // 类型参数:
        //   TEntity:
        public FromSection<TEntity> From<TEntity>(string asName) where TEntity : Entity
        {
            if (_trans == null)
                return _session.From<TEntity>(asName);
            else
                return _trans.From<TEntity>(asName);
        }
        //
        // 摘要:
        //     查询
        //
        // 类型参数:
        //   TEntity:
        public FromSection<TEntity> From<TEntity>() where TEntity : Entity
        {
            if (_trans == null)
                return _session.From<TEntity>();
            else
                return _trans.From<TEntity>();
        }
        //
        // 摘要:
        //     FromPro
        //
        // 参数:
        //   proName:
        public ProcSection FromProc(string proName)
        {
            if (_trans == null)
                return _session.FromProc(proName);
            else
                return _trans.FromPro(proName);
        }
        //
        // 摘要:
        //     FromSql
        //
        // 参数:
        //   sql:
        public SqlSection FromSql(string sql)
        {
            if (_trans == null)
                return _session.FromSql(sql);
            else
                return _trans.FromSql(sql);
        }
        //
        // 摘要:
        //     添加
        //
        // 参数:
        //   entities:
        //
        // 类型参数:
        //   TEntity:
        public int Insert<TEntity>(params TEntity[] entities) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Insert<TEntity>(entities);
            else
                return _trans.Insert<TEntity>(entities);
        }
        //
        // 参数:
        //   entities:
        //
        // 类型参数:
        //   TEntity:
        public int Insert<TEntity>(List<TEntity> entities) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Insert<TEntity>(entities);
            else
                return _trans.Insert<TEntity>(entities);
        }
        //
        // 摘要:
        //     添加
        //
        // 参数:
        //   entity:
        //
        // 类型参数:
        //   TEntity:
        public int Insert<TEntity>(TEntity entity) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Insert<TEntity>(entity);
            else
                return _trans.Insert<TEntity>(entity);
        }
        //
        // 摘要:
        //     添加
        //
        // 参数:
        //   fields:
        //
        //   values:
        //
        // 类型参数:
        //   TEntity:
        public int Insert<TEntity>(Field[] fields, object[] values) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Insert<TEntity>(fields, values);
            else
                return _trans.Insert<TEntity>(fields, values);
        }
        //
        // 参数:
        //   entities:
        //
        // 类型参数:
        //   TEntity:
        public int Insert<TEntity>(IEnumerable<TEntity> entities) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Insert<TEntity>(entities);
            else
                return _trans.Insert<TEntity>(entities);
        }
        //
        // 参数:
        //   field:
        //
        //   value:
        //
        //   lambdaWhere:
        //
        // 类型参数:
        //   TEntity:
        public int Update<TEntity>(Field field, object value, Expression<Func<TEntity, bool>> lambdaWhere) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Update<TEntity>(field, value, lambdaWhere);
            else
                return _trans.Update<TEntity>(field, value, lambdaWhere);
        }
        //
        // 参数:
        //   fields:
        //
        //   values:
        //
        //   lambdaWhere:
        //
        // 类型参数:
        //   TEntity:
        public int Update<TEntity>(Field[] fields, object[] values, Expression<Func<TEntity, bool>> lambdaWhere) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Update<TEntity>(fields, values, lambdaWhere);
            else
                return _trans.Update<TEntity>(fields, values, lambdaWhere);
        }
        //
        // 参数:
        //   fields:
        //
        //   values:
        //
        //   where:
        //
        // 类型参数:
        //   TEntity:
        public int Update<TEntity>(Field[] fields, object[] values, Where where) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Update<TEntity>(fields, values, where);
            else
                return _trans.Update<TEntity>(fields, values, where);
        }
        //
        // 参数:
        //   field:
        //
        //   value:
        //
        //   where:
        //
        // 类型参数:
        //   TEntity:
        public int Update<TEntity>(Field field, object value, Where where) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Update<TEntity>(field, value, where);
            else
                return _trans.Update<TEntity>(field, value, where);
        }
        //
        // 参数:
        //   fieldValue:
        //
        //   lambdaWhere:
        //
        // 类型参数:
        //   TEntity:
        public int Update<TEntity>(Dictionary<Field, object> fieldValue, Expression<Func<TEntity, bool>> lambdaWhere) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Update<TEntity>(fieldValue, lambdaWhere);
            else
                return _trans.Update<TEntity>(fieldValue, lambdaWhere);
        }
        //
        // 摘要:
        //     更新
        //
        // 参数:
        //   entities:
        //
        // 类型参数:
        //   TEntity:
        public int Update<TEntity>(params TEntity[] entities) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Update<TEntity>(entities);
            else
                return _trans.Update<TEntity>(entities);
        }
        //
        // 参数:
        //   entities:
        //
        // 类型参数:
        //   TEntity:
        public int Update<TEntity>(IEnumerable<TEntity> entities) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Update<TEntity>(entities);
            else
                return _trans.Update<TEntity>(entities);
        }
        //
        // 摘要:
        //     更新
        //
        // 参数:
        //   fields:
        //
        //   values:
        //
        //   where:
        //
        // 类型参数:
        //   TEntity:
        public int Update<TEntity>(Field[] fields, object[] values, WhereClip where) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Update<TEntity>(fields,values, where);
            else
                return _trans.Update<TEntity>(fields, values, where);
        }
        //
        // 摘要:
        //     更新
        //
        // 参数:
        //   entity:
        //
        // 类型参数:
        //   TEntity:
        public int Update<TEntity>(TEntity entity) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Update<TEntity>(entity);
            else
                return _trans.Update<TEntity>(entity);
        }
        //
        // 摘要:
        //     更新
        //
        // 参数:
        //   entity:
        //
        //   where:
        //
        // 类型参数:
        //   TEntity:
        public int Update<TEntity>(TEntity entity, WhereClip where) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Update<TEntity>(entity,where);
            else
                return _trans.Update<TEntity>(entity, where);
        }
        //
        // 参数:
        //   entities:
        //
        // 类型参数:
        //   TEntity:
        public int Update<TEntity>(List<TEntity> entities) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Update<TEntity>(entities);
            else
                return _trans.Update<TEntity>(entities);
        }
        //
        // 参数:
        //   entity:
        //
        //   lambdaWhere:
        //
        // 类型参数:
        //   TEntity:
        public int Update<TEntity>(TEntity entity, Expression<Func<TEntity, bool>> lambdaWhere) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Update<TEntity>(entity, lambdaWhere);
            else
                return _trans.Update<TEntity>(entity, lambdaWhere);
        }
        //
        // 摘要:
        //     更新单个值
        //
        // 参数:
        //   field:
        //
        //   value:
        //
        //   where:
        //
        // 类型参数:
        //   TEntity:
        public int Update<TEntity>(Field field, object value, WhereClip where) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Update<TEntity>(field, value,where);
            else
                return _trans.Update<TEntity>(field, value, where);
        }
        //
        // 摘要:
        //     更新多个值
        //
        // 参数:
        //   fieldValue:
        //
        //   where:
        //
        // 类型参数:
        //   TEntity:
        public int Update<TEntity>(Dictionary<Field, object> fieldValue, WhereClip where) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Update<TEntity>(fieldValue, where);
            else
                return _trans.Update<TEntity>(fieldValue, where);
        }
        //
        // 参数:
        //   fieldValue:
        //
        //   where:
        //
        // 类型参数:
        //   TEntity:
        public int Update<TEntity>(Dictionary<Field, object> fieldValue, Where where) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Update<TEntity>(fieldValue, where);
            else
                return _trans.Update<TEntity>(fieldValue, where);
        }
        //
        // 参数:
        //   entity:
        //
        //   where:
        //
        // 类型参数:
        //   TEntity:
        public int Update<TEntity>(TEntity entity, Where where) where TEntity : Entity
        {
            if (_trans == null)
                return _session.Update<TEntity>(entity, where);
            else
                return _trans.Update<TEntity>(entity, where);
        }
        //
        // 参数:
        //   entity:
        //
        //   where:
        //
        // 类型参数:
        //   TEntity:
        public int UpdateAll<TEntity>(TEntity entity, Where where) where TEntity : Entity
        {
            if (_trans == null)
                return _session.UpdateAll<TEntity>(entity, where.ToWhereClip());
            else
                return _trans.UpdateAll<TEntity>(entity, where);
        }
        //
        // 摘要:
        //     更新全部字段
        //
        // 参数:
        //   entity:
        //
        //   where:
        //
        // 类型参数:
        //   TEntity:
        public int UpdateAll<TEntity>(TEntity entity, WhereClip where) where TEntity : Entity
        {
            if (_trans == null)
                return _session.UpdateAll<TEntity>(entity, where);
            else
                return _trans.UpdateAll<TEntity>(entity, where);
        }
        //
        // 摘要:
        //     更新全部字段
        //
        // 参数:
        //   entity:
        //
        // 类型参数:
        //   TEntity:
        public int UpdateAll<TEntity>(TEntity entity) where TEntity : Entity
        {
            if (_trans == null)
                return _session.UpdateAll<TEntity>(entity);
            else
                return _trans.UpdateAll<TEntity>(entity);
        }
        //
        // 参数:
        //   entities:
        //
        // 类型参数:
        //   TEntity:
        public int UpdateAll<TEntity>(IEnumerable<TEntity> entities) where TEntity : Entity
        {
            if (_trans == null)
            {
                _session.UpdateAll<TEntity>(entities.ToArray());
                return entities.Count();
            }
            else
                return _trans.UpdateAll<TEntity>(entities);
        }
        //
        // 摘要:
        //     更新全部字段
        //
        // 参数:
        //   entities:
        //
        // 类型参数:
        //   TEntity:
        public int UpdateAll<TEntity>(params TEntity[] entities) where TEntity : Entity
        {
            if (_trans == null)
            {
                _session.UpdateAll<TEntity>(entities);
               return entities.Length;
            }
            else
                return _trans.UpdateAll<TEntity>(entities);
        }

    }
}
