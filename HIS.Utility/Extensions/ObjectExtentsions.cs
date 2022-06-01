using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace System
{
    /// <summary>
    /// 对象扩展类
    /// </summary>
    public static class ObjectExtentsions
    {
        /// <summary>
        /// 判断对象是否为null
        /// </summary>
        /// <param name="targetValue"></param>
        /// <returns></returns>
        public static bool IsNull(this object targetValue)
        {
            return (targetValue == DBNull.Value || targetValue == null);
        }
        /// <summary>
        /// 获取相应列对应得拼音码列名
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="colName"></param>
        public static string GetSpellColumn(this object dt, string colName)
        {
            return colName + "_Spell";
        }
        /// <summary>
        /// 获取相应列对应得五笔列名
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="colName"></param>
        public static string GetWubiColumn(this object dt, string colName)
        {
            return colName + "_Wubi";
        }
        /// <summary>
        /// 当对象为空的时候抛出异常
        /// </summary>
        /// <typeparam name="T">The calling class</typeparam>
        /// <param name="obj">The This object</param>
        /// <param name="text">The text to be written on the ArgumentNullException: [text] not allowed to be null</param>
        public static void ThrowIfArgumentIsNull<T>(this T obj, string text) where T : class
        {
            if (obj == null)
                throw new ArgumentNullException(text + " 不允许为null");

        }
        /// <summary>
        /// 是否操作模式
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static bool IsDesignMode(this object ctl)
        {
            bool returnFlag = false;
#if DEBUG

            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            {
                returnFlag = true;
            }
            else if (System.Diagnostics.Process.GetCurrentProcess().ProcessName.ToUpper() == "DEVENV")
            {
                returnFlag = true;
            }
#endif
            return returnFlag;
        }

        /// <summary>
        /// 枚举转字典
        /// </summary>
        /// <param name="enumType"></param>
        /// <returns></returns>
        public static Dictionary<TEnum, string> GetEnumDict<TEnum>(this object target)
        {
            Dictionary<TEnum, string> dict = new Dictionary<TEnum, string>();
            var type = typeof(TEnum);
            if (!type.IsEnum) return dict;
            foreach (var i in Enum.GetValues(type))
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
        public static Dictionary<int, string> GetEnumDictEx<TEnum>(this object target)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            var type = typeof(TEnum);
            if (!type.IsEnum) return dict;
            foreach (var i in Enum.GetValues(type))
            {
                var a = i;
                dict.Add(((TEnum)i).AsInt(0), ((Enum)i).GetDescription());
            }
            return dict;
        }
        /// <summary>
        /// 根据值得到中文备注
        /// </summary>
        /// <param name="e"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static String GetEnumDesc<TEnum>(this object target, string enumName)
        {
            FieldInfo[] fields = typeof(TEnum).GetFields();
            for (int i = 1, count = fields.Length; i < count; i++)
            {
                if (fields[i].Name == enumName)
                {
                    DescriptionAttribute[] EnumAttributes = (DescriptionAttribute[])fields[i].
                GetCustomAttributes(typeof(DescriptionAttribute), false);
                    if (EnumAttributes.Length > 0)
                    {
                        return EnumAttributes[0].Description;
                    }
                }
            }
            return "";
        }
    }
}
