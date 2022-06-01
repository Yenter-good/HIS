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
    public class FeeItemService : IFeeItemService
    {
        /// <summary>
        /// 添加收费项目
        /// </summary>
        /// <param name="feeItemEntity"></param>
        /// <returns></returns>
        public DataResult Add(FeeItemEntity feeItemEntity)
        {
            Dic_FeeItem feeItem = feeItemEntity.Mapper<Dic_FeeItem>();
            feeItem.SetCreationValues();
            try
            {
                DBHelper.Instance.HIS.Insert<Dic_FeeItem>(feeItem);

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 获取全部收费项目
        /// </summary>
        /// <returns></returns>

        public DataResult<List<FeeItemEntity>> GetAll()
        {
            try
            {
                List<FeeItemEntity> feeItemEntities = DBHelper.Instance.HIS.From<Dic_FeeItem>()
                     .Where(d => d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DataStatus != (int)DataStatus.Delete)
                     .OrderBy(d => d.No)
                     .ToList<Dic_FeeItem>()
                     .Mapper<List<FeeItemEntity>>();

                return DataResult.True<List<FeeItemEntity>>(feeItemEntities);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<List<FeeItemEntity>>(ex.Message);
            }
        }
        /// <summary>
        /// 根据收费项目编码获取收费项目
        /// </summary>
        /// <param name="feeTypeCode">收费项目编码</param>
        /// <returns></returns>
        public DataResult<List<FeeItemEntity>> GetListByFeeTypeCode(string feeTypeCode)
        {
            try
            {
                List<FeeItemEntity> feeItemEntities = DBHelper.Instance.HIS.From<Dic_FeeItem>()
                     .Where(d => d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id
                              && d.DataStatus != (int)DataStatus.Delete
                              && d.FinanceTypeCode == feeTypeCode)
                     .OrderBy(d => d.No)
                     .ToList<Dic_FeeItem>()
                     .Mapper<List<FeeItemEntity>>();

                return DataResult.True<List<FeeItemEntity>>(feeItemEntities);
            }
            catch (Exception ex)
            {
                return DataResult.Fault<List<FeeItemEntity>>(ex.Message);
            }
        }
        /// <summary>
        /// 更新价表数据状态
        /// </summary>
        /// <param name="id">唯一标识</param>
        /// <param name="dataStatus">数据状态</param>
        /// <returns></returns>

        public DataResult UpdateDataStatusById(long id, DataStatus dataStatus)
        {
            try
            {
                Dictionary<Dos.ORM.Field, object> updateValue = AuditionHelper.GetModificationValues<Dic_FeeItem>();
                updateValue[Dic_FeeItem._.DataStatus] = (int)dataStatus;

                DBHelper.Instance.HIS.Update<Dic_FeeItem>(updateValue, d => d.Id == id && d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id);

                return DataResult.True();

            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }

        /// <summary>
        /// 更新门诊划价标识
        /// </summary>
        /// <param name="id">唯一标识</param>
        /// <param name="oflag">是否可用</param>
        /// <returns></returns>
        public DataResult UpdateOFlagById(long id, bool oflag)
        {
            try
            {
                Dictionary<Dos.ORM.Field, object> updateValue = AuditionHelper.GetModificationValues<Dic_FeeItem>();
                updateValue[Dic_FeeItem._.OFlag] = oflag;

                DBHelper.Instance.HIS.Update<Dic_FeeItem>(updateValue, d => d.Id == id && d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id);

                return DataResult.True();

            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 更新住院划价标识
        /// </summary>
        /// <param name="id">唯一标识</param>
        /// <param name="iflag">是否可用</param>
        /// <returns></returns>
        public DataResult UpdateIFlagById(long id, bool iflag)
        {
            try
            {
                Dictionary<Dos.ORM.Field, object> updateValue = AuditionHelper.GetModificationValues<Dic_FeeItem>();
                updateValue[Dic_FeeItem._.IFlag] = iflag;

                DBHelper.Instance.HIS.Update<Dic_FeeItem>(updateValue, d => d.Id == id && d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id);

                return DataResult.True();

            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 更新手术划价标识
        /// </summary>
        /// <param name="id">唯一标识</param>
        /// <param name="sflag">是否可用</param>
        /// <returns></returns>
        public DataResult UpdateSFlagById(long id, bool sflag)
        {
            try
            {
                Dictionary<Dos.ORM.Field, object> updateValue = AuditionHelper.GetModificationValues<Dic_FeeItem>();
                updateValue[Dic_FeeItem._.SFlag] = sflag;

                DBHelper.Instance.HIS.Update<Dic_FeeItem>(updateValue, d => d.Id == id && d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id);

                return DataResult.True();

            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 更新医技划价标识
        /// </summary>
        /// <param name="id">唯一标识</param>
        /// <param name="mflag">是否可用</param>
        /// <returns></returns>
        public DataResult UpdateMFlagById(long id, bool mflag)
        {
            try
            {
                Dictionary<Dos.ORM.Field, object> updateValue = AuditionHelper.GetModificationValues<Dic_FeeItem>();
                updateValue[Dic_FeeItem._.MFlag] = mflag;

                DBHelper.Instance.HIS.Update<Dic_FeeItem>(updateValue, d => d.Id == id && d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id);

                return DataResult.True();

            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 更新价格可变标识
        /// </summary>
        /// <param name="id">唯一标识</param>
        /// <param name="variableFlag">是否可用</param>
        /// <returns></returns>
        public DataResult UpdateVariableFlagById(long id, bool variableFlag)
        {
            try
            {
                Dictionary<Dos.ORM.Field, object> updateValue = AuditionHelper.GetModificationValues<Dic_FeeItem>();
                updateValue[Dic_FeeItem._.VariableFlag] = variableFlag;

                DBHelper.Instance.HIS.Update<Dic_FeeItem>(updateValue, d => d.Id == id && d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id);

                return DataResult.True();

            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 更新收费项目
        /// </summary>
        /// <param name="feeItemEntity">收费项目</param>
        /// <returns></returns>
        public DataResult Update(FeeItemEntity feeItemEntity)
        {
            try
            {
                Dictionary<Dos.ORM.Field, object> updateValue = AuditionHelper.GetModificationValues<Dic_FeeItem>();
                updateValue[Dic_FeeItem._.FinanceTypeCode] = feeItemEntity.FinanceTypeCode;
                updateValue[Dic_FeeItem._.Name] = feeItemEntity.Name;
                updateValue[Dic_FeeItem._.SearchCode] = feeItemEntity.SearchCode;
                updateValue[Dic_FeeItem._.WubiCode] = feeItemEntity.WubiCode;
                updateValue[Dic_FeeItem._.Price] = feeItemEntity.Price;
                updateValue[Dic_FeeItem._.Specification] = feeItemEntity.Specification;
                updateValue[Dic_FeeItem._.Measure] = feeItemEntity.Measure;
                updateValue[Dic_FeeItem._.MeasureUnit] = feeItemEntity.MeasureUnit;
                updateValue[Dic_FeeItem._.DataStatus] = (int)feeItemEntity.DataStatus;
                updateValue[Dic_FeeItem._.OFlag] = feeItemEntity.OFlag;
                updateValue[Dic_FeeItem._.IFlag] = feeItemEntity.IFlag;
                updateValue[Dic_FeeItem._.SFlag] = feeItemEntity.SFlag;
                updateValue[Dic_FeeItem._.MFlag] = feeItemEntity.MFlag;
                updateValue[Dic_FeeItem._.VariableFlag] = feeItemEntity.VariableFlag;
                updateValue[Dic_FeeItem._.ExecDeptId] = feeItemEntity.ExecDeptId;

                DBHelper.Instance.HIS.Update<Dic_FeeItem>(updateValue, d => d.Id == feeItemEntity.Id && d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id);

                return DataResult.True();
            }
            catch (Exception ex)
            {
                return DataResult.Fault(ex.Message);
            }
        }
        /// <summary>
        /// 检索查询
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        public DataResult<List<FeeItemEntity>> GetListByInputValue(string inputValue)
        {
            try
            {
                List<FeeItemEntity> feeItemEntitys = null;

                if (string.IsNullOrWhiteSpace(inputValue))
                    feeItemEntitys = DBHelper.Instance.HIS.From<Dic_FeeItem>()
                        .Where(d => d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DataStatus == (int)DataStatus.Enable)
                        .OrderBy(d => d.No)
                        .ToList<Dic_FeeItem>()
                        .Mapper<List<FeeItemEntity>>();
                else
                    feeItemEntitys = DBHelper.Instance.HIS.From<Dic_FeeItem>()
                        .Where(d => d.HosId == HIS.Core.App.Instance.RuntimeSystemInfo.HospitalInfo.Id && d.DataStatus == (int)DataStatus.Enable
                           && (d.Name.Contains(inputValue) || d.SearchCode.Contains(inputValue)))
                     .OrderBy(d => d.No)
                     .ToList<Dic_FeeItem>()
                     .Mapper<List<FeeItemEntity>>();

                return DataResult.True<List<FeeItemEntity>>(feeItemEntitys);

            }
            catch (Exception ex)
            {
                return DataResult.Fault<List<FeeItemEntity>>(ex.Message);
            }
        }
    }
}
