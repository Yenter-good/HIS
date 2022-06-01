using HIS.Core.UI;
using HIS.DSkinControl;
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
    /// 创建时间:2021-02-08 15:57:43
    /// 描述:
    /// </summary>
    public partial class FormBigTemplateDesigner : BaseForm
    {
        public FormBigTemplateDesigner()
        {
            InitializeComponent();
            this.ucBigTemplateTree.SelectedBigTemplate += UcBigTemplateTree_SelectedBigTemplate;
            this.ucBigTemplateTree.ExportBigTemplate += UcBigTemplateTree_ExportBigTemplate;
            this.ucBigTemplateWrite.Save += UcBigTemplateWrite_Save; ;
        }

        private void UcBigTemplateWrite_Save(object sender, string content)
        {
            this.ucBigTemplateTree.SaveContent(content);
        }

        private void UcBigTemplateTree_ExportBigTemplate(object sender, EventArgs e)
        {
            this.ucBigTemplateWrite.FileSaveToXml();
        }

        private void UcBigTemplateTree_SelectedBigTemplate(object sender, BigTemplateEntity bigTemplate)
        {
            this.ucBigTemplateWrite.Content = bigTemplate?.Content ?? "";
            this.ucBigTemplateWrite.Enabled = bigTemplate != null;
        }

        private void FormBigTemplateDesigner_Shown(object sender, EventArgs e)
        {
            this.ShowMask(() =>
            {
                this.ucBigTemplateTree.Init();
                this.ucDataElement.Init();
            });
        }
    }
}
