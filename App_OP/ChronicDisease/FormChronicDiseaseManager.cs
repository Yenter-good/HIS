using DevComponents.DotNetBar.SuperGrid;
using HIS.Core;
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

namespace App_OP.ChronicDisease
{
    public partial class FormChronicDiseaseManager : BaseForm
    {

        public IOPChronicDiseases _diseasesService;
        public IDrugInventoryService _drugService;

        public FormChronicDiseaseManager(IOPChronicDiseases diseasesService, IDrugInventoryService drugService)
        {
            InitializeComponent();
            this._diseasesService = diseasesService;
            this._drugService = drugService;
        }

        private void FormChronicDiseaseManager_Load(object sender, EventArgs e)
        {
            LoadDiseaseData();
            LoadDrugList();
        }
        private void dgvLeft_CellClick(object sender, GridCellClickEventArgs e)
        {
            LoadHasDrug();
        }
        private void LoadDrugList()
        {
            List<DrugInventoryEntity> list = _drugService.WholehospitalDrugInfoGetAll();
            this.dgvMiddle.PrimaryGrid.DataSource = list;
        }

        private void LoadHasDrug()
        {
            if (this.dgvLeft.PrimaryGrid.GetSelectedRows().Count < 1)
            {
                AlertBox.Info("请选中一行");
                return;
            }
            var model = this.dgvLeft.PrimaryGrid.GetSelectedRows()[0].As<GridRow>().DataItem as DiseasesEntity;
            List<DiseasesMapperEntity> list = _diseasesService.GetByDiseasesId(model.Id);
            this.dgvRight.PrimaryGrid.DataSource = list;
        }

        private void LoadDiseaseData()
        {
            List<DiseasesEntity> list = _diseasesService.GetAll();
            this.dgvLeft.PrimaryGrid.DataSource = list;
            this.dgvRight.PrimaryGrid.Rows.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddDisease form = new FormAddDisease(_diseasesService);
            form.status = "add";

            form.ShowDialog();
            LoadDiseaseData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditDisease();
        }
        private void dgvLeft_CellDoubleClick(object sender, GridCellDoubleClickEventArgs e)
        {
            EditDisease();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvLeft.PrimaryGrid.GetSelectedRows().Count < 1)
            {
                AlertBox.Info("请选中一行");
                return;
            }
            var model = this.dgvLeft.PrimaryGrid.GetSelectedRows()[0].As<GridRow>().DataItem as DiseasesEntity;
            DataResult<DiseasesEntity> result = _diseasesService.DeleteDiseases(model.Id);
            if (result.Success)
            {
                LoadDiseaseData();
                AlertBox.Info("删除成功");
            }
            else
                AlertBox.Error(result.Message);
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            AddDetail();
        }

        
        private void dgvMiddle_CellDoubleClick(object sender, GridCellDoubleClickEventArgs e)
        {
            AddDetail();
        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            DeleteDetail();
        }

        private void dgvRight_CellDoubleClick(object sender, GridCellDoubleClickEventArgs e)
        {
            DeleteDetail();
        }
        private void AddDetail()
        {
            if (this.dgvLeft.PrimaryGrid.GetSelectedRows().Count < 1)
            {
                AlertBox.Error("请选中一个病种");
                return;
            }
            if (this.dgvMiddle.PrimaryGrid.GetSelectedRows().Count < 1)
            {
                AlertBox.Error("请选中一行");
                return;
            }
            //选中的病种
            DiseasesEntity diseases = this.dgvLeft.PrimaryGrid.GetSelectedRows()[0].As<GridRow>().DataItem as DiseasesEntity;
            //选中的药品
            DrugInventoryEntity drug = this.dgvMiddle.PrimaryGrid.GetSelectedRows()[0].As<GridRow>().DataItem as DrugInventoryEntity;
           
            //防止重复添加
            foreach (GridRow row in this.dgvRight.PrimaryGrid.Rows)
            {
                var item = row.DataItem as DrugInventoryEntity;
                if (item.ClassCode == drug.ClassCode && item.SpecificationCode == item.SpecificationCode)
                {
                    return;
                }
            }

            DataResult<DiseasesMapperEntity> result = _diseasesService.AddDetail(diseases.Id,drug.ClassCode,drug.SpecificationCode);
            if (result.Success)
            {
                LoadHasDrug();
                AlertBox.Info("添加成功");
            }
            else
                AlertBox.Error(result.Message);
                

        }
        private void DeleteDetail()
        { 
            if (this.dgvRight.PrimaryGrid.GetSelectedRows().Count < 1)
            {
                AlertBox.Info("请选中一行");
                return;
            }
            DiseasesMapperEntity detail = this.dgvRight.PrimaryGrid.GetSelectedRows()[0].As<GridRow>().DataItem as DiseasesMapperEntity;
            DataResult<DiseasesMapperEntity> result = _diseasesService.DeleteDetail(detail.Id);
            if (result.Success)
            {
                LoadHasDrug();
                AlertBox.Info("删除成功");
            }
            else
                AlertBox.Error(result.Message);



        }
        private void dgvLeft_GetCellFormattedValue(object sender, GridGetCellFormattedValueEventArgs e)
        {
            if (e.GridCell.GridColumn.Name == "colType")
            {
                var item = e.GridCell.GridRow.DataItem as DiseasesEntity;
                if (item != null)
                    e.FormattedValue = item.Type == 1 ? "职工慢病" : "居民慢病";
            }
        }

        

        private void EditDisease()
        {
            if (this.dgvLeft.PrimaryGrid.GetSelectedRows().Count < 1)
            {
                AlertBox.Info("请选中一行");
                return;
            }
            var model = this.dgvLeft.PrimaryGrid.GetSelectedRows()[0].As<GridRow>().DataItem as DiseasesEntity;

            FormAddDisease form = new FormAddDisease(_diseasesService);
            form.status = "edit";
            form.diseases = model;

            form.ShowDialog();
            LoadDiseaseData();
        }
    }
}
