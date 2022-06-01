using HIS.Service.Core;
using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

/// <summary>
/// 创建人:Yenter
/// 创建时间:2020-07-27 15:09:48
/// 功能:
/// </summary>
namespace HIS.Service
{
    public class IniService : IIniService
    {
        /// <summary>
        /// 为INI文件中指定的节点取得字符串
        /// </summary>
        /// <param name="lpAppName">欲在其中查找关键字的节点名称</param>
        /// <param name="lpKeyName">欲获取的项名</param>
        /// <param name="lpDefault">指定的项没有找到时返回的默认值</param>
        /// <param name="lpReturnedString">指定一个字串缓冲区，长度至少为nSize</param>
        /// <param name="nSize">指定装载到lpReturnedString缓冲区的最大字符数量</param>
        /// <param name="lpFileName">INI文件完整路径</param>
        /// <returns>复制到lpReturnedString缓冲区的字节数量，其中不包括那些NULL中止字符</returns>
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);

        /// <summary>
        /// 修改INI文件中内容
        /// </summary>
        /// <param name="lpApplicationName">欲在其中写入的节点名称</param>
        /// <param name="lpKeyName">欲设置的项名</param>
        /// <param name="lpString">要写入的新字符串</param>
        /// <param name="lpFileName">INI文件完整路径</param>
        /// <returns>非零表示成功，零表示失败</returns>
        [DllImport("kernel32")]
        private static extern int WritePrivateProfileString(string lpApplicationName, string lpKeyName, string lpString, string lpFileName);

        /// <summary>
        /// 写INI文件值
        /// </summary>
        /// <param name="section">欲在其中写入的节点名称</param>
        /// <param name="key">欲设置的项名</param>
        /// <param name="value">要写入的新字符串</param>
        /// <param name="filePath">INI文件完整路径</param>
        /// <returns>非零表示成功，零表示失败</returns>
        public DataResult WriteIni(string section, string key, string value, string filePath)
        {
            try
            {
                var result = WritePrivateProfileString(section, key, value, filePath).AsBoolean();
                if (result)
                    return DataResult.True();
                else
                    return DataResult.Fault("写入api出现未知错误");
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }

        /// 读取INI文件值
        /// </summary>
        /// <param name="section">节点名</param>
        /// <param name="key">键</param>
        /// <param name="def">未取到值时返回的默认值</param>
        /// <param name="filePath">INI文件完整路径</param>
        /// <returns>读取的值</returns>
        public DataResult<string> ReadIni(string section, string key, string def, string filePath)
        {
            StringBuilder sb = new StringBuilder(1024);
            try
            {
                GetPrivateProfileString(section, key, def, sb, 1024, filePath);
                return DataResult.True<string>(sb.ToString());
            }
            catch (Exception ex)
            {
                return DataResult.Fault<string>(ex.Message);
            }
        }

        /// <summary>
        /// 删除键的值
        /// </summary>
        /// <param name="section">节点名</param>
        /// <param name="key">键名</param>
        /// <param name="filePath">INI文件完整路径</param>
        /// <returns>非零表示成功，零表示失败</returns>
        public DataResult DeleteKey(string section, string key, string filePath)
        {
            try
            {
                var result = WritePrivateProfileString(section, key, null, filePath).AsBoolean();
                if (result)
                    return DataResult.True();
                else
                    return DataResult.Fault("写入api出现未知错误");
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
    }
}
