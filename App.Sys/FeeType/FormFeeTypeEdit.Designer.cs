namespace App_Sys
{
    partial class FormFeeTypeEdit
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tbxCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.tbxName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.swbDataStatus = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.FontBold = true;
            this.labelX1.Location = new System.Drawing.Point(29, 20);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(101, 20);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "费用类型编码:";
            // 
            // tbxCode
            // 
            // 
            // 
            // 
            this.tbxCode.Border.Class = "TextBoxBorder";
            this.tbxCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxCode.Location = new System.Drawing.Point(136, 17);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.PreventEnterBeep = true;
            this.tbxCode.ReadOnly = true;
            this.tbxCode.Size = new System.Drawing.Size(200, 23);
            this.tbxCode.TabIndex = 1;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.FontBold = true;
            this.labelX2.Location = new System.Drawing.Point(29, 49);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(101, 20);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "费用类型名称:";
            // 
            // tbxName
            // 
            // 
            // 
            // 
            this.tbxName.Border.Class = "TextBoxBorder";
            this.tbxName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxName.Location = new System.Drawing.Point(136, 46);
            this.tbxName.Name = "tbxName";
            this.tbxName.PreventEnterBeep = true;
            this.tbxName.Size = new System.Drawing.Size(200, 23);
            this.tbxName.TabIndex = 3;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(58, 78);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(72, 20);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "启用状态:";
            // 
            // swbDataStatus
            // 
            // 
            // 
            // 
            this.swbDataStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swbDataStatus.Location = new System.Drawing.Point(136, 78);
            this.swbDataStatus.Name = "swbDataStatus";
            this.swbDataStatus.OffText = "否";
            this.swbDataStatus.OnText = "是";
            this.swbDataStatus.Size = new System.Drawing.Size(66, 22);
            this.swbDataStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swbDataStatus.TabIndex = 5;
            this.swbDataStatus.Value = true;
            this.swbDataStatus.ValueObject = "Y";
            // 
            // FormFeeTypeEdit
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
            this.ClientSize = new System.Drawing.Size(376, 151);
            this.Controls.Add(this.swbDataStatus);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.tbxCode);
            this.Controls.Add(this.labelX1);
            this.IgnoreBtn.AutoSize = false;
            this.IgnoreBtn.Enable = true;
            this.IgnoreBtn.Text = "忽略";
            this.IgnoreBtn.Width = 64;
            this.Name = "FormFeeTypeEdit";
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
            this.Text = "修改费用类型";
            this.YesBtn.AutoSize = false;
            this.YesBtn.Enable = true;
            this.YesBtn.Text = "是";
            this.YesBtn.Width = 64;
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.tbxCode, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.tbxName, 0);
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.swbDataStatus, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxCode;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxName;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.SwitchButton swbDataStatus;
    }
}