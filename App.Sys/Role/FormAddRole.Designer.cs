namespace App_Sys.RoleManager
{
    partial class FormAddRole
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
            this.tbxCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbxName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbxDescription = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.intLevel = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.intLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxCode
            // 
            // 
            // 
            // 
            this.tbxCode.Border.Class = "TextBoxBorder";
            this.tbxCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxCode.Location = new System.Drawing.Point(158, 20);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.PreventEnterBeep = true;
            this.tbxCode.Size = new System.Drawing.Size(232, 23);
            this.tbxCode.TabIndex = 0;
            this.tbxCode.WatermarkText = "角色代码";
            // 
            // tbxName
            // 
            // 
            // 
            // 
            this.tbxName.Border.Class = "TextBoxBorder";
            this.tbxName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxName.Location = new System.Drawing.Point(158, 60);
            this.tbxName.Name = "tbxName";
            this.tbxName.PreventEnterBeep = true;
            this.tbxName.Size = new System.Drawing.Size(232, 23);
            this.tbxName.TabIndex = 1;
            this.tbxName.WatermarkText = "角色名称";
            // 
            // tbxDescription
            // 
            // 
            // 
            // 
            this.tbxDescription.Border.Class = "TextBoxBorder";
            this.tbxDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxDescription.Location = new System.Drawing.Point(158, 100);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.PreventEnterBeep = true;
            this.tbxDescription.Size = new System.Drawing.Size(232, 23);
            this.tbxDescription.TabIndex = 2;
            this.tbxDescription.WatermarkText = "角色描述";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(23, 17);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(116, 23);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "角色代码：";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(23, 57);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(116, 23);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "角色名称：";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(23, 97);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(116, 23);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "描    述：";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(23, 137);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(116, 23);
            this.labelX4.TabIndex = 9;
            this.labelX4.Text = "等    级：";
            // 
            // intLevel
            // 
            this.intLevel.Location = new System.Drawing.Point(158, 140);
            this.intLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intLevel.Name = "intLevel";
            this.intLevel.Size = new System.Drawing.Size(232, 23);
            this.intLevel.TabIndex = 10;
            this.intLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormAddRole
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
            this.ClientSize = new System.Drawing.Size(419, 225);
            this.Controls.Add(this.intLevel);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.tbxCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IgnoreBtn.AutoSize = false;
            this.IgnoreBtn.Enable = true;
            this.IgnoreBtn.Text = "忽略";
            this.IgnoreBtn.Width = 64;
            this.Name = "FormAddRole";
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
            this.Text = "角色管理";
            this.YesBtn.AutoSize = false;
            this.YesBtn.Enable = true;
            this.YesBtn.Text = "是";
            this.YesBtn.Width = 64;
            this.Load += new System.EventHandler(this.FormAddRole_Load);
            this.Controls.SetChildIndex(this.tbxCode, 0);
            this.Controls.SetChildIndex(this.tbxName, 0);
            this.Controls.SetChildIndex(this.tbxDescription, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.labelX4, 0);
            this.Controls.SetChildIndex(this.intLevel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.intLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX tbxCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxDescription;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.NumericUpDown intLevel;
    }
}