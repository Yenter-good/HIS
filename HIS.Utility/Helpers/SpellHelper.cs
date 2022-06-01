using System;
using System.Xml;

namespace HIS.Utility
{
    /// <summary>
    /// 拼音五笔码帮助类
    /// </summary>
    public class SpellHelper
    {
        private static XmlDocument document = new XmlDocument();

        private static System.Collections.Hashtable values = new System.Collections.Hashtable();

        static SpellHelper()
        {
            try
            {
                document.LoadXml(HIS.Utility.Properties.Resources.SPELL1);
                XmlNodeList nodeList = document.SelectNodes("/ROWDATA/ROW");
                foreach (XmlNode item in nodeList)
                {
                    if (!values.ContainsKey(item["NAME"].InnerText))
                        values.Add(item["NAME"].InnerText, new SpellInfo() { Name = item["NAME"].InnerText, Pinyin = item["SPELL_CODE"].InnerText, Wubi = item["WB_CODE"].InnerText });
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// 获取中文的拼音码
        /// </summary>
        /// <param name="strText"></param>
        /// <returns></returns>
        public static string GetSpells(string strText)
        {
            string myStr = "";
            try
            {
                int len = strText.Length;
                for (int i = 0; i < len; i++)
                {
                    myStr += GetSpell(strText.Substring(i, 1));
                }
            }
            catch
            {
                myStr = "";
            }
            return myStr;
        }

        /// <summary>
        /// 获取单个字的拼音码
        /// </summary>
        /// <param name="cnChar"></param>
        /// <returns></returns>
        private static string GetSpell(string cnChar)
        {
            if (values.ContainsKey(cnChar))
                return ((SpellInfo)values[cnChar]).Pinyin;
            else
                return string.Empty;
        }

        /// <summary>
        /// 获取五笔码
        /// </summary>
        /// <param name="strText"></param>
        /// <returns></returns>
        public static string GetWuBis(string strText)
        {
            string myStr = "";
            try
            {
                int len = strText.Length;
                for (int i = 0; i < len; i++)
                {
                    myStr += GetWuBi(strText.Substring(i, 1));
                }
            }
            catch (Exception)
            {
                myStr = "";
            }
            return myStr;
        }

        /// <summary>
        /// 获取单个字的五笔码
        /// </summary>
        /// <param name="cnChar"></param>
        /// <returns></returns>
        private static string GetWuBi(string cnChar)
        {
            if (values.ContainsKey(cnChar))
                return ((SpellInfo)values[cnChar]).Wubi;
            else
                return string.Empty;
        }
    }
    [Serializable]
    public struct SpellInfo
    {
        /// <summary>
        /// 汉字
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>
        public string Pinyin { get; set; }
        /// <summary>
        /// 五笔码
        /// </summary>
        public string Wubi { get; set; }
    }
}
