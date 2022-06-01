namespace App_Sys
{
    partial class FormSerialNumberEdit
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
            this.cbxType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.intTotalLen = new DevComponents.Editors.IntegerInput();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.tbxStartPrefix = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cbxMiddleFormat = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.cbxChangeType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.swbCacheFlag = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.intTotalLen)).BeginInit();
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
            this.labelX1.Location = new System.Drawing.Point(132, 43);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(43, 20);
            this.labelX1.TabIndex = 1004;
            this.labelX1.Text = "类型:";
            // 
            // cbxType
            // 
            this.cbxType.DisplayMember = "Text";
            this.cbxType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.ItemHeight = 18;
            this.cbxType.Location = new System.Drawing.Point(181, 40);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(256, 24);
            this.cbxType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxType.TabIndex = 1005;
            // 
            // intTotalLen
            // 
            // 
            // 
            // 
            this.intTotalLen.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intTotalLen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intTotalLen.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intTotalLen.Location = new System.Drawing.Point(181, 71);
            this.intTotalLen.MaxValue = 20;
            this.intTotalLen.Name = "intTotalLen";
            this.intTotalLen.ShowUpDown = true;
            this.intTotalLen.Size = new System.Drawing.Size(96, 23);
            this.intTotalLen.TabIndex = 1006;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(277, 75);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(36, 20);
            this.labelX3.TabIndex = 1004;
            this.labelX3.Text = "(位)";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(103, 103);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(72, 20);
            this.labelX4.TabIndex = 1004;
            this.labelX4.Text = "开始字符:";
            // 
            // tbxStartPrefix
            // 
            // 
            // 
            // 
            this.tbxStartPrefix.Border.Class = "TextBoxBorder";
            this.tbxStartPrefix.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxStartPrefix.Location = new System.Drawing.Point(181, 100);
            this.tbxStartPrefix.Name = "tbxStartPrefix";
            this.tbxStartPrefix.PreventEnterBeep = true;
            this.tbxStartPrefix.Size = new System.Drawing.Size(256, 23);
            this.tbxStartPrefix.TabIndex = 1007;
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX5.Location = new System.Drawing.Point(103, 132);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(72, 20);
            this.labelX5.TabIndex = 1004;
            this.labelX5.Text = "中间格式:";
            // 
            // cbxMiddleFormat
            // 
            this.cbxMiddleFormat.DisplayMember = "Text";
            this.cbxMiddleFormat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxMiddleFormat.FormattingEnabled = true;
            this.cbxMiddleFormat.ItemHeight = 18;
            this.cbxMiddleFormat.Location = new System.Drawing.Point(181, 129);
            this.cbxMiddleFormat.Name = "cbxMiddleFormat";
            this.cbxMiddleFormat.Size = new System.Drawing.Size(256, 24);
            this.cbxMiddleFormat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxMiddleFormat.TabIndex = 1008;
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX6.Location = new System.Drawing.Point(103, 161);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(72, 20);
            this.labelX6.TabIndex = 1004;
            this.labelX6.Text = "变化类型:";
            // 
            // cbxChangeType
            // 
            this.cbxChangeType.DisplayMember = "Text";
            this.cbxChangeType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxChangeType.FormattingEnabled = true;
            this.cbxChangeType.ItemHeight = 18;
            this.cbxChangeType.Location = new System.Drawing.Point(181, 158);
            this.cbxChangeType.Name = "cbxChangeType";
            this.cbxChangeType.Size = new System.Drawing.Size(256, 24);
            this.cbxChangeType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxChangeType.TabIndex = 1008;
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX7.Location = new System.Drawing.Point(103, 188);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(72, 20);
            this.labelX7.TabIndex = 1004;
            this.labelX7.Text = "是否缓存:";
            // 
            // swbCacheFlag
            // 
            // 
            // 
            // 
            this.swbCacheFlag.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swbCacheFlag.Location = new System.Drawing.Point(181, 188);
            this.swbCacheFlag.Name = "swbCacheFlag";
            this.swbCacheFlag.OffText = "否";
            this.swbCacheFlag.OnText = "是";
            this.swbCacheFlag.Size = new System.Drawing.Size(66, 22);
            this.swbCacheFlag.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swbCacheFlag.TabIndex = 1009;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Location = new System.Drawing.Point(117, 75);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(58, 20);
            this.labelX2.TabIndex = 1004;
            this.labelX2.Text = "总长度:";
            // 
            // FormSerialNumberEdit
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
            this.ClientSize = new System.Drawing.Size(557, 263);
            this.Controls.Add(this.swbCacheFlag);
            this.Controls.Add(this.cbxChangeType);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.cbxMiddleFormat);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.tbxStartPrefix);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.intTotalLen);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.labelX1);
            this.IgnoreBtn.AutoSize = false;
            this.IgnoreBtn.Enable = true;
            this.IgnoreBtn.Text = "忽略";
            this.IgnoreBtn.Width = 64;
            this.Name = "FormSerialNumberEdit";
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
            this.Text = "流水号编辑";
            this.YesBtn.AutoSize = false;
            this.YesBtn.Enable = true;
            this.YesBtn.Text = "是";
            this.YesBtn.Width = 64;
            this.Shown += new System.EventHandler(this.FormSerialNumberEdit_Shown);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.cbxType, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.labelX4, 0);
            this.Controls.SetChildIndex(this.intTotalLen, 0);
            this.Controls.SetChildIndex(this.labelX5, 0);
            this.Controls.SetChildIndex(this.tbxStartPrefix, 0);
            this.Controls.SetChildIndex(this.labelX6, 0);
            this.Controls.SetChildIndex(this.cbxMiddleFormat, 0);
            this.Controls.SetChildIndex(this.labelX7, 0);
            this.Controls.SetChildIndex(this.cbxChangeType, 0);
            this.Controls.SetChildIndex(this.swbCacheFlag, 0);
            ((System.ComponentModel.ISupportInitialize)(this.intTotalLen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxType;
        private DevComponents.Editors.IntegerInput intTotalLen;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxStartPrefix;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxMiddleFormat;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxChangeType;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.SwitchButton swbCacheFlag;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}