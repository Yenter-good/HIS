using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Linq;
using KellermanSoftware.CompareNetObjects;

namespace HIS.Utility
{
    public class DataBinder
    {
        /// <summary>
        /// 获取对象指定的值
        /// </summary>
        /// <param name="dataSource"></param>
        /// <param name="dataField"></param>
        /// <returns></returns>
        public static object GetValue(object dataSource, string dataField)
        {
            if (dataSource == null) return null;
            if (dataField != null)
                dataField = dataField.Trim();
            if (dataSource is IDictionary)
            {
                if (string.IsNullOrEmpty(dataField)) return null;
                var dict = dataSource as IDictionary;
                if (dict.Contains(dataField)) return dict[dataField];
                return null;
            }
            if (dataSource is DataRow)
            {
                if (string.IsNullOrEmpty(dataField)) return null;
                var row = dataSource as DataRow;
                if (row.Table.Columns.Contains(dataField))
                    return row[dataField];
                return null;
            }
            if (dataSource is DataRowView)
            {
                if (string.IsNullOrEmpty(dataField)) return null;
                var rowView = dataSource as DataRowView;
                if (rowView.Row.Table.Columns.Contains(dataField))
                    return rowView[dataField];
                return null;
            }
            if (dataSource is IDataReader)
            {
                if (string.IsNullOrEmpty(dataField)) return null;
                var dr = dataSource as IDataReader;
                try
                {
                    return dr[dataField];
                }
                catch
                {
                    return null;
                }
            }
            if (dataSource is DataTable)
            {
                if (string.IsNullOrEmpty(dataField)) return null;
                var dt = dataSource as DataTable;
                if (dt.Columns.Contains(dataField) && dt.Rows.Count > 0)
                    return dt.Rows[0][dataField];
                return null;
            }
            if (dataSource is DataView)
            {
                if (string.IsNullOrEmpty(dataField)) return null;
                var dv = dataSource as DataView;
                if (dv.Table.Columns.Contains(dataField) && dv.Count > 0)
                    return dv[0][dataField];
                return null;
            }
            if (dataSource is IList || dataSource is IEnumerable || dataSource is ICollection)
            {
                if (dataSource is IList)
                {
                    var list = dataSource as IList;
                    if (list.Count > 0)
                        return GetValue(list[0], dataField);
                    return null;
                }
                if (dataSource is IEnumerable)
                {
                    var enumerator = (dataSource as IEnumerable).GetEnumerator();
                    if (enumerator.MoveNext())
                        return GetValue(enumerator.Current, dataField);
                    return null;
                }
                if (dataSource is ICollection)
                {
                    var collection = (dataSource as ICollection);
                    if (collection.Count == 0) return null;
                    var enumerator = collection.GetEnumerator();
                    if (enumerator.MoveNext())
                        return GetValue(enumerator.Current, dataField);
                    return null;
                }
            }

            Type type = dataSource.GetType();

            if (type.IsClass)
            {
                if (string.IsNullOrEmpty(dataField)) return null;
                var property = type.GetProperty(dataField);
                if (property == null)
                    return null;
                return property.GetValue(dataSource, null);
            }
            return dataSource;
        }

        public static string GetStringValue(object dataSource, string dataField)
        {
            var value = DataBinder.GetValue(dataSource, dataField);
            if (value == null || value == DBNull.Value)
                return null;
            return value.ToString();
        }
        /// <summary>
        /// 在数据集合中查找符合value得项目对象
        /// </summary>
        /// <param name="dataSource"></param>
        /// <param name="dataField"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static object Find(object dataSource, string dataField, object value)
        {
            if (dataSource.IsNull()
                 || string.IsNullOrWhiteSpace(dataField)
                 || value.IsNull()) return null;
            IEnumerable enumerable = null;
            if (dataSource is IListSource)
            {
                enumerable = (dataSource as IListSource).GetList();
            }
            else
            if (dataSource is IEnumerable)
            {
                enumerable = dataSource as IEnumerable;
            }
            if (enumerable == null) return null;
            CompareLogic compareLogic = new CompareLogic();
            compareLogic.Config.AutoClearCache = false;
            compareLogic.Config.Caching = true;
            foreach (var item in enumerable)
            {
                var getValue = GetValue(item, dataField);
                var result = compareLogic.Compare(getValue, value);
                if (result.AreEqual)
                {
                    compareLogic.ClearCache();
                    return item;
                }
            }
            compareLogic.ClearCache();
            return null;
        }

