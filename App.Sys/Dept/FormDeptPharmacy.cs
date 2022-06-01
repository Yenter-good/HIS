using HIS.Core.UI;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Sys.Dept
{
    public partial class FormDeptPharmacy : BaseDialogForm
    {
        private IDeptService _deptService;

        public DeptEntity currDept = new DeptPharmacyEntity();

        private bool b = false;//控制 dgvMain_SelectValueChanged 是否进行数据库操作
        public FormDeptPharmacy(IDeptService deptService)
        {
            InitializeComponent();
            this._deptService = deptService;
        }

        private void FormDeptPharmacy_Load(object sender, EventArgs e)
        {

            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AutoGenerateColumns = false;

            this.dgvMain.SelectColumn = colCheck;

            List<DeptCategoryDetail> categoryDetail = new List<DeptCategoryDetail>();
            categoryDetail.Add(DeptCategoryDetail.HMPharmacy);
            categoryDetail.Add(DeptCategoryDetail.WMPharmacy);
            List<DeptEntity> deptList = _deptService.GetListByCategoryDetail(categoryDetail);

            this.dgvMain.DataSource = deptList;

            SetCheckData();
        }
        //循环加载 科室是否有对应药房
        private void SetCheckData()
        {
            b = false;
            List<DeptPharmacyEntity> list = _deptService.GetPharmacyMapper(currDept.Id);
            if (list.Count < 1)
            {
                b = true;
                return;
            }

            foreach (DataGridViewRow row in this.dgvMain.Rows)
            {
                DeptEntity dept = row.DataBoundItem as DeptEntity;
                foreach (DeptPharmacyEntity entity in list)
                {
                    if (dept.Id == entity.PharmacyId)
                    {
                        row.Cells["colCheck"].Value = true;
                    }
                }
            }
            b = true;
        }

        private void dgvMain_SelectValueChanged(object sender, HIS.ControlLib.SelectValueChangedEventArgs e)
        {
            if (b == false) return;
            DeptEntity pharmacy = this.dgvMain.Rows[e.RowIndex].DataBoundItem as DeptEntity;
            bool check = this.dgvMain.Rows[e.RowIndex].Cells["colCheck"].Value.AsBoolean();
            if (check)
            {
                _deptService.AddMapper(currDept.Id, pharmacy.Id);
            }
            else
            {
                _deptService.DeleteMapper(currDept.Id, pharmacy.Id);
            }

        }
    }
}
