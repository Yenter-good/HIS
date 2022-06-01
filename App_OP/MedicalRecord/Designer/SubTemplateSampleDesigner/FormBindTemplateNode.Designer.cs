namespace App_OP.MedicalRecord
{
    partial class FormBindTemplateNode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fcbxTemplateNodes = new HIS.ControlLib.Popups.FindComboBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // fcbxTemplateNodes
            // 
            this.fcbxTemplateNodes.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.fcbxTemplateNodes.Border.Class = "TextBoxBorder";
            this.fcbxTemplateNodes.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.fcbxTemplateNodes.CanResizePopup = false;
            this.fcbxTemplateNodes.ColumnHeaders = null;
            this.fcbxTemplateNodes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.fcbxTemplateNodes.DataSource = null;
            this.fcbxTemplateNodes.DisplayMember = "";
            this.fcbxTemplateNodes.FilterFields = null;
            this.fcbxTemplateNodes.FocusOpen = false;
            this.fcbxTemplateNodes.Location = new System.Drawing.Point(101, 36);
            this.fcbxTemplateNodes.Name = "fcbxTemplateNodes";
            this.fcbxTemplateNodes.PopupBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(225)))));
            this.fcbxTemplateNodes.PopupBorderWidth = new System.Windows.Forms.Padding(1);
            this.fcbxTemplateNodes.PopupMaximumSize = new System.Drawing.Size(0, 450);
            this.fcbxTemplateNodes.PopupMinimumSize = new System.Drawing.Size(0, 25);
            this.fcbxTemplateNodes.PopupOffSet = 2;
            this.fcbxTemplateNodes.PreventEnterBeep = true;
            this.fcbxTemplateNodes.ReadOnly = true;
            this.fcbxTemplateNodes.SelectedItem = null;
            this.fcbxTemplateNodes.SelectedValue = null;
            this.fcbxTemplateNodes.ShowClearButton = true;
            this.fcbxTemplateNodes.ShowPopupShadow = false;
            this.fcbxTemplateNodes.Size = new System.Drawing.Size(169, 23);
            this.fcbxTemplateNodes.SupportPinyinSearch = false;
            this.fcbxTemplateNodes.SupportWubiSearch = false;
            this.fcbxTemplateNodes.TabIndex = 1004;
            this.fcbxTemplateNodes.ValueMember = null;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(23, 39);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(72, 20);
            this.labelX1.TabIndex = 1005;
            this.labelX1.Text = "选择节点:";
            // 
            // FormBindTemplateNode
            // 
            this.AbortBtn.AutoSize = false;
            this.AbortBtn.Enable = true;
            this.AbortBtn.Text = "中止";
            this.AbortBtn.Width = 64;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelBtn.AutoSize = false;
            this.CancelBtn.Enable = true;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.Width = 64;
            this.ClientSize = new System.Drawing.Size(290, 123);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.fcbxTemplateNodes);
            this.IgnoreBtn.AutoSize = false;
            this.IgnoreBtn.Enable = true;
            this.IgnoreBtn.Text = "忽略";
            this.IgnoreBtn.Width = 64;
            this.Name = "FormBindTemplateNode";
            this.NoBtn.AutoSize = false;
            this.NoBtn.Enable = true;
            this.NoBtn.Text = "否";
            this.NoBtn.Width = 64;
            this.OKBtn.AutoSize = false;
            this.OKBtn.Enable = true;
            this.OKBtn.Text = "确定";
            this.OKBtn.Width = 64;
            this.RetryBtn.AutoSize = false;
            this.RetryBtn.Enable = true;
            this.RetryBtn.Text = "重试";
            this.RetryBtn.Width = 64;
            this.Text = "绑定模板节点";
            this.YesBtn.AutoSize = false;
            this.YesBtn.Enable = true;
            this.YesBtn.Text = "是";
            this.YesBtn.Width = 64;
            this.Shown += new System.EventHandler(this.FormBindTemplateNode_Shown);
            this.Controls.SetChildIndex(this.fcbxTemplateNodes, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HIS.ControlLib.Popups.FindComboBox fcbxTemplateNodes;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}