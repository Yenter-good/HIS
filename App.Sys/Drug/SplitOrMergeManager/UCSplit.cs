using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIS.Core;
using HIS.Service.Core.Entities;


namespace App_Sys.Drug.SplitOrMergeManager
{
    internal partial class UCSplit : UCBaseSplitOrMerge
    {
        public UCSplit()
        {
            InitializeComponent();
        }

        #region 方法
        /// <summary>
        /// 界面初始化
        /// </summary>
        /// <param name="selectedDrug">当前选中的药品</param>
        /// <param name="opPharmacyFlag">门诊药房标识 true表示是门诊药房 false表示是临床药房</param>
        internal override void ShowData(DrugInventoryEntity selectedDrug, bool opPharmacyFlag)
        {
            this.SelectedDrug = null;
            this.PharmacyFlag = opPharmacyFlag ? Pharmacy.Op : Pharmacy.Ip;
            this.intAllowSplitBigPackageQuantity.ValueChanged -= IntAllowSplitBigPackageQuantity_ValueChanged;
            this.intAllowSplitBigPackageQuantity.Value = 0;
            this.intAfterSplitSmallPackageQuantity.Value = 0;
            this.intAllowSplitBigPackageQuantity.MinValue = 0;
            this.intAllowSplitBigPackageQuantity.ValueChanged += IntAllowSplitBigPackageQuantity_ValueChanged;

            this.SelectedDrug = selectedDrug;
            if (this.SelectedDrug != null)
            {
                this.intAllowSplitBigPackageQuantity.MaxValue = this.SelectedDrug.BigPackageQuantity;
                this.intAllowSplitBigPackageQuantity.Value = this.SelectedDrug.BigPackageQuantity;
            }
        }
        /// <summary>
        /// 获取小包装数
        /// </summary>
        /// <param name="packageNumber">包装数</param>
        /// <returns></returns>
        private int GetSmallPackageQuantity(int packageNumber)
        {
            return this.intAllowSplitBigPackageQuantity.Value * packageNumber;
        }
        /// <summary>
        /// 设置焦点
        /// </summary>
        internal override void SetFocus()
        {
            this.intAllowSplitBigPackageQuantity.Focus();
        }

        #endregion

        #region 事件
        private void IntAllowSplitBigPackageQuantity_ValueChanged(object sender, EventArgs e)
        {
            this.intAfterSplitSmallPackageQuantity.Value = this.GetSmallPackageQuantity(this.SelectedDrug.PackageNumber);
        }

        private void btnAllSplit_Click(object sender, EventArgs e)
        {
            //当用户点击全部拆分时，设置大包装数
            this.intAllowSplitBigPackageQuantity.Value = this.SelectedDrug.BigPackageQuantity;
            if (this.intAfterSplitSmallPackageQuantity.Value == 0)
            {
                MsgBox.OK("拆分后的小包装数为0，无法拆分");
                this.SetFocus();
                return;
            }
            if (MsgBox.YesNo("是否全部拆分?") != DialogResult.Yes)
            {
                return;
            }

            var result = this.DrugSplitOrMergeService.DrugSplitOrMerge(this.SelectedDrug.InventoryId
                 , (int)this.PharmacyFlag
                 , (int)DrugOperation.AllSplit);

            if (!result.Success)
            {
                MsgBox.OK($"全部拆分失败\r\n{result.Message}");
                return;
            }
            else
            {
                this.ScuessCallback?.Invoke();
                AlertBox.Info("全部拆分成功");
            }
        }

        private void btnCustomSplit_Click(object sender, EventArgs e)
        {
            if (this.intAfterSplitSmallPackageQuantity.Value == 0)
            {
                MsgBox.OK("拆分后的小包装数为0，无法拆分");
                return;
            }
            if (MsgBox.YesNo("是否自定义拆分?") != DialogResult.Yes)
            {
                return;
            }

            var result = this.DrugSplitOrMergeService.DrugSplitOrMerge(this.SelectedDrug.InventoryId
                 , (int)this.PharmacyFlag
                 , (int)DrugOperation.CustomSplit
                 , this.intAllowSplitBigPackageQuantity.Value);

            if (!result.Success)
            {
                MsgBox.OK($"自定义拆分失败\r\n{result.Message}");
                return;
            }
            else
            {
                this.ScuessCallback?.Invoke();
                AlertBox.Info("自定义拆分成功");
            }
        }

        #endregion
    }
}
