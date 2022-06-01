using HIS.Core.UI;
using HIS.Service.Core.Entities;
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
    /// 创建时间:2021-03-03 15:09:25
    /// 描述:
    /// </summary>
    public partial class FormSubTemplateSampleDesigner : BaseForm
    {
        public FormSubTemplateSampleDesigner()
        {
            InitializeComponent();
            this.ucSubTemplateSampleWrite.Save += UcSubTemplateSampleWrite_Save;
            this.ucSubTemplateSampleTree.SelectedSubTemplateSample += UcSubTemplateSampleTree_SelectedSubTemplateSample;
        }

        private void UcSubTemplateSampleTree_SelectedSubTemplateSample(object sender, SubTemplateSampleEntity subTemplateSampleEntity)
        {
            this.ucSubTemplateSampleWrite.Content = subTemplateSampleEntity?.Content ?? "";
            this.ucSubTemplateSampleWrite.Enabled = subTemplateSampleEntity != null && subTemplateSampleEntity.NodeType == HIS.Service.Core.Enums.NodeType.Content;
        }

        private void UcSubTemplateSampleWrite_Save(object sender, string content)
        {
            this.ucSubTemplateSampleTree.SaveContent(content);
        }

        private void FormSubTemplateSampleDesigner_Shown(object sender, EventArgs e)
        {
            this.ucSubTemplateSampleTree.DeptEntity = this.ViewData.Dept;
            this.ucSubTemplateSampleTree.Init();
        }

        protected override void OnDeptChanged()
        {
            this.ucSubTemplateSampleTree.DeptEntity = this.ViewData.Dept;
            this.ucSubTemplateSampleTree.Init();
        }
    }
}
