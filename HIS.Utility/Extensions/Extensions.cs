
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Text;
using System.Security.Cryptography;

namespace System
{
    public static class Extensions
    {

        #region 类型转换
        public static string AsString(this object targetValue)
        {
            return !targetValue.IsNull() ? targetValue.ToString().Trim() : null;
        }
        public static string AsString(this Object targetValue, string defaultValue)
        {
            var value = targetValue.AsString();
            if (value.IsNullOrWhiteSpace())
                return defaultValue;
            return value;
        }
        public static string AsNotNullString(this Object targetValue)
        {
            return !targetValue.IsNull() ? targetValue.ToString().Trim() : "";
        }

        public static int? AsInt(this Object targetValue)
        {
            if (targetValue.IsNull())
            {
                return null;
            }
            if (targetValue is bool)
            {
                return targetValue.AsBoolean() ? 1 : 0;
            }
            if (targetValue.GetType().IsEnum)
            {
                return (int)targetValue;
            }
            int result = 0;
            int.TryParse(targetValue.ToString(), out result);
            return result;
        }
        public static T As<T>(this object sourceValue) where T : class
        {
            try
            {
                var target = sourceValue as T;
                return target;
            }
            catch
            {
                return null;
            }
        }
        public static int AsInt(this Object targetValue, int defalutValue)
        {
            return targetValue.AsInt().GetValueOrDefault(defalutValue);
        }

        public static long? AsLong(this Object targetValue)
        {
            long? returnValue = null;
            if (targetValue.IsNull())
            {
                return returnValue;
            }

            long result = 0;
            long.TryParse(targetValue.ToString(), out result);
            returnValue = result;

            return returnValue;
        }

        public static long AsLong(this Object targetValue, long defalutValue)
        {
            return targetValue.AsLong().GetValueOrDefault(defalutValue);
        }

        public static Boolean AsBoolean(this Object targetValue)
        {
            if (targetValue.IsNull())
                return false;
            if (targetValue is Boolean)
                return ((Boolean)targetValue);
            string booleanStr = targetValue.AsString();
            bool result = false;
            if (Boolean.TryParse(booleanStr, out result))
                return result;
            switch (booleanStr.ToUpper())
            {
                case "是":
                case "Y":
                case "YES":
                    return true;
                case "否":
                case "N":
                case "NO":
                    return false;
                default:
                    break;
            }
            return targetValue.AsInt(0) > 0;
        }

        public static Double? AsDouble(this Object targetValue)
        {
            Double? returnValue = null;
            if (targetValue.IsNull())
            {
                return returnValue;
            }

            Double result = 0;
            Double.TryParse(targetValue.ToString(), out result);
            returnValue = result;

            return returnValue;
        }
        public static Double AsDouble(this object targValue, double defaultValue)
        {
            return AsDouble(targValue).GetValueOrDefault(defaultValue);
        }

        public static float? AsFloat(this Object targetValue)
        {
            float? returnValue = null;
            if (targetValue.IsNull())
            {
                return returnValue;
            }

            float result = 0;
            float.TryParse(targetValue.ToString(), out result);
            returnValue = result;

            return returnValue;
        }
        public static float AsFloat(this Object targetValue, float defaultValue)
        {
            return targetValue.AsFloat().GetValueOrDefault(defaultValue);
        }
        public static decimal? AsDecimal(this Object targetValue)
        {
            decimal? returnValue = null;
            if (targetValue == DBNull.Value || targetValue == null)
            {
                return returnValue;
            }

            decimal result = 0;
            decimal.TryParse(targetValue.ToString(), out result);
            returnValue = result;

            return returnValue;
        }
        public static decimal AsDecimal(this Object targetValue, decimal defaultValue)
        {
            return targetValue.AsDecimal().GetValueOrDefault(defaultValue);
        }

