namespace ConfigurationTool
{
    partial class FormAddParameter
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
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtValue = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnJieMi = new DevComponents.DotNetBar.ButtonX();
            this.btnJiaMi = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(13, 56);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(140, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "参数值：";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(13, 27);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(140, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "参数名：";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(159, 27);
            this.txtName.Name = "txtName";
            this.txtName.PreventEnterBeep = true;
            this.txtName.Size = new System.Drawing.Size(246, 23);
            this.txtName.TabIndex = 1;
            // 
            // txtValue
            // 
            // 
            // 
            // 
            this.txtValue.Border.Class = "TextBoxBorder";
            this.txtValue.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtValue.Location = new System.Drawing.Point(159, 59);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.PreventEnterBeep = true;
            this.txtValue.Size = new System.Drawing.Size(246, 80);
            this.txtValue.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(159, 168);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "确定";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(253, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            // 
            // btnJieMi
            // 
            this.btnJieMi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnJieMi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnJieMi.Location = new System.Drawing.Point(421, 59);
            this.btnJieMi.Name = "btnJieMi";
            this.btnJieMi.Size = new System.Drawing.Size(75, 23);
            this.btnJieMi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnJieMi.TabIndex = 7;
            this.btnJieMi.Text = "解密";
            this.btnJieMi.Click += new System.EventHandler(this.btnJieMi_Click);
            // 
            // btnJiaMi
            // 
            this.btnJiaMi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnJiaMi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnJiaMi.Location = new System.Drawing.Point(421, 87);
            this.btnJiaMi.Name = "btnJiaMi";
            this.btnJiaMi.Size = new System.Drawing.Size(75, 23);
            this.btnJiaMi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnJiaMi.TabIndex = 7;
            this.btnJiaMi.Text = "加密";
            this.btnJiaMi.Click += new System.EventHandler(this.btnJiaMi_Click);
            // 
            // FormAddParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 205);
            this.Controls.Add(this.btnJiaMi);
            this.Controls.Add(this.btnJieMi);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX3);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FormAddParameter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "参数编辑";
            this.Load += new System.EventHandler(this.FormAddParameter_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtValue;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnJieMi;
        private DevComponents.DotNetBar.ButtonX btnJiaMi;
    }
}