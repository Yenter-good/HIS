
namespace App_Sys.Dic
{
    partial class FormAdviceCategoryEdit
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
            this.tbxName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.ftDept = new HIS.ControlLib.FilterTree();
            this.ftParentCategory = new HIS.ControlLib.FilterTree();
            this.swContinuousInput = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.lbContinuousInput = new DevComponents.DotNetBar.LabelX();
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
            this.labelX9.Location = new System.Drawing.Point(67, 49);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(72, 20);
            this.labelX9.TabIndex = 1004;
            this.labelX9.Text = "分类名称:";
            // 
            // tbxName
            // 
            // 
            // 
            // 
            this.tbxName.Border.Class = "TextBoxBorder";
            this.tbxName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxName.Location = new System.Drawing.Point(145, 46);
            this.tbxName.MaxLength = 10;
            this.tbxName.Name = "tbxName";
            this.tbxName.PreventEnterBeep = true;
            this.tbxName.Size = new System.Drawing.Size(375, 23);
            this.tbxName.TabIndex = 1005;
            this.tbxName.WatermarkColor = System.Drawing.Color.Gray;
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
            this.labelX1.Location = new System.Drawing.Point(67, 78);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(72, 20);
            this.labelX1.TabIndex = 1006;
            this.labelX1.Text = "上级分类:";
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
            this.labelX2.Location = new System.Drawing.Point(67, 107);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(65, 20);
            this.labelX2.TabIndex = 1006;
            this.labelX2.Text = "所属科室";
            // 
            // ftDept
            // 
            this.ftDept.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ftDept.Border.Class = "TextBoxBorder";
            this.ftDept.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ftDept.DataSource = null;
            this.ftDept.Location = new System.Drawing.Point(145, 104);
            this.ftDept.Name = "ftDept";
            this.ftDept.PopupHeight = 300;
            this.ftDept.PreventEnterBeep = true;
            this.ftDept.RootId = "0";
            this.ftDept.Size = new System.Drawing.Size(375, 23);
            this.ftDept.TabIndex = 1008;
            // 
            // ftParentCategory
            // 
            this.ftParentCategory.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ftParentCategory.Border.Class = "TextBoxBorder";
            this.ftParentCategory.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ftParentCategory.DataSource = null;
            this.ftParentCategory.Location = new System.Drawing.Point(145, 75);
            this.ftParentCategory.Name = "ftParentCategory";
            this.ftParentCategory.PopupHeight = 300;
            this.ftParentCategory.PreventEnterBeep = true;
            this.ftParentCategory.RootId = "0";
            this.ftParentCategory.Size = new System.Drawing.Size(375, 23);
            this.ftParentCategory.TabIndex = 1008;
            // 
            // swContinuousInput
            // 
            // 
            // 
            // 
            this.swContinuousInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swContinuousInput.Location = new System.Drawing.Point(145, 133);
            this.swContinuousInput.Name = "swContinuousInput";
            this.swContinuousInput.OffText = "否";
            this.swContinuousInput.OnText = "是";
            this.swContinuousInput.Size = new System.Drawing.Size(66, 22);
            this.swContinuousInput.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swContinuousInput.TabIndex = 1010;
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
            this.lbContinuousInput.Location = new System.Drawing.Point(67, 135);
            this.lbContinuousInput.Name = "lbContinuousInput";
            this.lbContinuousInput.Size = new System.Drawing.Size(72, 20);
            this.lbContinuousInput.TabIndex = 1009;
            this.lbContinuousInput.Text = "连续录入:";
            this.lbContinuousInput.Visible = false;
            // 
            // FormAdviceCategoryEdit
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
            this.ClientSize = new System.Drawing.Size(586, 239);
            this.Controls.Add(this.swContinuousInput);
            this.Controls.Add(this.lbContinuousInput);
            this.Controls.Add(this.ftParentCategory);
            this.Controls.Add(this.ftDept);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.tbxName);
            this.IgnoreBtn.AutoSize = false;
            this.IgnoreBtn.Enable = true;
            this.IgnoreBtn.Text = "忽略";
            this.IgnoreBtn.Width = 64;
            this.Name = "FormAdviceCategoryEdit";
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
            this.Text = "归类编辑";
            this.YesBtn.AutoSize = false;
            this.YesBtn.Enable = true;
            this.YesBtn.Text = "是";
            this.YesBtn.Width = 64;
            this.Shown += new System.EventHandler(this.FormAdviceCategoryEdit_Shown);
            this.Controls.SetChildIndex(this.tbxName, 0);
            this.Controls.SetChildIndex(this.labelX9, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.ftDept, 0);
            this.Controls.SetChildIndex(this.ftParentCategory, 0);
            this.Controls.SetChildIndex(this.lbContinuousInput, 0);
            this.Controls.SetChildIndex(this.swContinuousInput, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private HIS.ControlLib.FilterTree ftDept;
        private HIS.ControlLib.FilterTree ftParentCategory;
        private DevComponents.DotNetBar.Controls.SwitchButton swContinuousInput;
        private DevComponents.DotNetBar.LabelX lbContinuousInput;
    }
}