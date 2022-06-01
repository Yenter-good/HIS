using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-02-03 15:16:23
    /// 描述:
    /// </summary>
    public class IntervalEntity
    {
        public long Id { get; set; }
        /// <summary>
        /// 间隔编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 间隔名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 一天几次
        /// </summary>
        public int Value { get; set; }
        /// <summary>
        /// 间隔单位
        /// </summary>
        public IntervalUnit IntervalUnit { get; set; }
        /// <summary>
        /// 间隔时间文本
        /// </summary>
        public string IntervalTimeText { get; set; }
        /// <summary>
        /// 间隔时间
        /// </summary>
        public List<IntervalTimeEntity> IntervalTime { get; set; }
        /// <summary>
        /// 循环时间
        /// </summary>
        public TimeSpan LoopTime { get; set; }
        /// <summary>
        /// 检索码
        /// </summary>
        public string SearchCode { get; set; }
        /// <summary>
        /// 五笔码
        /// </summary>
        public string WubiCode { get; set; }

        public void InitIntervalTime()
        {
            IntervalTime = new List<IntervalTimeEntity>();
        }
    }

    public class IntervalTimeEntity
    {
        public DayOfWeek Day { get; set; }
        public List<TimeSpan> Time { get; set; }
    }
}
