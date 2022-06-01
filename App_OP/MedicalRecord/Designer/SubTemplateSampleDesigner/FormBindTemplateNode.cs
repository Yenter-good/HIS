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
using HIS.Core;

namespace App_OP.MedicalRecord
{
    /// <summary>
    /// 创建人:wfg
    /// 创建时间:2021-03-03 16:18:06
    /// 描述:
    /// </summary>
    public partial class FormBindTemplateNode : BaseDialogForm
    {
        private ISysDictQueryService _sysDictQueryService;
        public long SelectedTemplateNodeId;
        public FormBindTemplateNode(ISysDictQueryService sysDictQueryService)
        {
            InitializeComponent();
            this._sysDictQueryService = sysDictQueryService;
        }

        private void FormBindTemplateNode_Shown(object sender, EventArgs e)
        {
            var templateNodes = this._sysDictQueryService.GetOPTemplateNode();
            foreach (var item in templateNodes)
                item.Code = SpellHelper.GetSpells(item.Value);
            this.fcbxTemplateNodes.DataSource = templateNodes;
            this.fcbxTemplateNodes.DisplayMember = nameof(LongItem.Value);
            this.fcbxTemplateNodes.ValueMember = nameof(LongItem.Key);
            this.fcbxTemplateNodes.FilterFields = new string[] { nameof(LongItem.Value), nameof(LongItem.Code) };
            if (SelectedTemplateNodeId > 0)
                this.fcbxTemplateNodes.SelectedValue = this.SelectedTemplateNodeId;
        }

        protected override void OnOK()
        {
            this.SelectedTemplateNodeId = this.fcbxTemplateNodes.SelectedValue.AsLong(0);
            if (this.SelectedTemplateNodeId == 0)
            {
                MsgBox.OK("请选择节点");
                this.fcbxTemplateNodes.Focus();
                return;
            }

            base.OnOK();
        }
    }
}
