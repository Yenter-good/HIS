namespace App_Sys.Advice
{
    partial class FormAdviceEdit
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
            this.tbxName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.tbxSearchCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.swbYJEnable = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.swbSSEnable = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.swbZYEnable = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.swbMZEnable = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cbxModalityId = new HIS.ControlLib.Popups.FindComboBox();
            this.cbxPartId = new HIS.ControlLib.Popups.FindComboBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cbxBuretId = new HIS.ControlLib.Popups.FindComboBox();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cbxSampleId = new HIS.ControlLib.Popups.FindComboBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.cbxAdviceType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.swbContinuous = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.lblContinuous = new DevComponents.DotNetBar.LabelX();
            this.tbxCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            // 
            // 
            // 
            this.tbxName.Border.Class = "TextBoxBorder";
            this.tbxName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxName.Location = new System.Drawing.Point(117, 81);
            this.tbxName.Name = "tbxName";
            this.tbxName.PreventEnterBeep = true;
            this.tbxName.Size = new System.Drawing.Size(363, 23);
            this.tbxName.TabIndex = 10;
            this.tbxName.TextChanged += new System.EventHandler(this.tbxName_TextChanged);
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Location = new System.Drawing.Point(39, 84);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(72, 20);
            this.labelX2.TabIndex = 9;
            this.labelX2.Text = "医嘱名称:";
            // 
            // tbxSearchCode
            // 
            // 
            // 
            // 
            this.tbxSearchCode.Border.Class = "TextBoxBorder";
            this.tbxSearchCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxSearchCode.Location = new System.Drawing.Point(117, 120);
            this.tbxSearchCode.Name = "tbxSearchCode";
            this.tbxSearchCode.PreventEnterBeep = true;
            this.tbxSearchCode.Size = new System.Drawing.Size(363, 23);
            this.tbxSearchCode.TabIndex = 12;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(53, 123);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(58, 20);
            this.labelX1.TabIndex = 11;
            this.labelX1.Text = "检索码:";
            // 
            // swbYJEnable
            // 
            // 
            // 
            // 
            this.swbYJEnable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swbYJEnable.Location = new System.Drawing.Point(381, 313);
            this.swbYJEnable.Name = "swbYJEnable";
            this.swbYJEnable.OffText = "停用";
            this.swbYJEnable.OnText = "启用";
            this.swbYJEnable.Size = new System.Drawing.Size(99, 22);
            this.swbYJEnable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swbYJEnable.TabIndex = 33;
            this.swbYJEnable.Value = true;
            this.swbYJEnable.ValueObject = "Y";
            // 
            // swbSSEnable
            // 
            // 
            // 
            // 
            this.swbSSEnable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swbSSEnable.Location = new System.Drawing.Point(381, 284);
            this.swbSSEnable.Name = "swbSSEnable";
            this.swbSSEnable.OffText = "停用";
            this.swbSSEnable.OnText = "启用";
            this.swbSSEnable.Size = new System.Drawing.Size(99, 22);
            this.swbSSEnable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swbSSEnable.TabIndex = 31;
            this.swbSSEnable.Value = true;
            this.swbSSEnable.ValueObject = "Y";
            // 
            // swbZYEnable
            // 
            // 
            // 
            // 
            this.swbZYEnable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swbZYEnable.Location = new System.Drawing.Point(150, 311);
            this.swbZYEnable.Name = "swbZYEnable";
            this.swbZYEnable.OffText = "停用";
            this.swbZYEnable.OnText = "启用";
            this.swbZYEnable.Size = new System.Drawing.Size(99, 22);
            this.swbZYEnable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swbZYEnable.TabIndex = 29;
            this.swbZYEnable.Value = true;
            this.swbZYEnable.ValueObject = "Y";
            // 
            // swbMZEnable
            // 
            // 
            // 
            // 
            this.swbMZEnable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swbMZEnable.Location = new System.Drawing.Point(150, 284);
            this.swbMZEnable.Name = "swbMZEnable";
            this.swbMZEnable.OffText = "停用";
            this.swbMZEnable.OnText = "启用";
            this.swbMZEnable.Size = new System.Drawing.Size(99, 22);
            this.swbMZEnable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swbMZEnable.TabIndex = 27;
            this.swbMZEnable.Value = true;
            this.swbMZEnable.ValueObject = "Y";
            // 
            // labelX10
            // 
            this.labelX10.AutoSize = true;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX10.Location = new System.Drawing.Point(274, 313);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(101, 20);
            this.labelX10.TabIndex = 32;
            this.labelX10.Text = "医技启用标识:";
            // 
            // labelX9
            // 
            this.labelX9.AutoSize = true;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX9.Location = new System.Drawing.Point(274, 286);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(101, 20);
            this.labelX9.TabIndex = 30;
            this.labelX9.Text = "手术启用标识:";
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX8.Location = new System.Drawing.Point(43, 313);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(101, 20);
            this.labelX8.TabIndex = 28;
            this.labelX8.Text = "住院启用标识:";
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX7.Location = new System.Drawing.Point(43, 286);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(101, 20);
            this.labelX7.TabIndex = 26;
            this.labelX7.Text = "门诊启用标识:";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.Location = new System.Drawing.Point(32, 199);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(72, 20);
            this.labelX3.TabIndex = 35;
            this.labelX3.Text = "设备类型:";
            // 
            // cbxModalityId
            // 
            this.cbxModalityId.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.cbxModalityId.Border.Class = "TextBoxBorder";
            this.cbxModalityId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxModalityId.CanResizePopup = false;
            this.cbxModalityId.ColumnHeaders = null;
            this.cbxModalityId.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxModalityId.DataSource = null;
            this.cbxModalityId.DisplayMember = "";
            this.cbxModalityId.FilterFields = null;
            this.cbxModalityId.FocusOpen = false;
            this.cbxModalityId.Location = new System.Drawing.Point(110, 196);
            this.cbxModalityId.Name = "cbxModalityId";
            this.cbxModalityId.PopupBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(225)))));
            this.cbxModalityId.PopupBorderWidth = new System.Windows.Forms.Padding(1);
            this.cbxModalityId.PopupMaximumSize = new System.Drawing.Size(0, 450);
            this.cbxModalityId.PopupMinimumSize = new System.Drawing.Size(0, 25);
            this.cbxModalityId.PopupOffSet = 2;
            this.cbxModalityId.PreventEnterBeep = true;
            this.cbxModalityId.ReadOnly = true;
            this.cbxModalityId.SelectedItem = null;
            this.cbxModalityId.SelectedValue = null;
            this.cbxModalityId.ShowClearButton = true;
            this.cbxModalityId.ShowPopupShadow = true;
            this.cbxModalityId.Size = new System.Drawing.Size(139, 23);
            this.cbxModalityId.SupportPinyinSearch = false;
            this.cbxModalityId.SupportWubiSearch = false;
            this.cbxModalityId.TabIndex = 36;
            this.cbxModalityId.ValueMember = null;
            // 
            // cbxPartId
            // 
            this.cbxPartId.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.cbxPartId.Border.Class = "TextBoxBorder";
            this.cbxPartId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxPartId.CanResizePopup = false;
            this.cbxPartId.ColumnHeaders = null;
            this.cbxPartId.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxPartId.DataSource = null;
            this.cbxPartId.DisplayMember = "";
            this.cbxPartId.FilterFields = null;
            this.cbxPartId.FocusOpen = false;
            this.cbxPartId.Location = new System.Drawing.Point(341, 196);
            this.cbxPartId.Name = "cbxPartId";
            this.cbxPartId.PopupBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(225)))));
            this.cbxPartId.PopupBorderWidth = new System.Windows.Forms.Padding(1);
            this.cbxPartId.PopupMaximumSize = new System.Drawing.Size(0, 450);
            this.cbxPartId.PopupMinimumSize = new System.Drawing.Size(0, 25);
            this.cbxPartId.PopupOffSet = 2;
            this.cbxPartId.PreventEnterBeep = true;
            this.cbxPartId.ReadOnly = true;
            this.cbxPartId.SelectedItem = null;
            this.cbxPartId.SelectedValue = null;
            this.cbxPartId.ShowClearButton = true;
            this.cbxPartId.ShowPopupShadow = true;
            this.cbxPartId.Size = new System.Drawing.Size(139, 23);
            this.cbxPartId.SupportPinyinSearch = false;
            this.cbxPartId.SupportWubiSearch = false;
            this.cbxPartId.TabIndex = 38;
            this.cbxPartId.ValueMember = null;
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX4.Location = new System.Drawing.Point(263, 199);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(72, 20);
            this.labelX4.TabIndex = 37;
            this.labelX4.Text = "检查部位:";
            // 
            // cbxBuretId
            // 
            this.cbxBuretId.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.cbxBuretId.Border.Class = "TextBoxBorder";
            this.cbxBuretId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxBuretId.CanResizePopup = false;
            this.cbxBuretId.ColumnHeaders = null;
            this.cbxBuretId.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxBuretId.DataSource = null;
            this.cbxBuretId.DisplayMember = "";
            this.cbxBuretId.FilterFields = null;
            this.cbxBuretId.FocusOpen = false;
            this.cbxBuretId.Location = new System.Drawing.Point(341, 237);
            this.cbxBuretId.Name = "cbxBuretId";
            this.cbxBuretId.PopupBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(225)))));
            this.cbxBuretId.PopupBorderWidth = new System.Windows.Forms.Padding(1);
            this.cbxBuretId.PopupMaximumSize = new System.Drawing.Size(0, 450);
            this.cbxBuretId.PopupMinimumSize = new System.Drawing.Size(0, 25);
            this.cbxBuretId.PopupOffSet = 2;
            this.cbxBuretId.PreventEnterBeep = true;
            this.cbxBuretId.ReadOnly = true;
            this.cbxBuretId.SelectedItem = null;
            this.cbxBuretId.SelectedValue = null;
            this.cbxBuretId.ShowClearButton = true;
            this.cbxBuretId.ShowPopupShadow = true;
            this.cbxBuretId.Size = new System.Drawing.Size(139, 23);
            this.cbxBuretId.SupportPinyinSearch = false;
            this.cbxBuretId.SupportWubiSearch = false;
            this.cbxBuretId.TabIndex = 42;
            this.cbxBuretId.ValueMember = null;
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX5.Location = new System.Drawing.Point(263, 240);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(72, 20);
            this.labelX5.TabIndex = 41;
            this.labelX5.Text = "试管类型:";
            // 
            // cbxSampleId
            // 
            this.cbxSampleId.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.cbxSampleId.Border.Class = "TextBoxBorder";
            this.cbxSampleId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxSampleId.CanResizePopup = false;
            this.cbxSampleId.ColumnHeaders = null;
            this.cbxSampleId.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxSampleId.DataSource = null;
            this.cbxSampleId.DisplayMember = "";
            this.cbxSampleId.FilterFields = null;
            this.cbxSampleId.FocusOpen = false;
            this.cbxSampleId.Location = new System.Drawing.Point(110, 237);
            this.cbxSampleId.Name = "cbxSampleId";
            this.cbxSampleId.PopupBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(225)))));
            this.cbxSampleId.PopupBorderWidth = new System.Windows.Forms.Padding(1);
            this.cbxSampleId.PopupMaximumSize = new System.Drawing.Size(0, 450);
            this.cbxSampleId.PopupMinimumSize = new System.Drawing.Size(0, 25);
            this.cbxSampleId.PopupOffSet = 2;
            this.cbxSampleId.PreventEnterBeep = true;
            this.cbxSampleId.ReadOnly = true;
            this.cbxSampleId.SelectedItem = null;
            this.cbxSampleId.SelectedValue = null;
            this.cbxSampleId.ShowClearButton = true;
            this.cbxSampleId.ShowPopupShadow = true;
            this.cbxSampleId.Size = new System.Drawing.Size(139, 23);
            this.cbxSampleId.SupportPinyinSearch = false;
            this.cbxSampleId.SupportWubiSearch = false;
            this.cbxSampleId.TabIndex = 40;
            this.cbxSampleId.ValueMember = null;
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX6.Location = new System.Drawing.Point(32, 240);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(72, 20);
            this.labelX6.TabIndex = 39;
            this.labelX6.Text = "标本类型:";
            // 
            // labelX11
            // 
            this.labelX11.AutoSize = true;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX11.Location = new System.Drawing.Point(39, 161);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(72, 20);
            this.labelX11.TabIndex = 43;
            this.labelX11.Text = "医嘱类型:";
            // 
            // cbxAdviceType
            // 
            this.cbxAdviceType.DisplayMember = "Text";
            this.cbxAdviceType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxAdviceType.FormattingEnabled = true;
            this.cbxAdviceType.ItemHeight = 18;
            this.cbxAdviceType.Location = new System.Drawing.Point(118, 161);
            this.cbxAdviceType.Name = "cbxAdviceType";
            this.cbxAdviceType.Size = new System.Drawing.Size(362, 24);
            this.cbxAdviceType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxAdviceType.TabIndex = 44;
            // 
            // swbContinuous
            // 
            // 
            // 
            // 
            this.swbContinuous.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swbContinuous.Location = new System.Drawing.Point(136, 358);
            this.swbContinuous.Name = "swbContinuous";
            this.swbContinuous.OffText = "关闭";
            this.swbContinuous.OnText = "开启";
            this.swbContinuous.Size = new System.Drawing.Size(99, 22);
            this.swbContinuous.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swbContinuous.TabIndex = 46;
            // 
            // lblContinuous
            // 
            this.lblContinuous.AutoSize = true;
            // 
            // 
            // 
            this.lblContinuous.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblContinuous.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblContinuous.Location = new System.Drawing.Point(58, 358);
            this.lblContinuous.Name = "lblContinuous";
            this.lblContinuous.Size = new System.Drawing.Size(72, 20);
            this.lblContinuous.TabIndex = 45;
            this.lblContinuous.Text = "连续添加:";
            // 
            // tbxCode
            // 
            // 
            // 
            // 
            this.tbxCode.Border.Class = "TextBoxBorder";
            this.tbxCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxCode.Location = new System.Drawing.Point(117, 35);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.PreventEnterBeep = true;
            this.tbxCode.Size = new System.Drawing.Size(363, 23);
            this.tbxCode.TabIndex = 1005;
            // 
            // labelX12
            // 
            this.labelX12.AutoSize = true;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX12.Location = new System.Drawing.Point(39, 38);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(72, 20);
            this.labelX12.TabIndex = 1004;
            this.labelX12.Text = "医嘱编号:";
            // 
            // FormAdviceEdit
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
            this.ClientSize = new System.Drawing.Size(563, 449);
            this.Controls.Add(this.tbxCode);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.swbContinuous);
            this.Controls.Add(this.lblContinuous);
            this.Controls.Add(this.cbxAdviceType);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.cbxBuretId);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.cbxSampleId);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.cbxPartId);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.cbxModalityId);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.swbYJEnable);
            this.Controls.Add(this.swbSSEnable);
            this.Controls.Add(this.swbZYEnable);
            this.Controls.Add(this.swbMZEnable);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.tbxSearchCode);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.labelX2);
            this.IgnoreBtn.AutoSize = false;
            this.IgnoreBtn.Enable = true;
            this.IgnoreBtn.Text = "忽略";
            this.IgnoreBtn.Width = 64;
            this.Name = "FormAdviceEdit";
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
            this.Text = "医嘱定义";
            this.YesBtn.AutoSize = false;
            this.YesBtn.Enable = true;
            this.YesBtn.Text = "是";
            this.YesBtn.Width = 64;
            this.Load += new System.EventHandler(this.FormAdviceEdit_Load);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.tbxName, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.tbxSearchCode, 0);
            this.Controls.SetChildIndex(this.labelX7, 0);
            this.Controls.SetChildIndex(this.labelX8, 0);
            this.Controls.SetChildIndex(this.labelX9, 0);
            this.Controls.SetChildIndex(this.labelX10, 0);
            this.Controls.SetChildIndex(this.swbMZEnable, 0);
            this.Controls.SetChildIndex(this.swbZYEnable, 0);
            this.Controls.SetChildIndex(this.swbSSEnable, 0);
            this.Controls.SetChildIndex(this.swbYJEnable, 0);
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.cbxModalityId, 0);
            this.Controls.SetChildIndex(this.labelX4, 0);
            this.Controls.SetChildIndex(this.cbxPartId, 0);
            this.Controls.SetChildIndex(this.labelX6, 0);
            this.Controls.SetChildIndex(this.cbxSampleId, 0);
            this.Controls.SetChildIndex(this.labelX5, 0);
            this.Controls.SetChildIndex(this.cbxBuretId, 0);
            this.Controls.SetChildIndex(this.labelX11, 0);
            this.Controls.SetChildIndex(this.cbxAdviceType, 0);
            this.Controls.SetChildIndex(this.lblContinuous, 0);
            this.Controls.SetChildIndex(this.swbContinuous, 0);
            this.Controls.SetChildIndex(this.labelX12, 0);
            this.Controls.SetChildIndex(this.tbxCode, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX tbxName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxSearchCode;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.SwitchButton swbYJEnable;
        private DevComponents.DotNetBar.Controls.SwitchButton swbSSEnable;
        private DevComponents.DotNetBar.Controls.SwitchButton swbZYEnable;
        private DevComponents.DotNetBar.Controls.SwitchButton swbMZEnable;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX3;
        private HIS.ControlLib.Popups.FindComboBox cbxModalityId;
        private HIS.ControlLib.Popups.FindComboBox cbxPartId;
        private DevComponents.DotNetBar.LabelX labelX4;
        private HIS.ControlLib.Popups.FindComboBox cbxBuretId;
        private DevComponents.DotNetBar.LabelX labelX5;
        private HIS.ControlLib.Popups.FindComboBox cbxSampleId;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxAdviceType;
        private DevComponents.DotNetBar.Controls.SwitchButton swbContinuous;
        private DevComponents.DotNetBar.LabelX lblContinuous;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxCode;
        private DevComponents.DotNetBar.LabelX labelX12;
    }
}