        /// <summary>
        /// 设置指定对象值
        /// </summary>
        /// <param name="dataSource"></param>
        /// <param name="dataField"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static void SetValue(object dataSource, string dataField, object value)
        {
            if (dataSource == null) return;
            if (dataField != null)
                dataField = dataField.Trim();
            if (dataSource is IDictionary)
            {
                if (string.IsNullOrEmpty(dataField)) return;
                var dict = dataSource as IDictionary;
                if (dict.Contains(dataField)) dict[dataField] = value;
                return;
            }
            if (dataSource is DataRow)
            {
                if (string.IsNullOrEmpty(dataField)) return;
                var row = dataSource as DataRow;
                if (row.Table.Columns.Contains(dataField))
                    row[dataField] = value;
            }
            if (dataSource is DataRowView)
            {
                if (string.IsNullOrEmpty(dataField)) return;
                var rowView = dataSource as DataRowView;
                if (rowView.Row.Table.Columns.Contains(dataField))
                    rowView[dataField] = value;
                return;
            }
            if (dataSource is IDataReader)
            {
                //不支持赋值
                return;
            }
            if (dataSource is DataTable)
            {
                if (string.IsNullOrEmpty(dataField)) return;
                var dt = dataSource as DataTable;
                if (dt.Columns.Contains(dataField) && dt.Rows.Count > 0)
                    dt.Rows[0][dataField] = value;
                return;
            }
            if (dataSource is DataView)
            {
                if (string.IsNullOrEmpty(dataField)) return;
                var dv = dataSource as DataView;
                if (dv.Table.Columns.Contains(dataField) && dv.Count > 0)
                    dv[0][dataField] = value;
                return;
            }
            if (dataSource is IList || dataSource is IEnumerable || dataSource is ICollection)
            {
                if (dataSource is IList)
                {
                    var list = dataSource as IList;
                    if (list.Count > 0)
                        SetValue(list[0], dataField, value);
                    return;
                }
                if (dataSource is IEnumerable)
                {
                    var enumerator = (dataSource as IEnumerable).GetEnumerator();
                    if (enumerator.MoveNext())
                        SetValue(enumerator.Current, dataField, value);
                    return;
                }
                if (dataSource is ICollection)
                {
                    var collection = (dataSource as ICollection);
                    if (collection.Count == 0) return;
                    var enumerator = collection.GetEnumerator();
                    if (enumerator.MoveNext())
                        SetValue(enumerator.Current, dataField, value);
                    return;
                }
            }

            if (string.IsNullOrEmpty(dataField)) return;
            var property = dataSource.GetType().GetProperty(dataField);
            if (property == null || !property.CanWrite)
                return;
            property.SetValue(dataSource, value, null);
        }

