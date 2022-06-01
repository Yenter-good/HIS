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
using HIS.Core;
using HIS.Service.Core.Entities;


namespace App_Sys.Drug.SplitOrMergeManager
{
    internal partial class UCMerge : UCBaseSplitOrMerge
    {
        public UCMerge()
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
            this.intAllowMergeSmallPackageQuantity.ValueChanged -= IntAllowMergeSmallPackageQuantity_ValueChanged;
            this.intAllowMergeSmallPackageQuantity.Value = 0;
            this.intAfterMergeBigPackageQuantity.Value = 0;
            this.intAllowMergeSmallPackageQuantity.MinValue = 0;
            this.intAllowMergeSmallPackageQuantity.ValueChanged += IntAllowMergeSmallPackageQuantity_ValueChanged;

            this.SelectedDrug = selectedDrug;
            if (this.SelectedDrug != null)
            {
                this.intAllowMergeSmallPackageQuantity.MaxValue = this.SelectedDrug.SmallPackageQuantity;
                this.intAllowMergeSmallPackageQuantity.Value = this.SelectedDrug.SmallPackageQuantity;
            }
        }
        /// <summary>
        /// 获取大包装数
        /// </summary>
        /// <param name="packageNumber">包装数</param>
        /// <returns></returns>
        private int GetBigPackageQuantity(int packageNumber)
        {
            return this.intAllowMergeSmallPackageQuantity.Value / packageNumber;
        }
        /// <summary>
        /// 设置焦点
        /// </summary>
        internal override void SetFocus()
        {
            this.intAllowMergeSmallPackageQuantity.Focus();
        }

        #endregion

        #region 事件
        private void IntAllowMergeSmallPackageQuantity_ValueChanged(object sender, EventArgs e)
        {
            this.intAfterMergeBigPackageQuantity.Value = this.GetBigPackageQuantity(this.SelectedDrug.PackageNumber);
        }
        private void btnAllMerge_Click(object sender, EventArgs e)
        {
            //当用户点击全部合并时设置小包装数
            this.intAllowMergeSmallPackageQuantity.Value = this.SelectedDrug.SmallPackageQuantity;
            if (this.intAfterMergeBigPackageQuantity.Value == 0)
            {
                MsgBox.OK("合并后的大包装为0，无法合并");
                this.SetFocus();
                return;
            }
            if (MsgBox.YesNo("是否全部合并?") != DialogResult.Yes)
            {
                return;
            }

            var result = this.DrugSplitOrMergeService.DrugSplitOrMerge(this.SelectedDrug.InventoryId
                 , (int)this.PharmacyFlag
                 , (int)DrugOperation.AllMerge);

            if (!result.Success)
            {
                MsgBox.OK($"全部合并失败\r\n{result.Message}");
                return;
            }
            else
            {
                this.ScuessCallback?.Invoke();
                AlertBox.Info("全部合并成功");
            }
        }

        private void btnCustomMerge_Click(object sender, EventArgs e)
        {
            if (this.intAllowMergeSmallPackageQuantity.Value == 0)
            {
                MsgBox.OK("合并后的大包装数为0，无法合并");
                return;
            }
            if (MsgBox.YesNo("是否自定义合并?") != DialogResult.Yes)
            {
                return;
            }

            var result = this.DrugSplitOrMergeService.DrugSplitOrMerge(this.SelectedDrug.InventoryId
                 , (int)this.PharmacyFlag
                 , (int)DrugOperation.CustomMerge
                 , this.intAfterMergeBigPackageQuantity.Value);

            if (!result.Success)
            {
                MsgBox.OK($"自定义合并失败\r\n{result.Message}");
                return;
            }
            else
            {
                this.ScuessCallback?.Invoke();
                AlertBox.Info("自定义合并成功");
            }
        }

        #endregion
    }
}
