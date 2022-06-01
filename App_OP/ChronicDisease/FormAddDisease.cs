using HIS.Core;
using HIS.Core.UI;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
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

namespace App_OP.ChronicDisease
{
    public partial class FormAddDisease : BaseDialogForm
    {
        private IOPChronicDiseases _diseasesService;
        public FormAddDisease(IOPChronicDiseases diseasesService)
        {
            InitializeComponent();
            this._diseasesService = diseasesService;
        }

        public string status = "add";//状态 编辑或新增
        public int type = 1;//1职工慢病  2居民慢病


        public DiseasesEntity diseases = new DiseasesEntity();

        private void SetValue()
        {
            rdo1.Checked = diseases.Type == 1;
            rdo2.Checked = diseases.Type == 2;
            tbxName.Text = diseases.Name;
            tbxCode.Text = diseases.Code;
        }
        private void GetValue()
        {
            diseases.Code = tbxCode.Text.Trim();
            diseases.Name = tbxName.Text.Trim();
            diseases.SearchCode = SpellHelper.GetSpells(tbxName.Text);
            diseases.WubiCode = SpellHelper.GetWuBis(tbxName.Text);
            diseases.Type = rdo1.Checked ? 1 : 2;
        }

        private void FormAddDisease_Load(object sender, EventArgs e)
        {
            if (status != "add")
            {
                SetValue();
            }
        }

        protected override void OnOK()
        {
            if (!Validing()) return;
            DataResult<DiseasesEntity> result = null;
            GetValue();

            if (status == "add")
            {
                result = _diseasesService.AddDiseases(diseases);
            }
            else
            {
                result = _diseasesService.UpdateDiseases(diseases.Id, diseases);
            }

            if (result.Success)
            {
                AlertBox.Info("保存成功");
                this.Close();
            }
            else
            {
                AlertBox.Error(result.Message);
            }
        }
        private bool Validing()
        {
            if (string.IsNullOrWhiteSpace(tbxCode.Text))
            {
                tbxCode.Focus();
                AlertBox.Error("疾病编码不可以为空");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbxName.Text))
            {
                tbxName.Focus();
                AlertBox.Error("疾病名称不可以为空");
                return false;
            }
            return true;
        }

    }
}
