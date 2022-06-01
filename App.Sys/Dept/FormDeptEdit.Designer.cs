
namespace App_Sys.Dept
{
    partial class FormDeptEdit
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
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.tbxCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbxName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tbxAliasName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cbxCategory = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tbxLocation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.swContinuousInput = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.lbContinuousInput = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.ftParentDept = new HIS.ControlLib.FilterTree();
            this.cbxCategoryDetail = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // labelX9
            // 
            this.labelX9.AutoSize = true;
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX9.Location = new System.Drawing.Point(62, 48);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(72, 20);
            this.labelX9.TabIndex = 101;
            this.labelX9.Text = "科室编码:";
            // 
            // tbxCode
            // 
            // 
            // 
            // 
            this.tbxCode.Border.Class = "TextBoxBorder";
            this.tbxCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxCode.Location = new System.Drawing.Point(140, 45);
            this.tbxCode.MaxLength = 10;
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.PreventEnterBeep = true;
            this.tbxCode.Size = new System.Drawing.Size(375, 23);
            this.tbxCode.TabIndex = 102;
            this.tbxCode.WatermarkColor = System.Drawing.Color.Gray;
            this.tbxCode.WatermarkText = "输入科室编码";
            // 
            // tbxName
            // 
            // 
            // 
            // 
            this.tbxName.Border.Class = "TextBoxBorder";
            this.tbxName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxName.Location = new System.Drawing.Point(140, 74);
            this.tbxName.MaxLength = 10;
            this.tbxName.Name = "tbxName";
            this.tbxName.PreventEnterBeep = true;
            this.tbxName.Size = new System.Drawing.Size(375, 23);
            this.tbxName.TabIndex = 102;
            this.tbxName.WatermarkColor = System.Drawing.Color.Gray;
            this.tbxName.WatermarkText = "输入科室名称";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(62, 77);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(72, 20);
            this.labelX1.TabIndex = 101;
            this.labelX1.Text = "科室名称:";
            // 
            // tbxAliasName
            // 
            // 
            // 
            // 
            this.tbxAliasName.Border.Class = "TextBoxBorder";
            this.tbxAliasName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxAliasName.Location = new System.Drawing.Point(140, 103);
            this.tbxAliasName.MaxLength = 10;
            this.tbxAliasName.Name = "tbxAliasName";
            this.tbxAliasName.PreventEnterBeep = true;
            this.tbxAliasName.Size = new System.Drawing.Size(375, 23);
            this.tbxAliasName.TabIndex = 102;
            this.tbxAliasName.WatermarkColor = System.Drawing.Color.Gray;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Location = new System.Drawing.Point(62, 106);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(72, 20);
            this.labelX2.TabIndex = 101;
            this.labelX2.Text = "科室别名:";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.Location = new System.Drawing.Point(62, 135);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(72, 20);
            this.labelX3.TabIndex = 101;
            this.labelX3.Text = "科室类型:";
            // 
            // cbxCategory
            // 
            this.cbxCategory.DisplayMember = "Text";
            this.cbxCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.ItemHeight = 18;
            this.cbxCategory.Location = new System.Drawing.Point(140, 132);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(375, 24);
            this.cbxCategory.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxCategory.TabIndex = 103;
            // 
            // tbxLocation
            // 
            // 
            // 
            // 
            this.tbxLocation.Border.Class = "TextBoxBorder";
            this.tbxLocation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxLocation.Location = new System.Drawing.Point(140, 221);
            this.tbxLocation.MaxLength = 10;
            this.tbxLocation.Multiline = true;
            this.tbxLocation.Name = "tbxLocation";
            this.tbxLocation.PreventEnterBeep = true;
            this.tbxLocation.Size = new System.Drawing.Size(375, 89);
            this.tbxLocation.TabIndex = 102;
            this.tbxLocation.WatermarkColor = System.Drawing.Color.Gray;
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX4.Location = new System.Drawing.Point(62, 224);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(72, 20);
            this.labelX4.TabIndex = 101;
            this.labelX4.Text = "科室位置:";
            // 
            // swContinuousInput
            // 
            // 
            // 
            // 
            this.swContinuousInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swContinuousInput.Location = new System.Drawing.Point(140, 316);
            this.swContinuousInput.Name = "swContinuousInput";
            this.swContinuousInput.OffText = "否";
            this.swContinuousInput.OnText = "是";
            this.swContinuousInput.Size = new System.Drawing.Size(66, 22);
            this.swContinuousInput.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swContinuousInput.TabIndex = 120;
            this.swContinuousInput.Value = true;
            this.swContinuousInput.ValueObject = "Y";
            this.swContinuousInput.Visible = false;
            // 
            // lbContinuousInput
            // 
            this.lbContinuousInput.AutoSize = true;
            this.lbContinuousInput.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbContinuousInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbContinuousInput.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbContinuousInput.Location = new System.Drawing.Point(62, 318);
            this.lbContinuousInput.Name = "lbContinuousInput";
            this.lbContinuousInput.Size = new System.Drawing.Size(72, 20);
            this.lbContinuousInput.TabIndex = 119;
            this.lbContinuousInput.Text = "连续录入:";
            this.lbContinuousInput.Visible = false;
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX5.Location = new System.Drawing.Point(62, 195);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(72, 20);
            this.labelX5.TabIndex = 101;
            this.labelX5.Text = "上级科室:";
            // 
            // ftParentDept
            // 
            this.ftParentDept.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ftParentDept.Border.Class = "TextBoxBorder";
            this.ftParentDept.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ftParentDept.DataSource = null;
            this.ftParentDept.Location = new System.Drawing.Point(140, 192);
            this.ftParentDept.Name = "ftParentDept";
            this.ftParentDept.PopupHeight = 500;
            this.ftParentDept.PreventEnterBeep = true;
            this.ftParentDept.RootId = "0";
            this.ftParentDept.ShowClearButton = true;
            this.ftParentDept.Size = new System.Drawing.Size(375, 23);
            this.ftParentDept.TabIndex = 1004;
            // 
            // cbxCategoryDetail
            // 
            this.cbxCategoryDetail.DisplayMember = "Text";
            this.cbxCategoryDetail.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxCategoryDetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoryDetail.FormattingEnabled = true;
            this.cbxCategoryDetail.ItemHeight = 18;
            this.cbxCategoryDetail.Location = new System.Drawing.Point(140, 162);
            this.cbxCategoryDetail.Name = "cbxCategoryDetail";
            this.cbxCategoryDetail.Size = new System.Drawing.Size(375, 24);
            this.cbxCategoryDetail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxCategoryDetail.TabIndex = 1006;
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX6.Location = new System.Drawing.Point(33, 166);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(101, 20);
            this.labelX6.TabIndex = 1005;
            this.labelX6.Text = "科室详细类型:";
            // 
            // FormDeptEdit
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
            this.ClientSize = new System.Drawing.Size(586, 399);
            this.Controls.Add(this.cbxCategoryDetail);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.ftParentDept);
            this.Controls.Add(this.swContinuousInput);
            this.Controls.Add(this.lbContinuousInput);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.tbxLocation);
            this.Controls.Add(this.tbxAliasName);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.tbxCode);
            this.IgnoreBtn.AutoSize = false;
            this.IgnoreBtn.Enable = true;
            this.IgnoreBtn.Text = "忽略";
            this.IgnoreBtn.Width = 64;
            this.Name = "FormDeptEdit";
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
            this.Text = "科室编辑";
            this.YesBtn.AutoSize = false;
            this.YesBtn.Enable = true;
            this.YesBtn.Text = "是";
            this.YesBtn.Width = 64;
            this.Shown += new System.EventHandler(this.FormDeptEdit_Shown);
            this.Controls.SetChildIndex(this.tbxCode, 0);
            this.Controls.SetChildIndex(this.tbxName, 0);
            this.Controls.SetChildIndex(this.tbxAliasName, 0);
            this.Controls.SetChildIndex(this.tbxLocation, 0);
            this.Controls.SetChildIndex(this.labelX9, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.labelX4, 0);
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.labelX5, 0);
            this.Controls.SetChildIndex(this.cbxCategory, 0);
            this.Controls.SetChildIndex(this.lbContinuousInput, 0);
            this.Controls.SetChildIndex(this.swContinuousInput, 0);
            this.Controls.SetChildIndex(this.ftParentDept, 0);
            this.Controls.SetChildIndex(this.labelX6, 0);
            this.Controls.SetChildIndex(this.cbxCategoryDetail, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxAliasName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxCategory;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxLocation;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.SwitchButton swContinuousInput;
        private DevComponents.DotNetBar.LabelX lbContinuousInput;
        private DevComponents.DotNetBar.LabelX labelX5;
        private HIS.ControlLib.FilterTree ftParentDept;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxCategoryDetail;
        private DevComponents.DotNetBar.LabelX labelX6;
    }
}