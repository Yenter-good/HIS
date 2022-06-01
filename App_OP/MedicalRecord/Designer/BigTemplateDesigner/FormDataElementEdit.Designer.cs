namespace App_OP.MedicalRecord
{
    partial class FormDataElementEdit
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
            this.switchButton1 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(32, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(43, 20);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "编码:";
            // 
            // tbxCode
            // 
            // 
            // 
            // 
            this.tbxCode.Border.Class = "TextBoxBorder";
            this.tbxCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxCode.Location = new System.Drawing.Point(81, 19);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.PreventEnterBeep = true;
            this.tbxCode.Size = new System.Drawing.Size(182, 23);
            this.tbxCode.TabIndex = 1;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Location = new System.Drawing.Point(32, 51);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(43, 20);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "名称:";
            // 
            // tbxName
            // 
            // 
            // 
            // 
            this.tbxName.Border.Class = "TextBoxBorder";
            this.tbxName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxName.Location = new System.Drawing.Point(81, 48);
            this.tbxName.Name = "tbxName";
            this.tbxName.PreventEnterBeep = true;
            this.tbxName.Size = new System.Drawing.Size(182, 23);
            this.tbxName.TabIndex = 3;
            // 
            // switchButton1
            // 
            // 
            // 
            // 
            this.switchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton1.Location = new System.Drawing.Point(81, 77);
            this.switchButton1.Name = "switchButton1";
            this.switchButton1.OffText = "否";
            this.switchButton1.OnText = "是";
            this.switchButton1.Size = new System.Drawing.Size(66, 22);
            this.switchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton1.TabIndex = 1004;
            this.switchButton1.Value = true;
            this.switchButton1.ValueObject = "Y";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(3, 77);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(72, 20);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "连续录入:";
            // 
            // FormDataElementEdit
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
            this.ClientSize = new System.Drawing.Size(296, 140);
            this.Controls.Add(this.switchButton1);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.tbxCode);
            this.Controls.Add(this.labelX1);
            this.IgnoreBtn.AutoSize = false;
            this.IgnoreBtn.Enable = true;
            this.IgnoreBtn.Text = "忽略";
            this.IgnoreBtn.Width = 64;
            this.Name = "FormDataElementEdit";
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
            this.Text = "数据源编辑";
            this.YesBtn.AutoSize = false;
            this.YesBtn.Enable = true;
            this.YesBtn.Text = "是";
            this.YesBtn.Width = 64;
            this.Shown += new System.EventHandler(this.FormDataElementEdit_Shown);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.tbxCode, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.tbxName, 0);
            this.Controls.SetChildIndex(this.switchButton1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxCode;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxName;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton1;
        private DevComponents.DotNetBar.LabelX labelX3;
    }
}