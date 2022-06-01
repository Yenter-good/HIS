using HIS.Core;
using HIS.Model;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using HIS.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2021-02-04 09:24:26
    /// 描述:
    /// </summary>
    public class IntervalService : IIntervalService
    {
        /// <summary>
        /// 获取所有间隔字典
        /// </summary>
        /// <param name="includeDisable"></param>
        /// <returns></returns>
        public List<IntervalEntity> GetAll(int type, bool includeDisable = false)
        {
            List<Dic_Interval> models;
            if (includeDisable)
                models = DBHelper.Instance.HIS.From<Dic_Interval>().Where(p => p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && p.Type == type).OrderBy(new Dos.ORM.Field[] { Dic_Interval._.No }).ToList();
            else
                models = DBHelper.Instance.HIS.From<Dic_Interval>().Where(p => p.DataStatus == (int)DataStatus.Enable && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id && p.Type == type).OrderBy(new Dos.ORM.Field[] { Dic_Interval._.No }).ToList();

            var result = models.Mapper<List<IntervalEntity>>();
            result.ForEach(p => p.InitIntervalTime());

            return result;
        }
        /// <summary>
        /// 获取指定id的间隔
        /// </summary>
        /// <param name="intervalId"></param>
        /// <returns></returns>
        public IntervalEntity Get(long intervalId)
        {
            var result = DBHelper.Instance.HIS.From<Dic_Interval>().Where(p => p.Id == intervalId && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).First().Mapper<IntervalEntity>();

            result.InitIntervalTime();
            return result;
        }
        /// <summary>
        /// 获取指定id的间隔
        /// </summary>
        /// <param name="usageId"></param>
        /// <returns></returns>
        public IntervalEntity Get(string intervalCode)
        {
            var result = DBHelper.Instance.HIS.From<Dic_Interval>().Where(p => p.Code == intervalCode && p.HosId == App.Instance.RuntimeSystemInfo.HospitalInfo.Id).First().Mapper<IntervalEntity>();

            result.InitIntervalTime();
            return result;
        }
    }
}
