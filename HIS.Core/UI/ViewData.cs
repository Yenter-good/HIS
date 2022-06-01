using HIS.Service.Core.Entities;
using HIS.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 创建人:Yenter
/// 创建时间:2020-07-28 14:36:16
/// 功能:
/// </summary>
namespace HIS.Core.UI
{
    public class ViewData
    {
        private const string DEPT = "{AAB33109-91D0-4AFB-BC5E-007B8DE91C53}";
        private const string CLINIC = "{5EC97F4B-C6B0-4A05-9A88-4BB8A1E29C2B}";

        public bool InitializedViewUnitData = false;

        internal System.Collections.Concurrent.ConcurrentDictionary<string, object> _data = new System.Collections.Concurrent.ConcurrentDictionary<string, object>();

        /// <summary>
        /// 获取临床科室
        /// </summary>
        public DeptEntity Dept
        {
            get { return Get<DeptEntity>(DEPT); }
            internal set
            {
                this.Set<DeptEntity>(DEPT, value);
                this.InitializedViewUnitData = true;
            }
        }


        public T Get<T>(string name)
        {
            name.CheckNotNullOrEmpty(nameof(name));
            object value;
            if (_data.TryGetValue(name, out value))
                return (T)value;
            return default(T);
        }
        public void Set<T>(string name, T value)
        {
            name.CheckNotNullOrEmpty(nameof(name));
            _data[name] = value;
        }
        public void Set(ViewData viewData, bool ingoreSameKey = false)
        {
            foreach (var item in viewData._data)
            {
                if (!ingoreSameKey || !this._data.ContainsKey(item.Key))
                    this._data[item.Key] = item.Value;
            }
        }
    }
}