        public static TimeSpan? AsTimeSpan(this Object targetValue)
        {
            TimeSpan? returnValue = null;
            if (!targetValue.IsNull())
            {
                TimeSpan date;
                if (TimeSpan.TryParse(targetValue.ToString(), out date))
                    returnValue = date;
            }
            return returnValue;
        }
        public static byte[] AsBytes(this Object targetValue)
        {
            return targetValue != DBNull.Value && targetValue != null ? (byte[])targetValue : null;
        }
        /// <summary>
        /// 枚举转字典
        /// </summary>
        /// <param name="enumType"></param>
        /// <returns></returns>
        [Obsolete("请使用this.GetEnumDict<TEnum>")]
        public static Dictionary<TEnum, string> EnumToDict<TEnum>(this Type enumType)
        {
            Dictionary<TEnum, string> dict = new Dictionary<TEnum, string>();
            if (!typeof(TEnum).IsEnum) return dict;
            foreach (var i in Enum.GetValues(enumType))
            {
                var a = i;
                dict.Add((TEnum)i, ((Enum)i).GetDescription());
            }
            return dict;
        }
        /// <summary>
        /// 枚举转字典
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="enumType"></param>
        /// <returns></returns>
        [Obsolete("请使用this.GetEnumDictEx<TEnum>")]
        public static Dictionary<int, string> EnumToDictEx<TEnum>(this Type enumType)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            if (!typeof(TEnum).IsEnum) return dict;
            foreach (var i in Enum.GetValues(enumType))
            {
                var a = i;
                dict.Add(((TEnum)i).AsInt(0), ((Enum)i).GetDescription());
            }
            return dict;
        }
        /// <summary>
        /// 枚举转字典
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="enumType"></param>
        /// <returns></returns>
        public static Dictionary<TKey, string> EnumToDictEx<TEnum, TKey>(this Type enumType)
        {
            Dictionary<TKey, string> dict = new Dictionary<TKey, string>();
            if (!typeof(TEnum).IsEnum) return dict;
            foreach (var i in Enum.GetValues(enumType))
            {
                var a = i;
                dict.Add((TKey)Convert.ChangeType((TEnum)i, typeof(TKey)), ((Enum)i).GetDescription());
            }
            return dict;
        }
        /// <summary>
        /// 字节数组生成图片
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <returns>图片</returns>
        public static Bitmap AsBitmap(this byte[] bytes, Bitmap defaultImage = null)
        {
            if (bytes == null || bytes.Length == 0) return defaultImage;
            try
            {
                MemoryStream ms = new MemoryStream(bytes);
                return Bitmap.FromStream(ms, true) as Bitmap;
            }
            catch
            {
                return defaultImage;
            }
        }
        #endregion

        #region 字符串
        /// <summary> 
        /// 获取右边指定长度的字符串
        /// </summary> 
        /// <param name="value">String value</param> 
        /// <param name="length">Max number of charaters to return</param> 
        /// <returns>Returns string from right</returns> 
        public static string Right(this string value, int length)
        {
            return value != null && value.Length > length ? value.Substring(value.Length - length) : value;
        }

