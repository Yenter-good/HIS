
namespace App_OP.ItemGroup
{
    partial class FormAddGroup
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
            this.tbxNo = new DevComponents.Editors.IntegerInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.rdo2 = new System.Windows.Forms.RadioButton();
            this.rdo1 = new System.Windows.Forms.RadioButton();
            this.tbxName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblName = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.tbxNo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxNo
            // 
            // 
            // 
            // 
            this.tbxNo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.tbxNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxNo.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.tbxNo.Location = new System.Drawing.Point(101, 41);
            this.tbxNo.Name = "tbxNo";
            this.tbxNo.ShowUpDown = true;
            this.tbxNo.Size = new System.Drawing.Size(84, 23);
            this.tbxNo.TabIndex = 16;
            this.tbxNo.WatermarkText = "请输入序号";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(22, 43);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(91, 23);
            this.labelX1.TabIndex = 15;
            this.labelX1.Text = "排    序：";
            // 
            // rdo2
            // 
            this.rdo2.AutoSize = true;
            this.rdo2.Enabled = false;
            this.rdo2.Location = new System.Drawing.Point(207, 79);
            this.rdo2.Name = "rdo2";
            this.rdo2.Size = new System.Drawing.Size(53, 18);
            this.rdo2.TabIndex = 12;
            this.rdo2.Text = "个人";
            this.rdo2.UseVisualStyleBackColor = true;
            // 
            // rdo1
            // 
            this.rdo1.AutoSize = true;
            this.rdo1.Checked = true;
            this.rdo1.Enabled = false;
            this.rdo1.Location = new System.Drawing.Point(132, 79);
            this.rdo1.Name = "rdo1";
            this.rdo1.Size = new System.Drawing.Size(53, 18);
            this.rdo1.TabIndex = 11;
            this.rdo1.TabStop = true;
            this.rdo1.Text = "科室";
            this.rdo1.UseVisualStyleBackColor = true;
            // 
            // tbxName
            // 
            // 
            // 
            // 
            this.tbxName.Border.Class = "TextBoxBorder";
            this.tbxName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxName.Location = new System.Drawing.Point(101, 12);
            this.tbxName.Name = "tbxName";
            this.tbxName.PreventEnterBeep = true;
            this.tbxName.Size = new System.Drawing.Size(208, 23);
            this.tbxName.TabIndex = 10;
            this.tbxName.WatermarkText = "请输入分组名称";
            // 
            // lblName
            // 
            // 
            // 
            // 
            this.lblName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblName.Location = new System.Drawing.Point(22, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 23);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "分组名称：";
            // 
            // FormAddGroup
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
            this.ClientSize = new System.Drawing.Size(363, 166);
            this.Controls.Add(this.tbxNo);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.rdo2);
            this.Controls.Add(this.rdo1);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.IgnoreBtn.AutoSize = false;
            this.IgnoreBtn.Enable = true;
            this.IgnoreBtn.Text = "忽略";
            this.IgnoreBtn.Width = 64;
            this.Name = "FormAddGroup";
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
            this.Text = "添加分组";
            this.YesBtn.AutoSize = false;
            this.YesBtn.Enable = true;
            this.YesBtn.Text = "是";
            this.YesBtn.Width = 64;
            this.Shown += new System.EventHandler(this.FormAddGroup_Shown);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.tbxName, 0);
            this.Controls.SetChildIndex(this.rdo1, 0);
            this.Controls.SetChildIndex(this.rdo2, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.tbxNo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tbxNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.Editors.IntegerInput tbxNo;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.RadioButton rdo2;
        private System.Windows.Forms.RadioButton rdo1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxName;
        private DevComponents.DotNetBar.LabelX lblName;
    }
}