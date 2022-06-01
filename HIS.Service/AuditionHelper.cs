using Dos.ORM;
using HIS.Core;
using HIS.Model;
using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service
{
    /// <summary>
    /// 审计操作扩展帮助类
    /// </summary>
    static class AuditionHelper
    {
        /// <summary>
        /// 为创建操作赋值
        /// 默认状态为启用
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        /// <param name="operTime"></param>
        public static TEntity SetCreationValues<TEntity>(this TEntity entity, DateTime? operTime = null) where TEntity : Entity
        {
            var fields = EntityCache.GetFields<TEntity>();
            //设置创建者
            if (fields.Any(d => d.PropertyName == nameof(Sys_Parameter.CreatorUserId)))
                DataUtils.SetPropertyValue(entity, nameof(Sys_Parameter.CreatorUserId), App.Instance.User.Id);
            //设置创建时间
            if (fields.Any(d => d.PropertyName == nameof(Sys_Parameter.CreationTime)))
            {
                if (operTime == null)
                    operTime = DBHelper.Instance.ServerTime;
                DataUtils.SetPropertyValue(entity, nameof(Sys_Parameter.CreationTime), operTime.Value);
            }
            //设置操作人
            if (fields.Any(d => d.PropertyName == nameof(Sys_Parameter.LastModifierUserId)))
                DataUtils.SetPropertyValue(entity, nameof(Sys_Parameter.LastModifierUserId), App.Instance.User.Id);
            //设置医疗机构
            if (fields.Any(d => d.PropertyName == nameof(Sys_Parameter.HosId)))
                DataUtils.SetPropertyValue(entity, nameof(Sys_Parameter.HosId), App.Instance.RuntimeSystemInfo.HospitalInfo.Id);
            //设置操作时间
            if (fields.Any(d => d.PropertyName == nameof(Sys_Parameter.LastModificationTime)))
            {
                if (operTime == null)
                    operTime = DBHelper.Instance.ServerTime;
                DataUtils.SetPropertyValue(entity, nameof(Sys_Parameter.LastModificationTime), operTime.Value);
            }
            //状态
            if (fields.Any(d => d.PropertyName == nameof(Sys_Parameter.DataStatus)))
                DataUtils.SetPropertyValue(entity, nameof(Sys_Parameter.DataStatus), 1);

            return entity;
        }
        /// <summary>
        /// 获取为创建操作所需常用值
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="operTime"></param>
        /// <returns></returns>
        public static Dictionary<Field, object> GetCreationValues<TEntity>(DateTime? operTime = null) where TEntity : Entity
        {
            Dictionary<Field, object> dict = new Dictionary<Field, object>();
            var fields = EntityCache.GetFields<TEntity>();
            //设置创建者
            if (fields.Any(d => d.PropertyName == nameof(Sys_Parameter.CreatorUserId)))
                dict[fields.First(d => d.PropertyName == nameof(Sys_Parameter.CreatorUserId))] = App.Instance.User.Id;
            //设置创建时间
            if (fields.Any(d => d.PropertyName == nameof(Sys_Parameter.CreationTime)))
            {
                if (operTime == null)
                    operTime = DBHelper.Instance.ServerTime;
                dict[fields.First(d => d.PropertyName == nameof(Sys_Parameter.CreationTime))] = operTime.Value;
            }
            //设置操作人
            if (fields.Any(d => d.PropertyName == nameof(Sys_Parameter.LastModifierUserId)))
                dict[fields.First(d => d.PropertyName == nameof(Sys_Parameter.LastModifierUserId))] = App.Instance.User.Id;
            //设置操作时间
            if (fields.Any(d => d.PropertyName == nameof(Sys_Parameter.LastModificationTime)))
            {
                if (operTime == null)
                    operTime = DBHelper.Instance.ServerTime;
                dict[fields.First(d => d.PropertyName == nameof(Sys_Parameter.LastModificationTime))] = operTime.Value;
            }
            return dict;
        }
        /// <summary>
        /// 为修改操作赋值
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        /// <param name="operTime"></param>
        public static TEntity SetModificationValues<TEntity>(this TEntity entity, DateTime? operTime = null) where TEntity : Entity
        {
            var fields = EntityCache.GetFields<TEntity>();
            //设置操作人
            if (fields.Any(d => d.PropertyName == nameof(Sys_Parameter.LastModifierUserId)))
                DataUtils.SetPropertyValue(entity, nameof(Sys_Parameter.LastModifierUserId), App.Instance.User.Id);
            //设置操作时间
            if (fields.Any(d => d.PropertyName == nameof(Sys_Parameter.LastModificationTime)))
            {
                if (operTime == null)
                    operTime = DBHelper.Instance.ServerTime;
                DataUtils.SetPropertyValue(entity, nameof(Sys_Parameter.LastModificationTime), operTime.Value);
            }

            return entity;
        }
        /// <summary>
        /// 获取为修改操作所需常用值
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="operTime"></param>
        /// <returns></returns>
        public static Dictionary<Field, object> GetModificationValues<TEntity>(DateTime? operTime = null) where TEntity : Entity
        {
            Dictionary<Field, object> dict = new Dictionary<Field, object>();
            var fields = EntityCache.GetFields<TEntity>();
            //设置操作人
            if (fields.Any(d => d.PropertyName == nameof(Sys_Parameter.LastModifierUserId)))
                dict[fields.First(d => d.PropertyName == nameof(Sys_Parameter.LastModifierUserId))] = App.Instance.User.Id;
            //设置操作时间
            if (fields.Any(d => d.PropertyName == nameof(Sys_Parameter.LastModificationTime)))
            {
                if (operTime == null)
                    operTime = DBHelper.Instance.ServerTime;
                dict[fields.First(d => d.PropertyName == nameof(Sys_Parameter.LastModificationTime))] = operTime.Value;
            }

            return dict;
        }
        /// <summary>
        /// 为删除操作赋值
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        /// <param name="operTime"></param>
        public static TEntity SetDeletionValues<TEntity>(this TEntity entity, DateTime? operTime = null) where TEntity : Entity
        {
            var fields = EntityCache.GetFields<TEntity>();
            //设置删除人
            if (fields.Any(d => d.PropertyName == nameof(Sys_Parameter.DeleterUserId)))
                DataUtils.SetPropertyValue(entity, nameof(Sys_Parameter.DeleterUserId), App.Instance.User.Id);
            //设置删除时间
            if (fields.Any(d => d.PropertyName == nameof(Sys_Parameter.DeletionTime)))
            {
                if (operTime == null)
                    operTime = DBHelper.Instance.ServerTime;
                DataUtils.SetPropertyValue(entity, nameof(Sys_Parameter.DeletionTime), operTime.Value);
            }
            //设置操作人
            if (fields.Any(d => d.PropertyName == nameof(Sys_Parameter.LastModifierUserId)))
                DataUtils.SetPropertyValue(entity, nameof(Sys_Parameter.LastModifierUserId), App.Instance.User.Id);
            //设置操作时间
            if (fields.Any(d => d.PropertyName == nameof(Sys_Parameter.LastModificationTime)))
            {
                if (operTime == null)
                    operTime = DBHelper.Instance.ServerTime;
                DataUtils.SetPropertyValue(entity, nameof(Sys_Parameter.LastModificationTime), operTime.Value);
            }
            //设置删除标记
            if (fields.Any(d => d.PropertyName == nameof(Sys_Parameter.DataStatus)))
                DataUtils.SetPropertyValue(entity, nameof(Sys_Parameter.DataStatus), (int)DataStatus.Delete);

            return entity;
        }
        /// <summary>
        /// 获取为删除操作所需常用值
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="operTime"></param>
        /// <returns></returns>
        public static Dictionary<Field, object> GetDeletionValues<TEntity>(DateTime? operTime = null) where TEntity : Entity
        {
            Dictionary<Field, object> dict = new Dictionary<Field, object>();
            var fields = EntityCache.GetFields<TEntity>();
            //设置删除者
            if (fields.Any(d => d.PropertyName == nameof(Sys_Parameter.DeleterUserId)))
                dict[fields.First(d => d.PropertyName == nameof(Sys_Parameter.DeleterUserId))] = App.Instance.User.Id;
            //设置删除时间
            if (fields.Any(d => d.PropertyName == nameof(Sys_Parameter.DeletionTime)))
            {
                if (operTime == null)
                    operTime = DBHelper.Instance.ServerTime;
                dict[fields.First(d => d.PropertyName == nameof(Sys_Parameter.DeletionTime))] = operTime.Value;
            }
            //设置操作人
            if (fields.Any(d => d.PropertyName == nameof(Sys_Parameter.LastModifierUserId)))
                dict[fields.First(d => d.PropertyName == nameof(Sys_Parameter.LastModifierUserId))] = App.Instance.User.Id;
            //设置操作时间
            if (fields.Any(d => d.PropertyName == nameof(Sys_Parameter.LastModificationTime)))
            {
                if (operTime == null)
                    operTime = DBHelper.Instance.ServerTime;
                dict[fields.First(d => d.PropertyName == nameof(Sys_Parameter.LastModificationTime))] = operTime.Value;
            }
            //设置删除标记
            if (fields.Any(d => d.PropertyName == nameof(Sys_Parameter.DataStatus)))
                dict[fields.First(d => d.PropertyName == nameof(Sys_Parameter.DataStatus))] = (int)DataStatus.Delete;
            return dict;
        }
    }
}
