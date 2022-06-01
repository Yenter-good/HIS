using DevComponents.DotNetBar.SuperGrid;
using HIS.Core;
using HIS.Core.UI;
using HIS.DSkinControl;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using HIS.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_OP.Diagnosis
{
    public partial class FormDeptDiagnosis : BaseForm
    {
        IOPPatientDiagnosisService _patientDiagnosis;
        IDiagnosisService _diagnosisDervice;

        List<DiagnosisEntity> icdList = new List<DiagnosisEntity>();
        public FormDeptDiagnosis(IOPPatientDiagnosisService patientDiagnosis , IDiagnosisService diagnosisDervice)
        {
            InitializeComponent();
            this._diagnosisDervice = diagnosisDervice;
            this._patientDiagnosis = patientDiagnosis;
        }

        private void FormDeptDiagnosis_Shown(object sender, EventArgs e)
        {
            this.ShowMask(()=> {
                LoadDiagnosisICD();
                LoadDiagnosisDept();
            }) ;
        }
    
        private void LoadDiagnosisDept() 
        {
            List<DiagnosisEntity> list  = _patientDiagnosis.GetDiagnosisGroup(ViewData.Dept.Id);
            this.dgvRight.PrimaryGrid.DataSource = list;
        }

        private void LoadDiagnosisICD() 
        {
            icdList = _diagnosisDervice.Get();
            this.dgvLeft.PrimaryGrid.DataSource = icdList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add(0);

        }
        private void btnAdd_s_Click(object sender, EventArgs e)
        {
            Add(1);
        }

        private void Add(int way)
        {
            if (this.dgvLeft.PrimaryGrid.GetSelectedRows().Count < 1)
            {
                AlertBox.Error("请选中一个标准诊断");
                return;
            }
            var model = this.dgvLeft.PrimaryGrid.GetSelectedRows()[0].As<GridRow>().DataItem as DiagnosisEntity;

            foreach (GridRow row in this.dgvRight.PrimaryGrid.Rows)
            {
                var item = row.DataItem as DiagnosisEntity;
                if (item.Code == model.Code && item.Name == model.Name)
                {
                    AlertBox.Info("请勿重复添加！");
                    return;
                }
            }

            DeptDiagnosisEntity entity = new DeptDiagnosisEntity();
            entity.DeptId = ViewData.Dept.Id;
            entity.Code = model.Code;
            entity.Name = way == 0 ? model.Name : tbxName.Text;//way 0 从标准诊断中添加  1 自定义诊断添加
            entity.SearchCode = SpellHelper.GetSpells(model.Name);
            entity.WubiCode = SpellHelper.GetWuBis(model.Name);
            entity.Type = way == 0 ? model.Type: DiagnosisType.Custom;

            DataResult<DeptDiagnosisEntity> result = _diagnosisDervice.AddDeptDiagnosis(entity);

            if (result.Success)
                LoadDiagnosisDept();
            else
                AlertBox.Error(result.Message);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DeleteDeptDiiagnosis();
        }

        private void tbxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string str = tbxSearch.Text.Trim();

                var subList = icdList.Where(p => p.Name.Contains(str) || p.SearchCode.Contains(str)).ToList();
                this.dgvLeft.PrimaryGrid.DataSource = subList;
            }
        }

        private void dgvLeft_CellDoubleClick(object sender, GridCellDoubleClickEventArgs e)
        {
            Add(0);
        }

        private void dgvRight_CellDoubleClick(object sender, GridCellDoubleClickEventArgs e)
        {
            DeleteDeptDiiagnosis();
        }

        private void DeleteDeptDiiagnosis() {
            if (this.dgvRight.PrimaryGrid.GetSelectedRows().Count < 1)
            {
                AlertBox.Info("请选中一行");
                return;
            }
            var model = this.dgvRight.PrimaryGrid.GetSelectedRows()[0].As<GridRow>().DataItem as DiagnosisEntity;

            DataResult<DeptDiagnosisEntity> result = _diagnosisDervice.DeleteDeptDiagnosis(model.Code, model.Name, ViewData.Dept.Id);

            if (result.Success)
                LoadDiagnosisDept();
            else
                AlertBox.Error(result.Message);

        }

    }
}