        /// <summary>
        /// 过滤数据源 
        /// </summary>
        /// <param name="dataSource"></param>
        /// <param name="filterFields">支持过滤得字段</param>
        /// <param name="filterText">过滤文本</param>
        /// <param name="pinYinField">需要支持拼音码得字段</param>
        /// <param name="wubiField">需要支持五笔码过滤得字段</param>
        /// <returns></returns>
        public static object Filter(object dataSource, string[] filterFields, string filterText, string pinYinField = null, string wubiField = null)
        {
            if (dataSource.IsNull()) return null;
            if (string.IsNullOrWhiteSpace(filterText) || filterFields == null || filterFields.Length == 0) return dataSource;
            filterText = filterText.ToUpper();
            #region DataTable DataView 过滤
            if (dataSource is DataTable || dataSource is DataView)
            {
                DataView dv;
                DataTable dt;
                if (dataSource is DataTable)
                    dt = dataSource as DataTable;
                else
                    dt = (dataSource as DataView).Table;
                //追加拼音检索
                if (!string.IsNullOrWhiteSpace(pinYinField) && dt.Columns.Contains(pinYinField))
                {
                    string pinYinColumn = dt.GetSpellColumn(pinYinField);
                    if (!dt.Columns.Contains(pinYinColumn))
                        dt.AppendSpell(pinYinField);
                    if (!filterFields.Contains(pinYinColumn))
                        filterFields = filterFields.Concat(new string[] { pinYinColumn }).ToArray();
                }
                //追加五笔检索
                if (!string.IsNullOrWhiteSpace(wubiField) && dt.Columns.Contains(wubiField))
                {
                    string wubiColumn = dt.GetWubiColumn(wubiField);
                    if (!dt.Columns.Contains(wubiColumn))
                        dt.AppendWubi(wubiField);
                    if (!filterFields.Contains(wubiColumn))
                        filterFields = filterFields.Concat(new string[] { wubiColumn }).ToArray();
                }
                dv = dt.DefaultView;
                if (string.IsNullOrEmpty(filterText))
                    dv.RowFilter = "";
                else
                {
                    StringBuilder filterBuilder = new StringBuilder();
                    for (int i = 0; i < filterFields.Length; i++)
                    {
                        if (filterBuilder.Length > 0)
                            filterBuilder.Append("or");
                        filterBuilder.AppendFormat(" {0} like '%{1}%' ", filterFields[i], filterText);
                    }
                    dv.RowFilter = filterBuilder.ToString();
                }
                return dv.ToTable();
            }
            #endregion
            #region IEnumerable  IListSource 过滤

            IEnumerable enumerable = null;
            if (dataSource is IEnumerable)
                enumerable = dataSource as IEnumerable;
            else
            if (dataSource is IListSource)
                enumerable = (dataSource as IListSource).GetList();
            if (enumerable != null)
            {

                List<object> list = new List<object>();
                foreach (var item in enumerable)
                {
                    bool find = false;
                    foreach (var field in filterFields)
                    {
                        string value = DataBinder.GetStringValue(item, field)?.ToUpper();
                        if (value != null && (value.Contains(filterText)))
                        {
                            list.Add(item);
                            find = true;
                            break;
                        }
                        if (!string.IsNullOrWhiteSpace(value))
                        {
                            if (field == pinYinField && !string.IsNullOrWhiteSpace(pinYinField) && value.GetSpell().Contains(filterText.ToUpper()))
                            {
                                list.Add(item);
                                find = true;
                                break;
                            }
                            if (field == wubiField && !string.IsNullOrWhiteSpace(wubiField) && value.GetWBM().Contains(filterText.ToUpper()))
                            {
                                list.Add(item);
                                find = true;
                                break;
                            }
                        }
                    }
                    if (find) continue;
                    if (!string.IsNullOrWhiteSpace(pinYinField) && !filterFields.Contains(pinYinField))
                    {
                        string value = DataBinder.GetStringValue(item, pinYinField);
                        if (!string.IsNullOrWhiteSpace(value) && value.GetSpell().Contains(filterText.ToUpper()))
                        {
                            list.Add(item);
                            continue;
                        }
                    }
                    if (!string.IsNullOrWhiteSpace(wubiField) && !filterFields.Contains(wubiField))
                    {
                        string value = DataBinder.GetStringValue(item, wubiField);
                        if (!string.IsNullOrWhiteSpace(value) && value.GetWBM().Contains(filterText.ToUpper()))
                        {
                            list.Add(item);
                            continue;
                        }
                    }
                }
                return list;
            }
            #endregion
            return dataSource;
        }
    }
}