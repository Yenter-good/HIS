using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Service.Core.Entities
{
    public class MedicalRecordEntity
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 门诊号
        /// </summary>
        public string OutpatientNo { get; set; }
        /// <summary>
        /// 主诉
        /// </summary>
        public string ChiefComplaints { get; set; }
        /// <summary>
        /// 现病史
        /// </summary>
        public string PresentIllness { get; set; }
        /// <summary>
        /// 既往史
        /// </summary>
        public string Past { get; set; }
        /// <summary>
        /// 个人史
        /// </summary>
        public string Personal { get; set; }
        /// <summary>
        /// 吸烟饮酒史
        /// </summary>
        public string Smoke { get; set; }
        /// <summary>
        /// 婚姻史
        /// </summary>
        public string Marrital { get; set; }
        /// <summary>
        /// 家族史
        /// </summary>
        public string Family { get; set; }
        /// <summary>
        /// 过敏史
        /// </summary>
        public string Allergen { get; set; }
        /// <summary>
        /// 体格检查
        /// </summary>
        public string PhysicalExamination { get; set; }
        /// <summary>
        /// 月经史
        /// </summary>
        public string Menses { get; set; }
        /// <summary>
        /// 辅助检查
        /// </summary>
        public string ExaminationResult { get; set; }
        /// <summary>
        /// 专科检查
        /// </summary>
        public string Speciality { get; set; }
        /// <summary>
        /// 其他内容
        /// </summary>
        public string OtherNode { get; set; }
        /// <summary>
        /// 初复诊 0初诊 1复诊
        /// </summary>
        public int FirstOrSecond { get; set; }
        /// <summary>
        /// 药敏史
        /// </summary>
        public string DrugAllergy { get; set; }
        /// <summary>
        /// 处置
        /// </summary>
        public string Process { get; set; }
        /// <summary>
        /// 处理
        /// </summary>
        public string DealWith { get; set; }
        /// <summary>
        /// 病历内容
        /// </summary>
        public string Content { get; set; }
    }
}
