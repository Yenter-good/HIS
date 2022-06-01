
namespace App_OP.ChronicDisease
{
    partial class FormAddDisease
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
            this.rdo2 = new System.Windows.Forms.RadioButton();
            this.rdo1 = new System.Windows.Forms.RadioButton();
            this.tbxName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblName = new DevComponents.DotNetBar.LabelX();
            this.tbxCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // rdo2
            // 
            this.rdo2.AutoSize = true;
            this.rdo2.Location = new System.Drawing.Point(189, 107);
            this.rdo2.Name = "rdo2";
            this.rdo2.Size = new System.Drawing.Size(81, 18);
            this.rdo2.TabIndex = 20;
            this.rdo2.Text = "居民慢病";
            this.rdo2.UseVisualStyleBackColor = true;
            // 
            // rdo1
            // 
            this.rdo1.AutoSize = true;
            this.rdo1.Checked = true;
            this.rdo1.Location = new System.Drawing.Point(101, 107);
            this.rdo1.Name = "rdo1";
            this.rdo1.Size = new System.Drawing.Size(81, 18);
            this.rdo1.TabIndex = 19;
            this.rdo1.TabStop = true;
            this.rdo1.Text = "职工慢病";
            this.rdo1.UseVisualStyleBackColor = true;
            // 
            // tbxName
            // 
            // 
            // 
            // 
            this.tbxName.Border.Class = "TextBoxBorder";
            this.tbxName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxName.Location = new System.Drawing.Point(100, 66);
            this.tbxName.Name = "tbxName";
            this.tbxName.PreventEnterBeep = true;
            this.tbxName.Size = new System.Drawing.Size(208, 23);
            this.tbxName.TabIndex = 18;
            this.tbxName.WatermarkText = "请输入疾病名称";
            // 
            // lblName
            // 
            // 
            // 
            // 
            this.lblName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblName.Location = new System.Drawing.Point(5, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(106, 23);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "慢性病名称：";
            // 
            // tbxCode
            // 
            // 
            // 
            // 
            this.tbxCode.Border.Class = "TextBoxBorder";
            this.tbxCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxCode.Location = new System.Drawing.Point(100, 29);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.PreventEnterBeep = true;
            this.tbxCode.Size = new System.Drawing.Size(208, 23);
            this.tbxCode.TabIndex = 1005;
            this.tbxCode.WatermarkText = "请输入疾病名称";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(5, 29);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(106, 23);
            this.labelX1.TabIndex = 1004;
            this.labelX1.Text = "慢性病编码：";
            // 
            // FormAddDisease
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
            this.ClientSize = new System.Drawing.Size(353, 211);
            this.Controls.Add(this.tbxCode);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.rdo2);
            this.Controls.Add(this.rdo1);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.IgnoreBtn.AutoSize = false;
            this.IgnoreBtn.Enable = true;
            this.IgnoreBtn.Text = "忽略";
            this.IgnoreBtn.Width = 64;
            this.Name = "FormAddDisease";
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
            this.Text = "编辑慢性病";
            this.YesBtn.AutoSize = false;
            this.YesBtn.Enable = true;
            this.YesBtn.Text = "是";
            this.YesBtn.Width = 64;
            this.Load += new System.EventHandler(this.FormAddDisease_Load);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.tbxName, 0);
            this.Controls.SetChildIndex(this.rdo1, 0);
            this.Controls.SetChildIndex(this.rdo2, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.tbxCode, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdo2;
        private System.Windows.Forms.RadioButton rdo1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxName;
        private DevComponents.DotNetBar.LabelX lblName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxCode;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}