        /// <summary> 
        /// 获取左边指定长度的字符串
        /// </summary> 
        /// <param name="value">String value</param> 
        /// <param name="length">Max number of charaters to return</param> 
        /// <returns>Returns string from left</returns> 
        public static string Left(this string value, int length)
        {
            return value != null && value.Length > length ? value.Substring(0, length) : value;
        }
        /// <summary>
        /// 字符串格式化
        /// </summary>
        /// <param name="valueFormat">格式化文本</param>
        /// <param name="paramters">参数值</param>
        /// <returns></returns>
        public static string FormatWith(this string valueFormat, params object[] paramters)
        {
            return string.Format(valueFormat, paramters);
        }
        /// <summary>
        /// 判定字符串是否为空
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string text)
        {
            return string.IsNullOrEmpty(text);
        }
        /// <summary>
        ///  指示指定的字符串是 null、空还是仅由空白字符组成。
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsNullOrWhiteSpace(this string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }

        /// <summary>
        /// 如果string 类型的值 为Null返回空字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string IsNullToString(string obj)
        {
            if (obj == null)
            {
                return "";
            }
            return obj;
        }

        /// <summary>
        /// 如果int 类型的值 为Null返回0
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int IsNullToInt(int? obj)
        {
            if (obj == null)
            {
                return 0;
            }
            return Convert.ToInt32(obj);
        }

        /// <summary>
        /// 如果decima 类型的值 为Null返回double 类型的 0.0
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static double IsNullToInt(decimal? obj)
        {
            if (obj == null)
            {
                return 0.0;
            }
            return Convert.ToDouble(obj);
        }
        public static DataTable ToDataTable<T>(this List<T> list)
        {
            if (list == null || list.Count == 0)
                return null;
            T t = list[0];
            PropertyInfo[] infos = t.GetType().GetProperties();
            DataTable dt = new DataTable();
            foreach (var info in infos)
                dt.Columns.Add(info.Name);

            foreach (var item in list)
            {
                DataRow row = dt.NewRow();
                foreach (var info in infos)
                    row[info.Name] = info.GetValue(item, null);
                dt.Rows.Add(row);
            }
            return dt;
        }
        #endregion


        /// <summary>
        /// 获取枚举分类值
        /// </summary>
        /// <param name="enumeration"></param>
        /// <returns></returns>
        public static string GetCategory(this Enum enumeration)
        {
            FieldInfo fi = enumeration.GetType().GetField(enumeration.ToString());
            CategoryAttribute[] attributes =
                  (CategoryAttribute[])fi.GetCustomAttributes(
                  typeof(CategoryAttribute), false);
            return (attributes.Length > 0) ? attributes[0].Category : enumeration.ToString();
        }
        /// <summary>
        /// 获取枚举的描述
        /// </summary>
        /// <param name="enumeration"></param>
        /// <returns></returns>
        public static string GetDescription(this Enum enumeration, string defaulValue = null, int index = 0)
        {
            if (enumeration == null)
                return "";
            Type type = enumeration.GetType();
            MemberInfo[] memInfo = type.GetMember(enumeration.ToString());
            if (null != memInfo && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (null != attrs && attrs.Length > 0)
                {
                    string[] str = ((DescriptionAttribute)attrs[0]).Description.Split(';');
                    if (str.Length <= index)
                        return str[0];
                    else
                        return str[index];
                }
            }
            if (defaulValue != null)
                return defaulValue;
            else
                return enumeration.ToString();
        }
        /// <summary>
        /// 获取枚举的指定标签对象
        /// </summary>
        /// <param name="enumeration"></param>
        /// <returns></returns>
        public static TAttribute GetAttribute<TAttribute>(this Enum enumeration) where TAttribute : Attribute
        {
            if (enumeration == null)
                return null;
            Type type = enumeration.GetType();
            MemberInfo[] memInfo = type.GetMember(enumeration.ToString());
            if (null != memInfo && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(TAttribute), false);
                if (null != attrs && attrs.Length > 0)
                {
                    return (TAttribute)attrs[0];
                }
            }
            return null;
        }
        /// <summary>
        /// 获取枚举名称
        /// </summary>
        /// <param name="enumeration"></param>
        /// <returns></returns>
        public static string GetName(this Enum enumeration)
        {
            return Enum.GetName(enumeration.GetType(), enumeration);
        }
        /// <summary>
        /// 根据枚举值获取枚举
        /// </summary>
        /// <param name="enumeration"></param>
        /// <returns></returns>
        public static string GetDescriptionFromValue<T>(this string value) where T : struct
        {
            T t;
            if (Enum.TryParse<T>(value.ToString(), out t))
            {
                return (t as Enum).GetDescription();
            }
            return "";
        }
        /// <summary>
        /// 全角转半角
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ToDBC(this string input)
        {
            char[] array = input.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 12288)
                {
                    array[i] = (char)32;
                    continue;
                }
                if (array[i] > 65280 && array[i] < 65375)
                {
                    array[i] = (char)(array[i] - 65248);
                }
            }
            return new string(array);
        }
        /// <summary>
        /// 半角转全角
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ToSBC(this string input)
        {
            // 半角转全角：  
            char[] array = input.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 32)
                {
                    array[i] = (char)12288;
                    continue;
                }
                if (array[i] < 127)
                {
                    array[i] = (char)(array[i] + 65248);
                }
            }
            return new string(array);
        }
        /// <summary>
        /// 获取颜色16进制形式的名称
        /// 如#f00
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string Get16Name(this Color color)
        {
            string result;
            if (color.A == 255)
            {
                string text = "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
                result = text;
            }
            else
            {
                string text = string.Concat(new string[]
                {
                    "#",
                    color.A.ToString("X2"),
                    color.R.ToString("X2"),
                    color.G.ToString("X2"),
                    color.B.ToString("X2")
                });
                result = text;
            }
            return result;
        }

        /// <summary>
        /// 移除结尾的零
        /// </summary>
        /// <param name="targetValue"></param>
        /// <returns></returns>
        public static string RemoveTailZero(this double targetValue)
        {
            return targetValue.ToString().TrimEnd('0').TrimEnd('.');
        }
        /// <summary>
        /// 移除结尾的零
        /// </summary>
        /// <param name="targetValue"></param>
        public static string RemoveTailZero(this float targetValue)
        {
            return targetValue.ToString().TrimEnd('0').TrimEnd('.');
        }
        /// <summary>
        /// 移除结尾的零
        /// </summary>
        /// <param name="targetValue"></param>
        public static string RemoveTailZero(this decimal targetValue)
        {
            return targetValue.ToString().TrimEnd('0').TrimEnd('.');
        }


        /// <summary>
        /// 设置控件值
        /// 允许跨线程设置
        /// </summary>
        /// <typeparam name="TControl"></typeparam>
        /// <param name="control"></param>
        /// <param name="setValue"></param>
        public static void SetValue<TControl>(this TControl control, Action<TControl> setValue) where TControl : System.Windows.Forms.Control
        {
            if (setValue == null) return;
            if (control.InvokeRequired)
                control.Invoke((System.Windows.Forms.MethodInvoker)delegate
                {
                    setValue(control);
                });
            else
                setValue(control);
        }

        /// <summary>
        /// 获得文本的拼音码
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string GetSpell(this string text)
        {
            return HIS.Utility.SpellHelper.GetSpells(text.AsNotNullString());
        }

        /// <summary>
        /// 获取文本的五笔码
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string GetWBM(this string text)
        {
            return HIS.Utility.SpellHelper.GetWuBis(text.AsNotNullString());
        }

        /// <summary>
        /// 给DataTable增加拼音列
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="colName"></param>
        public static void AppendSpell(this DataTable dt, params string[] colName)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (string item in colName)
            {
                if (dt.Columns.Contains(item))
                {
                    DataColumn dc = new DataColumn(item + "_Spell", typeof(string));
                    dict[item] = item + "_Spell";
                    dt.Columns.Add(dc);
                }
            }
            foreach (DataRow item in dt.Rows)
            {
                foreach (var item1 in dict)
                {
                    item[item1.Value] = item[item1.Key].AsString().GetSpell();
                }
            }
        }
        /// <summary>
        /// 给DataTable增加五笔列
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="colName"></param>
        public static void AppendWubi(this DataTable dt, params string[] colName)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (string item in colName)
            {
                if (dt.Columns.Contains(item))
                {
                    DataColumn dc = new DataColumn(item + "_Wubi", typeof(string));
                    dict[item] = item + "_Wubi";
                    dt.Columns.Add(dc);
                }
            }
            foreach (DataRow item in dt.Rows)
            {
                foreach (var item1 in dict)
                {
                    item[item1.Value] = item[item1.Key].AsString().GetWBM();
                }
            }
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        /// <param name="control"></param>
        /// <param name="source">仅限DataTable与List集合对象</param>
        /// <param name="valueMember"></param>
        /// <param name="displayMember"></param>
        /// <param name="createEmptyItem">创建空项的方法</param>
        public static void DataBind(this System.Windows.Forms.ListControl control, object source, string valueMember, string displayMember, object selectedValue, Func<object> createEmptyItem = null)
        {
            if (createEmptyItem != null)
            {
                object emptyItem = createEmptyItem();
                if (emptyItem is Data.DataRow && source is Data.DataTable)
                {
                    var datatable = source as Data.DataTable;
                    datatable.Rows.InsertAt(emptyItem as Data.DataRow, 0);
                }
                else if (source is System.Collections.IList)
                {
                    var list = source as System.Collections.IList;
                    list.Insert(0, emptyItem);
                }
            }
            control.ValueMember = valueMember;
            control.DisplayMember = displayMember;
            control.DataSource = source;

            if (selectedValue != null)
                control.SelectedValue = selectedValue;
        }
        public static T Clone<T>(this T source) where T : class
        {
            return HIS.Utility.SerializeHelper.BeginJsonDeserialize<T>(HIS.Utility.SerializeHelper.BeginJsonSerializable(source));
            //if (!typeof(T).IsSerializable)
            //{
            //    throw new ArgumentException("The type must be serializable.", "source");
            //}

            //// Don't serialize a null object, simply return the default for that object
            //if (Object.ReferenceEquals(source, null))
            //{
            //    return default(T);
            //}

            //IFormatter formatter = new BinaryFormatter();
            //Stream stream = new MemoryStream();
            //using (stream)
            //{
            //    formatter.Serialize(stream, source);
            //    stream.Seek(0, SeekOrigin.Begin);
            //    return (T)formatter.Deserialize(stream);
            //}
        }

        public static void CopyToChild<TParent, TChild>(this TParent parent, TChild child) where TChild : TParent, new()
        {
            var ParentType = typeof(TParent);
            var Properties = ParentType.GetProperties();
            foreach (var Propertie in Properties)
            {
                //循环遍历属性
                if (Propertie.CanRead && Propertie.CanWrite)
                {
                    //进行属性拷贝
                    Propertie.SetValue(child, Propertie.GetValue(parent, null), null);
                }
            }
        }


        public static void CopyTo(this object source, object target)
        {
            if (Object.ReferenceEquals(source, null) || Object.ReferenceEquals(target, null))
            {
                return;
            }
            var sourceProperties = source.GetType().GetProperties();
            var targetProperties = target.GetType().GetProperties();
            foreach (var tpro in targetProperties)
            {
                if (tpro.CanRead && tpro.CanWrite)
                {
                    foreach (var spro in sourceProperties)
                    {
                        if (spro.CanRead && tpro.Name == spro.Name && tpro.PropertyType == spro.PropertyType)
                        {
                            tpro.SetValue(target, spro.GetValue(source, null), null);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 获得当前患者年龄数值
        /// </summary>
        /// <returns></returns>
        public static int GetAge(this string AgeStr)
        {
            char[] str = new char[] { '岁', '月', '日', '天' };
            string age = AgeStr;
            char[] chr = age.ToCharArray();
            for (int i = 0; i < chr.Length; i++)
            {
                if (str.Contains(chr[i]))
                {
                    string s = new string(chr, 0, i);
                    return (int)float.Parse(s);
                }

            }
            return 0;
        }
        public static string GetBetweenFormatDays(this DateTime? sourceDateTime, DateTime targetDateTime)
        {
            string result = "";
            if (sourceDateTime.HasValue)
            {
                TimeSpan ts = targetDateTime - sourceDateTime.Value;
                ts = ts.Add(new TimeSpan(1, 0, 0, 0));  //给当前间隔时间加一天，因为是从源日期开始就算一天了

                int year = ts.Days / 365;
                int month = (ts.Days % 365) / 30;
                int day = ts.Days - month * 30;
                int hour = ts.Hours;
                int minute = ts.Minutes;

                if (year != 0)
                    result += year + "年";
                else if (month != 0)
                    result += month + "个月" + day + "天";
                else if (day != 0)
                    result += day + "天";
                else if (hour != 0)
                    result += hour + "小时" + minute + "分钟";
                else if (minute != 0)
                    result += minute + "分钟";
            }
            else
                return "1天";
            return result;
        }
        public static string GetBetweenFormatDays(this DateTime sourceDateTime, DateTime targetDateTime)
        {
            string result = "";
            TimeSpan ts = targetDateTime - sourceDateTime;
            ts = ts.Add(new TimeSpan(1, 0, 0, 0));  //给当前间隔时间加一天，因为是从源日期开始就算一天了

            int year = ts.Days / 365;
            int month = (ts.Days % 365) / 30;
            int day = ts.Days - month * 30;
            int hour = ts.Hours;
            int minute = ts.Minutes;

            if (year != 0)
                result += year + "年" + month + "个月";
            else if (month != 0)
                result += month + "个月" + day + "天";
            else if (day != 0)
                result += day + "天";
            else if (hour != 0)
                result += hour + "小时" + minute + "分钟";
            else if (minute != 0)
                result += minute + "分钟";

            return result;
        }
        public static int GetBetweenDays(this DateTime? sourceDateTime, DateTime targetDateTime)
        {
            if (sourceDateTime.HasValue)
            {
                TimeSpan ts = targetDateTime - sourceDateTime.Value;
                ts = ts.Add(new TimeSpan(1, 0, 0, 0));  //给当前间隔时间加一天，因为是从源日期开始就算一天了
                return ts.Days;
            }
            else
                return 1;
        }
        public static object RunFunction(this Type type, string FunctionName, params object[] obj)
        {
            object result = null;
            MethodInfo mt = type.GetMethod(FunctionName, BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Instance);
            if (mt != null)
                result = mt.Invoke(null, obj);
            else
                result = ("该功能未定义,调用失败");
            return result;
        }

        public static bool _In<T>(this T t, List<T> obj)
        {
            if (obj.Contains(t))
                return true;
            return false;
        }

        public static bool _In<T>(this T t, params T[] obj)
        {
            if (obj.Contains(t))
                return true;
            return false;
        }
        public static bool _NotIn<T>(this T t, List<T> obj)
        {
            if (!obj.Contains(t))
                return true;
            return false;
        }

        /// <summary>
        /// 去重扩展
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="source"></param>
        /// <param name="keySelector"></param>
        /// <returns></returns>
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }
        /// <summary>
        /// 字段拼接
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="keyName"></param>
        /// <param name="valueName"></param>
        /// <param name="symbol">拼接符号</param>
        /// <returns></returns>
        public static string JoinFild<T>(this List<T> source, string keyName, string valueName, string symbol = "_")
        {
            string str = "";
            if (source == null || keyName.IsNullOrWhiteSpace() || valueName.IsNullOrWhiteSpace())
                return str;
            foreach (var item in source)
            {
                var left = typeof(T).GetProperty(keyName).GetValue(item, null);
                var right = typeof(T).GetProperty(valueName).GetValue(item, null);
                str += string.Format("{0}" + symbol + "{1} ", left, right);
            }

            return str;
        }
        /// <summary>
        /// 字段拼接
        /// </summary>
        /// <typeparam name="TK"></typeparam>
        /// <typeparam name="TV"></typeparam>
        /// <param name="source"></param>
        /// <param name="symbol"></param>
        /// <param name="isLineField">换行</param>
        /// <returns></returns>
        public static string JoinFild<TK, TV>(this Dictionary<TK, TV> source, string symbol = "_", bool isLineField = false)
        {
            string str = "";
            if (source == null)
                return str;
            foreach (var item in source)
            {
                var left = item.Key;
                var right = item.Value;
                if (!isLineField)
                    str += string.Format("{0}" + symbol + "{1} ", left, right);
                else
                    str += string.Format("{0}" + symbol + "{1} {2}", left, right, Environment.NewLine);
            }

            return str;
        }
        /// <summary>
        /// 获取该行中的附加信息
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public static T GetTag<T>(this DataGridViewRow row) where T : class, new()
        {
            T result = row.Tag as T;
            return result;
        }

        public static string ToMD5(this string source)
        {
            byte[] sor = Encoding.UTF8.GetBytes(source);
            MD5 md5 = MD5.Create();
            byte[] result = md5.ComputeHash(sor);
            StringBuilder strbul = new StringBuilder(40);
            for (int i = 0; i < result.Length; i++)
            {
                strbul.Append(result[i].ToString("x2"));//加密结果"x2"结果为32位,"x3"结果为48位,"x4"结果为64位

            }
            return strbul.ToString();
        }

        /// <summary>
        /// 判断两个集合是否相等
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sourceCollection">源列表</param>
        /// <param name="targetCollection">目标列表</param>
        /// <param name="comparable">判断相等的方法</param>
        /// <returns></returns>
        public static bool EqualList<T>(this IList<T> sourceCollection, IList<T> targetCollection, Func<T, T, bool> comparable) where T : class
        {
            //空集合直接返回False,即使是两个都是空集合,也返回False
            if (sourceCollection == null || targetCollection == null)
            {
                return false;
            }

            if (object.ReferenceEquals(sourceCollection, targetCollection))
            {
                return true;
            }

            if (sourceCollection.Count != targetCollection.Count)
            {
                return false;
            }
            foreach (var s in sourceCollection)
            {
                Action func = null;
                foreach (var t in targetCollection)
                {
                    if (comparable(s, t))
                    {
                        func = () => { targetCollection.Remove(t); };
                        break;
                    }
                }
                if (func == null)
                    return false;
                func?.Invoke();
            }

            if (targetCollection.Count == 0)
                return true;

            return false;
        }
    }

}
