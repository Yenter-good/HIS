using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIS.Service.Core;
using HIS.Service.Core.Entities;

namespace App_Sys.Drug.SplitOrMergeManager
{
    internal partial class UCBaseSplitOrMerge : UserControl
    {
        /// <summary>
        /// 药品操作标识枚举
        /// </summary>
        internal enum DrugOperation
        {
            /// <summary>
            /// 全部拆分
            /// </summary>
            AllSplit = 0,
            /// <summary>
            /// 全部合并
            /// </summary>
            AllMerge = 1,
            /// <summary>
            /// 自定义拆分
            /// </summary>
            CustomSplit = 2,
            /// <summary>
            /// 自定义合并
            /// </summary>
            CustomMerge = 3
        }
        /// <summary>
        /// 药房标识
        /// </summary>
        internal enum Pharmacy
        {
            /// <summary>
            /// 门诊药房标识
            /// </summary>
            Op = 1,
            /// <summary>
            /// 住院药房标识
            /// </summary>
            Ip = 2
        }
        internal Pharmacy PharmacyFlag;
        internal IDrugSplitOrMergeService DrugSplitOrMergeService;
        internal DrugInventoryEntity SelectedDrug;
        internal Action ScuessCallback;
        public UCBaseSplitOrMerge()
        {
            InitializeComponent();
        }
        internal virtual void SetFocus()
        {

        }
        internal virtual void ShowData(DrugInventoryEntity selectedDrug, bool opPharmacyFlag)
        {

        }
    }
}
