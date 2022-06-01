using HIS.Core.UI;
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

namespace App_OP.MedicalRecord
{
    /// <summary>
    /// 创建人:wfg
    /// 创建时间:2021-02-26 14:47:02
    /// 描述:
    /// </summary>
    public partial class FormTemplateSampleDesigner : BaseForm
    {
        public FormTemplateSampleDesigner()
        {
            InitializeComponent();
            this.ucTemplateSampleWrite.Save += UcTemplateSampleWrite_Save;
            this.ucTemplateSampleTree.SelectedTemplateSample += UcTemplateSampleTree_SelectedTemplateSample;
        }

        private void UcTemplateSampleTree_SelectedTemplateSample(object sender, TemplateSampleEntity sampleEntity)
        {
            this.ucTemplateSampleWrite.RemoverTable();
            if (sampleEntity != null && sampleEntity.NodeType == NodeType.Content)
                this.ucTemplateSampleWrite.Content = sampleEntity.Content;
            this.ucTemplateSampleWrite.Enabled = sampleEntity != null && sampleEntity.NodeType == NodeType.Content;
        }

        private void UcTemplateSampleWrite_Save(object sender, string content)
        {
            this.ucTemplateSampleTree.SaveContent(content);
        }

        private void FormTemplateSampleDesigner_Shown(object sender, EventArgs e)
        {
            this.ucTemplateSampleTree.DeptEntity = this.ViewData.Dept;
            this.ucTemplateSampleTree.Init();
        }
        protected override void OnDeptChanged()
        {
            this.ucTemplateSampleTree.DeptEntity = this.ViewData.Dept;
            this.ucTemplateSampleTree.Init();
        }
    }
}
