namespace App_Sys
{
    partial class FormSystemEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSystemEdit));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.rbtnDisable = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.rbtnEnable = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ImgSystem = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.warningBox1 = new DevComponents.DotNetBar.Controls.WarningBox();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(18, 74);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(80, 25);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "系统名称";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtName.Location = new System.Drawing.Point(104, 73);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.PreventEnterBeep = true;
            this.txtName.Size = new System.Drawing.Size(242, 28);
            this.txtName.TabIndex = 0;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(18, 108);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(80, 25);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "排序";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtNo
            // 
            // 
            // 
            // 
            this.txtNo.Border.Class = "TextBoxBorder";
            this.txtNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNo.Location = new System.Drawing.Point(104, 107);
            this.txtNo.Multiline = true;
            this.txtNo.Name = "txtNo";
            this.txtNo.PreventEnterBeep = true;
            this.txtNo.Size = new System.Drawing.Size(242, 28);
            this.txtNo.TabIndex = 1;
            // 
            // rbtnDisable
            // 
            this.rbtnDisable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.rbtnDisable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbtnDisable.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.rbtnDisable.FocusCuesEnabled = false;
            this.rbtnDisable.Location = new System.Drawing.Point(210, 141);
            this.rbtnDisable.Name = "rbtnDisable";
            this.rbtnDisable.Size = new System.Drawing.Size(100, 23);
            this.rbtnDisable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbtnDisable.TabIndex = 6;
            this.rbtnDisable.Text = "停用";
            // 
            // rbtnEnable
            // 
            this.rbtnEnable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.rbtnEnable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbtnEnable.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.rbtnEnable.Checked = true;
            this.rbtnEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rbtnEnable.CheckValue = "Y";
            this.rbtnEnable.FocusCuesEnabled = false;
            this.rbtnEnable.Location = new System.Drawing.Point(104, 141);
            this.rbtnEnable.Name = "rbtnEnable";
            this.rbtnEnable.Size = new System.Drawing.Size(100, 23);
            this.rbtnEnable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbtnEnable.TabIndex = 7;
            this.rbtnEnable.Text = "启用";
            // 
            // ImgSystem
            // 
            // 
            // 
            // 
            this.ImgSystem.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ImgSystem.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.ImgSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgSystem.Image = ((System.Drawing.Image)(resources.GetObject("ImgSystem.Image")));
            this.ImgSystem.Location = new System.Drawing.Point(145, 4);
            this.ImgSystem.Name = "ImgSystem";
            this.ImgSystem.Size = new System.Drawing.Size(122, 95);
            this.ImgSystem.TabIndex = 5;
            // 
            // warningBox1
            // 
            this.warningBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.warningBox1.CloseButtonVisible = false;
            this.warningBox1.ColorScheme = DevComponents.DotNetBar.Controls.eWarningBoxColorScheme.Red;
            this.warningBox1.Image = ((System.Drawing.Image)(resources.GetObject("warningBox1.Image")));
            this.warningBox1.Location = new System.Drawing.Point(104, 175);
            this.warningBox1.Name = "warningBox1";
            this.warningBox1.OptionsButtonVisible = false;
            this.warningBox1.Size = new System.Drawing.Size(242, 41);
            this.warningBox1.TabIndex = 3;
            this.warningBox1.Text = "<b>Warning Box</b> control with <i>text-markup</i> support.";
            this.warningBox1.Visible = false;
            // 
            // FormSystemEdit
            // 
            this.AbortBtn.AutoSize = false;
            this.AbortBtn.Enable = true;
            this.AbortBtn.Text = "中止";
            this.AbortBtn.Width = 64;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.CancelBtn.AutoSize = false;
            this.CancelBtn.Enable = true;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.Width = 64;
            this.ClientSize = new System.Drawing.Size(415, 262);
            this.Controls.Add(this.rbtnDisable);
            this.Controls.Add(this.rbtnEnable);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.ImgSystem);
            this.Controls.Add(this.warningBox1);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.IgnoreBtn.AutoSize = false;
            this.IgnoreBtn.Enable = true;
            this.IgnoreBtn.Text = "忽略";
            this.IgnoreBtn.Width = 64;
            this.Name = "FormSystemEdit";
            this.NoBtn.AutoSize = false;
            this.NoBtn.Enable = true;
            this.NoBtn.Text = "否";
            this.NoBtn.Width = 64;
            this.OKBtn.AutoSize = false;
            this.OKBtn.Enable = true;
            this.OKBtn.Text = "确定";
            this.OKBtn.Width = 64;
            this.RenderFormIcon = false;
            this.RetryBtn.AutoSize = false;
            this.RetryBtn.Enable = true;
            this.RetryBtn.Text = "重试";
            this.RetryBtn.Width = 64;
            this.Text = "设置系统";
            this.TitleText = "设置系统";
            this.YesBtn.AutoSize = false;
            this.YesBtn.Enable = true;
            this.YesBtn.Text = "是";
            this.YesBtn.Width = 64;
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.txtNo, 0);
            this.Controls.SetChildIndex(this.warningBox1, 0);
            this.Controls.SetChildIndex(this.ImgSystem, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.rbtnEnable, 0);
            this.Controls.SetChildIndex(this.rbtnDisable, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNo;
        private DevComponents.DotNetBar.Controls.WarningBox warningBox1;
        private DevComponents.DotNetBar.Controls.ReflectionImage ImgSystem;
        private DevComponents.DotNetBar.Controls.CheckBoxX rbtnDisable;
        private DevComponents.DotNetBar.Controls.CheckBoxX rbtnEnable;
    }
}