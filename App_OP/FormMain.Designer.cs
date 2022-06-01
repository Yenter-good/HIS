
namespace App_OP
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabMain = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabMedicalRecordButton = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.ucTestApply = new App_OP.MedicalTechnology.UCMedicalTechnologyApply();
            this.tabTest = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.ucInspectApply = new App_OP.MedicalTechnology.UCMedicalTechnologyApply();
            this.tabInspect = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.ucEditPrescription1 = new App_OP.Prescription.UCEditPrescription();
            this.tabPrescription = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel5 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabReport = new DevComponents.DotNetBar.SuperTabItem();
            this.pnlPatientInfo = new DevComponents.DotNetBar.PanelEx();
            this.tbxCategory = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbxPayType = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbxGender = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbxAge = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbxOutpatientNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbxName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.btnJournal = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.pnlFunctionArea = new System.Windows.Forms.Panel();
            this.ucPrescription1 = new App_OP.Prescription.UCPrescription();
            this.expandableSplitter2 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.ucPatientDiagnosis1 = new App_OP.Prescription.UCPatientDiagnosis();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlPrescription = new System.Windows.Forms.Panel();
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.pnlMedicalRecord = new System.Windows.Forms.Panel();
            this.ucRecord = new App_OP.MedicalRecord.UCRecord();
            this.tabMainMedicalRecord = new DevComponents.DotNetBar.SuperTabStrip();
            this.tabMedicalRecord = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabItem3 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabItem4 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabItem5 = new DevComponents.DotNetBar.SuperTabItem();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.superTabControlPanel3.SuspendLayout();
            this.superTabControlPanel4.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.pnlPatientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlFunctionArea.SuspendLayout();
            this.pnlPrescription.SuspendLayout();
            this.pnlMedicalRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMainMedicalRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tabMain.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.tabMain.ControlBox.MenuBox.Name = "";
            this.tabMain.ControlBox.Name = "";
            this.tabMain.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabMain.ControlBox.MenuBox,
            this.tabMain.ControlBox.CloseBox});
            this.tabMain.Controls.Add(this.superTabControlPanel1);
            this.tabMain.Controls.Add(this.superTabControlPanel3);
            this.tabMain.Controls.Add(this.superTabControlPanel4);
            this.tabMain.Controls.Add(this.superTabControlPanel2);
            this.tabMain.Controls.Add(this.superTabControlPanel5);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 160);
            this.tabMain.Name = "tabMain";
            this.tabMain.ReorderTabsEnabled = true;
            this.tabMain.SelectedTabFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.tabMain.SelectedTabIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(852, 491);
            this.tabMain.TabFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabMain.TabIndex = 6;
            this.tabMain.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabMedicalRecordButton,
            this.tabPrescription,
            this.tabTest,
            this.tabInspect,
            this.tabReport});
            this.tabMain.Text = "superTabControl1";
            this.tabMain.SelectedTabChanged += new System.EventHandler<DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs>(this.tabMain_SelectedTabChanged);
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 46);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(852, 445);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.tabMedicalRecordButton;
            // 
            // tabMedicalRecordButton
            // 
            this.tabMedicalRecordButton.AttachedControl = this.superTabControlPanel1;
            this.tabMedicalRecordButton.GlobalItem = false;
            this.tabMedicalRecordButton.Image = ((System.Drawing.Image)(resources.GetObject("tabMedicalRecordButton.Image")));
            this.tabMedicalRecordButton.Name = "tabMedicalRecordButton";
            this.tabMedicalRecordButton.Text = "病历";
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.Controls.Add(this.ucTestApply);
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Location = new System.Drawing.Point(0, 46);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(852, 445);
            this.superTabControlPanel3.TabIndex = 0;
            this.superTabControlPanel3.TabItem = this.tabTest;
            // 
            // ucTestApply
            // 
            this.ucTestApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTestApply.Editor = App_OP.MedicalTechnology.MedicalTechnologyEditor.检验;
            this.ucTestApply.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucTestApply.FunctionAreaHeight = 250;
            this.ucTestApply.Location = new System.Drawing.Point(0, 0);
            this.ucTestApply.Name = "ucTestApply";
            this.ucTestApply.Size = new System.Drawing.Size(852, 445);
            this.ucTestApply.TabIndex = 0;
            // 
            // tabTest
            // 
            this.tabTest.AttachedControl = this.superTabControlPanel3;
            this.tabTest.GlobalItem = false;
            this.tabTest.Image = ((System.Drawing.Image)(resources.GetObject("tabTest.Image")));
            this.tabTest.Name = "tabTest";
            this.tabTest.Text = "检验";
            // 
            // superTabControlPanel4
            // 
            this.superTabControlPanel4.Controls.Add(this.ucInspectApply);
            this.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel4.Location = new System.Drawing.Point(0, 46);
            this.superTabControlPanel4.Name = "superTabControlPanel4";
            this.superTabControlPanel4.Size = new System.Drawing.Size(852, 445);
            this.superTabControlPanel4.TabIndex = 0;
            this.superTabControlPanel4.TabItem = this.tabInspect;
            // 
            // ucInspectApply
            // 
            this.ucInspectApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInspectApply.Editor = App_OP.MedicalTechnology.MedicalTechnologyEditor.检查;
            this.ucInspectApply.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucInspectApply.FunctionAreaHeight = 250;
            this.ucInspectApply.Location = new System.Drawing.Point(0, 0);
            this.ucInspectApply.Name = "ucInspectApply";
            this.ucInspectApply.Size = new System.Drawing.Size(852, 445);
            this.ucInspectApply.TabIndex = 1;
            // 
            // tabInspect
            // 
            this.tabInspect.AttachedControl = this.superTabControlPanel4;
            this.tabInspect.GlobalItem = false;
            this.tabInspect.Image = ((System.Drawing.Image)(resources.GetObject("tabInspect.Image")));
            this.tabInspect.Name = "tabInspect";
            this.tabInspect.Text = "检查";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.ucEditPrescription1);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 46);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(852, 445);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.tabPrescription;
            // 
            // ucEditPrescription1
            // 
            this.ucEditPrescription1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEditPrescription1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucEditPrescription1.FunctionAreaHeight = 250;
            this.ucEditPrescription1.Location = new System.Drawing.Point(0, 0);
            this.ucEditPrescription1.Name = "ucEditPrescription1";
            this.ucEditPrescription1.Size = new System.Drawing.Size(852, 445);
            this.ucEditPrescription1.TabIndex = 0;
            // 
            // tabPrescription
            // 
            this.tabPrescription.AttachedControl = this.superTabControlPanel2;
            this.tabPrescription.GlobalItem = false;
            this.tabPrescription.Image = ((System.Drawing.Image)(resources.GetObject("tabPrescription.Image")));
            this.tabPrescription.Name = "tabPrescription";
            this.tabPrescription.Text = "处方";
            // 
            // superTabControlPanel5
            // 
            this.superTabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel5.Location = new System.Drawing.Point(0, 46);
            this.superTabControlPanel5.Name = "superTabControlPanel5";
            this.superTabControlPanel5.Size = new System.Drawing.Size(1349, 345);
            this.superTabControlPanel5.TabIndex = 0;
            this.superTabControlPanel5.TabItem = this.tabReport;
            // 
            // tabReport
            // 
            this.tabReport.AttachedControl = this.superTabControlPanel5;
            this.tabReport.GlobalItem = false;
            this.tabReport.Image = ((System.Drawing.Image)(resources.GetObject("tabReport.Image")));
            this.tabReport.Name = "tabReport";
            this.tabReport.Text = "报卡";
            // 
            // pnlPatientInfo
            // 
            this.pnlPatientInfo.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlPatientInfo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlPatientInfo.Controls.Add(this.tbxCategory);
            this.pnlPatientInfo.Controls.Add(this.tbxPayType);
            this.pnlPatientInfo.Controls.Add(this.tbxGender);
            this.pnlPatientInfo.Controls.Add(this.tbxAge);
            this.pnlPatientInfo.Controls.Add(this.tbxOutpatientNo);
            this.pnlPatientInfo.Controls.Add(this.tbxName);
            this.pnlPatientInfo.Controls.Add(this.labelX5);
            this.pnlPatientInfo.Controls.Add(this.labelX4);
            this.pnlPatientInfo.Controls.Add(this.labelX3);
            this.pnlPatientInfo.Controls.Add(this.labelX2);
            this.pnlPatientInfo.Controls.Add(this.labelX6);
            this.pnlPatientInfo.Controls.Add(this.labelX1);
            this.pnlPatientInfo.Controls.Add(this.pictureBox1);
            this.pnlPatientInfo.Controls.Add(this.buttonX3);
            this.pnlPatientInfo.Controls.Add(this.btnJournal);
            this.pnlPatientInfo.Controls.Add(this.buttonX2);
            this.pnlPatientInfo.Controls.Add(this.buttonX1);
            this.pnlPatientInfo.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlPatientInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPatientInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlPatientInfo.Name = "pnlPatientInfo";
            this.pnlPatientInfo.Size = new System.Drawing.Size(247, 651);
            this.pnlPatientInfo.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlPatientInfo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlPatientInfo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlPatientInfo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlPatientInfo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlPatientInfo.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Right;
            this.pnlPatientInfo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlPatientInfo.Style.GradientAngle = 90;
            this.pnlPatientInfo.TabIndex = 2;
            // 
            // tbxCategory
            // 
            this.tbxCategory.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbxCategory.Border.Class = "TextBoxBorder";
            this.tbxCategory.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxCategory.Location = new System.Drawing.Point(72, 370);
            this.tbxCategory.Name = "tbxCategory";
            this.tbxCategory.PreventEnterBeep = true;
            this.tbxCategory.ReadOnly = true;
            this.tbxCategory.Size = new System.Drawing.Size(155, 23);
            this.tbxCategory.TabIndex = 2;
            // 
            // tbxPayType
            // 
            this.tbxPayType.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbxPayType.Border.Class = "TextBoxBorder";
            this.tbxPayType.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxPayType.Location = new System.Drawing.Point(72, 341);
            this.tbxPayType.Name = "tbxPayType";
            this.tbxPayType.PreventEnterBeep = true;
            this.tbxPayType.ReadOnly = true;
            this.tbxPayType.Size = new System.Drawing.Size(155, 23);
            this.tbxPayType.TabIndex = 2;
            // 
            // tbxGender
            // 
            this.tbxGender.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbxGender.Border.Class = "TextBoxBorder";
            this.tbxGender.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxGender.Location = new System.Drawing.Point(72, 312);
            this.tbxGender.Name = "tbxGender";
            this.tbxGender.PreventEnterBeep = true;
            this.tbxGender.ReadOnly = true;
            this.tbxGender.Size = new System.Drawing.Size(155, 23);
            this.tbxGender.TabIndex = 2;
            // 
            // tbxAge
            // 
            this.tbxAge.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbxAge.Border.Class = "TextBoxBorder";
            this.tbxAge.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxAge.Location = new System.Drawing.Point(72, 283);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.PreventEnterBeep = true;
            this.tbxAge.ReadOnly = true;
            this.tbxAge.Size = new System.Drawing.Size(155, 23);
            this.tbxAge.TabIndex = 2;
            // 
            // tbxOutpatientNo
            // 
            this.tbxOutpatientNo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbxOutpatientNo.Border.Class = "TextBoxBorder";
            this.tbxOutpatientNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxOutpatientNo.ButtonCustom.Symbol = "";
            this.tbxOutpatientNo.ButtonCustom.Visible = true;
            this.tbxOutpatientNo.Location = new System.Drawing.Point(72, 225);
            this.tbxOutpatientNo.Name = "tbxOutpatientNo";
            this.tbxOutpatientNo.PreventEnterBeep = true;
            this.tbxOutpatientNo.ReadOnly = true;
            this.tbxOutpatientNo.Size = new System.Drawing.Size(155, 23);
            this.tbxOutpatientNo.TabIndex = 2;
            this.tbxOutpatientNo.ButtonCustomClick += new System.EventHandler(this.tbxOutpatientNo_ButtonCustomClick);
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbxName.Border.Class = "TextBoxBorder";
            this.tbxName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxName.ButtonCustom.Symbol = "";
            this.tbxName.ButtonCustom.Visible = true;
            this.tbxName.Location = new System.Drawing.Point(72, 254);
            this.tbxName.Name = "tbxName";
            this.tbxName.PreventEnterBeep = true;
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(155, 23);
            this.tbxName.TabIndex = 2;
            this.tbxName.ButtonCustomClick += new System.EventHandler(this.tbxOutpatientNo_ButtonCustomClick);
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(33, 373);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(43, 20);
            this.labelX5.TabIndex = 3;
            this.labelX5.Text = "号别:";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(33, 344);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(43, 20);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "身份:";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(33, 315);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(43, 20);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "性别:";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(33, 286);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(43, 20);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "年龄:";
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(18, 228);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(58, 20);
            this.labelX6.TabIndex = 3;
            this.labelX6.Text = "就诊号:";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(33, 257);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(43, 20);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "姓名:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(73, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.FocusCuesEnabled = false;
            this.buttonX3.Location = new System.Drawing.Point(18, 416);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(94, 43);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 0;
            this.buttonX3.Text = "转科";
            // 
            // btnJournal
            // 
            this.btnJournal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnJournal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnJournal.FocusCuesEnabled = false;
            this.btnJournal.Location = new System.Drawing.Point(18, 477);
            this.btnJournal.Name = "btnJournal";
            this.btnJournal.Size = new System.Drawing.Size(94, 43);
            this.btnJournal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnJournal.TabIndex = 0;
            this.btnJournal.Text = "病人资料";
            this.btnJournal.Click += new System.EventHandler(this.btnJournal_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.FocusCuesEnabled = false;
            this.buttonX2.Location = new System.Drawing.Point(134, 416);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(94, 43);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 0;
            this.buttonX2.Text = "就诊结束";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(18, 154);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(210, 43);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "选择患者";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // pnlFunctionArea
            // 
            this.pnlFunctionArea.Controls.Add(this.ucPrescription1);
            this.pnlFunctionArea.Controls.Add(this.expandableSplitter2);
            this.pnlFunctionArea.Controls.Add(this.ucPatientDiagnosis1);
            this.pnlFunctionArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFunctionArea.Location = new System.Drawing.Point(0, 0);
            this.pnlFunctionArea.Name = "pnlFunctionArea";
            this.pnlFunctionArea.Size = new System.Drawing.Size(852, 154);
            this.pnlFunctionArea.TabIndex = 10;
            this.pnlFunctionArea.SizeChanged += new System.EventHandler(this.pnlFunctionArea_SizeChanged);
            // 
            // ucPrescription1
            // 
            this.ucPrescription1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPrescription1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucPrescription1.FunctionAreaHeight = 0;
            this.ucPrescription1.Location = new System.Drawing.Point(619, 0);
            this.ucPrescription1.Name = "ucPrescription1";
            this.ucPrescription1.Size = new System.Drawing.Size(233, 154);
            this.ucPrescription1.TabIndex = 1;
            // 
            // expandableSplitter2
            // 
            this.expandableSplitter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.expandableSplitter2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.expandableSplitter2.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.None;
            this.expandableSplitter2.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.None;
            this.expandableSplitter2.Expandable = false;
            this.expandableSplitter2.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter2.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter2.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter2.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter2.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
            this.expandableSplitter2.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.expandableSplitter2.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter2.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter2.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter2.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter2.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter2.Location = new System.Drawing.Point(613, 0);
            this.expandableSplitter2.Name = "expandableSplitter2";
            this.expandableSplitter2.Size = new System.Drawing.Size(6, 154);
            this.expandableSplitter2.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter2.TabIndex = 12;
            this.expandableSplitter2.TabStop = false;
            // 
            // ucPatientDiagnosis1
            // 
            this.ucPatientDiagnosis1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucPatientDiagnosis1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucPatientDiagnosis1.FunctionAreaHeight = 0;
            this.ucPatientDiagnosis1.Location = new System.Drawing.Point(0, 0);
            this.ucPatientDiagnosis1.Name = "ucPatientDiagnosis1";
            this.ucPatientDiagnosis1.Size = new System.Drawing.Size(613, 154);
            this.ucPatientDiagnosis1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(247, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 651);
            this.panel2.TabIndex = 12;
            // 
            // pnlPrescription
            // 
            this.pnlPrescription.Controls.Add(this.tabMain);
            this.pnlPrescription.Controls.Add(this.expandableSplitter1);
            this.pnlPrescription.Controls.Add(this.pnlFunctionArea);
            this.pnlPrescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrescription.Location = new System.Drawing.Point(252, 0);
            this.pnlPrescription.Name = "pnlPrescription";
            this.pnlPrescription.Size = new System.Drawing.Size(852, 651);
            this.pnlPrescription.TabIndex = 16;
            // 
            // expandableSplitter1
            // 
            this.expandableSplitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandableSplitter1.Expandable = false;
            this.expandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
            this.expandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.expandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.Location = new System.Drawing.Point(0, 154);
            this.expandableSplitter1.MinSize = 0;
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.Size = new System.Drawing.Size(852, 6);
            this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter1.TabIndex = 12;
            this.expandableSplitter1.TabStop = false;
            // 
            // pnlMedicalRecord
            // 
            this.pnlMedicalRecord.Controls.Add(this.ucRecord);
            this.pnlMedicalRecord.Controls.Add(this.tabMainMedicalRecord);
            this.pnlMedicalRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMedicalRecord.Location = new System.Drawing.Point(252, 0);
            this.pnlMedicalRecord.Name = "pnlMedicalRecord";
            this.pnlMedicalRecord.Size = new System.Drawing.Size(852, 651);
            this.pnlMedicalRecord.TabIndex = 17;
            // 
            // ucRecord
            // 
            this.ucRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRecord.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucRecord.FunctionAreaHeight = 0;
            this.ucRecord.Location = new System.Drawing.Point(0, 46);
            this.ucRecord.Name = "ucRecord";
            this.ucRecord.Size = new System.Drawing.Size(852, 605);
            this.ucRecord.TabIndex = 2;
            // 
            // tabMainMedicalRecord
            // 
            this.tabMainMedicalRecord.AutoSelectAttachedControl = false;
            // 
            // 
            // 
            this.tabMainMedicalRecord.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tabMainMedicalRecord.ContainerControlProcessDialogKey = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tabMainMedicalRecord.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.tabMainMedicalRecord.ControlBox.MenuBox.Name = "";
            this.tabMainMedicalRecord.ControlBox.Name = "";
            this.tabMainMedicalRecord.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabMainMedicalRecord.ControlBox.MenuBox,
            this.tabMainMedicalRecord.ControlBox.CloseBox});
            this.tabMainMedicalRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMainMedicalRecord.Location = new System.Drawing.Point(0, 0);
            this.tabMainMedicalRecord.Name = "tabMainMedicalRecord";
            this.tabMainMedicalRecord.ReorderTabsEnabled = true;
            this.tabMainMedicalRecord.SelectedTabFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.tabMainMedicalRecord.SelectedTabIndex = 0;
            this.tabMainMedicalRecord.Size = new System.Drawing.Size(852, 46);
            this.tabMainMedicalRecord.TabCloseButtonHot = null;
            this.tabMainMedicalRecord.TabFont = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabMainMedicalRecord.TabIndex = 0;
            this.tabMainMedicalRecord.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabMedicalRecord,
            this.superTabItem2,
            this.superTabItem3,
            this.superTabItem4,
            this.superTabItem5});
            this.tabMainMedicalRecord.Text = "superTabStrip1";
            this.tabMainMedicalRecord.SelectedTabChanged += new System.EventHandler<DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs>(this.tabMainMedicalRecord_SelectedTabChanged);
            // 
            // tabMedicalRecord
            // 
            this.tabMedicalRecord.GlobalItem = false;
            this.tabMedicalRecord.Image = ((System.Drawing.Image)(resources.GetObject("tabMedicalRecord.Image")));
            this.tabMedicalRecord.Name = "tabMedicalRecord";
            this.tabMedicalRecord.Text = "病历";
            // 
            // superTabItem2
            // 
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.Image = ((System.Drawing.Image)(resources.GetObject("superTabItem2.Image")));
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "处方";
            // 
            // superTabItem3
            // 
            this.superTabItem3.GlobalItem = false;
            this.superTabItem3.Image = ((System.Drawing.Image)(resources.GetObject("superTabItem3.Image")));
            this.superTabItem3.Name = "superTabItem3";
            this.superTabItem3.Text = "检验";
            // 
            // superTabItem4
            // 
            this.superTabItem4.GlobalItem = false;
            this.superTabItem4.Image = ((System.Drawing.Image)(resources.GetObject("superTabItem4.Image")));
            this.superTabItem4.Name = "superTabItem4";
            this.superTabItem4.Text = "检查";
            // 
            // superTabItem5
            // 
            this.superTabItem5.GlobalItem = false;
            this.superTabItem5.Image = ((System.Drawing.Image)(resources.GetObject("superTabItem5.Image")));
            this.superTabItem5.Name = "superTabItem5";
            this.superTabItem5.Text = "报卡";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 656);
            this.Controls.Add(this.pnlPrescription);
            this.Controls.Add(this.pnlMedicalRecord);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlPatientInfo);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Text = "门诊医生站";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.superTabControlPanel3.ResumeLayout(false);
            this.superTabControlPanel4.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            this.pnlPatientInfo.ResumeLayout(false);
            this.pnlPatientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlFunctionArea.ResumeLayout(false);
            this.pnlPrescription.ResumeLayout(false);
            this.pnlMedicalRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabMainMedicalRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.PanelEx pnlPatientInfo;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.SuperTabControl tabMain;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem tabMedicalRecordButton;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel4;
        private DevComponents.DotNetBar.SuperTabItem tabInspect;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel3;
        private DevComponents.DotNetBar.SuperTabItem tabTest;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem tabPrescription;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel5;
        private DevComponents.DotNetBar.SuperTabItem tabReport;
        private System.Windows.Forms.Panel pnlFunctionArea;
        private Prescription.UCPatientDiagnosis ucPatientDiagnosis1;
        private System.Windows.Forms.Panel panel2;
        private Prescription.UCEditPrescription ucEditPrescription1;
        private Prescription.UCPrescription ucPrescription1;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter2;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxPayType;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxGender;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxAge;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxCategory;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxOutpatientNo;
        private DevComponents.DotNetBar.ButtonX btnJournal;
        private MedicalTechnology.UCMedicalTechnologyApply ucTestApply;
        private System.Windows.Forms.Panel pnlPrescription;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private System.Windows.Forms.Panel pnlMedicalRecord;
        private MedicalRecord.UCRecord ucRecord;
        private DevComponents.DotNetBar.SuperTabStrip tabMainMedicalRecord;
        private DevComponents.DotNetBar.SuperTabItem tabMedicalRecord;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;
        private DevComponents.DotNetBar.SuperTabItem superTabItem3;
        private DevComponents.DotNetBar.SuperTabItem superTabItem4;
        private DevComponents.DotNetBar.SuperTabItem superTabItem5;
        private MedicalTechnology.UCMedicalTechnologyApply ucInspectApply;
    }
}