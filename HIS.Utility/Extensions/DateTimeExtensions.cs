using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static class DateTimeExtensions
    {
        public static DateTime? AsDateTime(this Object targetValue)
        {
            DateTime? returnValue = null;
            if (!targetValue.IsNull())
            {
                DateTime date;
                if (DateTime.TryParse(targetValue.ToString(), out date))
                    returnValue = date;
            }
            return returnValue;
        }


        public static DateTime AsDateTime(this Object targetValue, DateTime defaultTime)
        {
            DateTime? returnValue = null;
            if (targetValue != DBNull.Value && targetValue != null)
            {
                DateTime date;
                if (DateTime.TryParse(targetValue.ToString(), out date))
                    returnValue = date;
            }
            return returnValue.GetValueOrDefault(defaultTime);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="targetValue"></param>
        /// <param name="defaultTime"></param>
        /// <returns></returns>
        public static TimeSpan AsTimeSpan(this Object targetValue, TimeSpan defaultTime)
        {
            TimeSpan? returnValue = null;
            if (targetValue != DBNull.Value && targetValue != null)
            {
                TimeSpan date;
                if (TimeSpan.TryParse(targetValue.ToString(), out date))
                    returnValue = date;
            }
            return returnValue.GetValueOrDefault(defaultTime);
        }


        /// <summary>
        /// 获取当前日期的开始时间
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static DateTime Start(this DateTime datetime)
        {
            return datetime.Date;
        }
        /// <summary>
        /// 获取当前日期的结束时间
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static DateTime End(this DateTime datetime)
        {
            //在SQL SERVER中DATETIME表示的时间为00:00:00到23:59:59.997，它的时间精度为1/300秒，在使用时会舍入到舍入到 .000、.003 或 .007 秒三个增量
            return datetime.Date.AddDays(1).AddMilliseconds(-(1 / 300d * 1000));
        }
        /// <summary>
        /// 日期转字符
        /// yyyy-MM-dd
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static string ToYMD(this DateTime datetime)
        {
            return datetime.ToString("yyyy-MM-dd");
        }
        /// <summary>
        /// 日期转字符
        /// yyyy-MM-dd HH:mm
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static string ToYMDHM(this DateTime datetime)
        {
            return datetime.ToString("yyyy-MM-dd HH:mm");
        }
        /// <summary>
        /// 日期转字符
        /// yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static string ToYMDHMS(this DateTime datetime)
        {
            return datetime.ToString("yyyy-MM-dd HH:mm:ss");
        }
        /// <summary>
        /// 日期转字符
        /// HH:mm
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static string ToHM(this DateTime datetime)
        {
            return datetime.ToString("HH:mm");
        }
        /// <summary>
        /// 日期转字符
        /// HH:mm:ss
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static string ToHMS(this DateTime datetime)
        {
            return datetime.ToString("HH:mm:ss");
        }
        /// <summary>
        /// 获取当前时间所在月份的起始时间
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static DateTime FirstDayOfTheMonth(this DateTime datetime)
        {
            return new DateTime(datetime.Year, datetime.Month, 1);
        }
        /// <summary>
        /// 获取当前时间所在月份的最后一刻时间
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static DateTime LastDayOfTheMonth(this DateTime datetime)
        {
            return new DateTime(datetime.Year, datetime.Month, DateTime.DaysInMonth(datetime.Year, datetime.Month)).End();
        }

    }
}
