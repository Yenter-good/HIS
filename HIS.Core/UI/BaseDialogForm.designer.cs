
namespace HIS.Core.UI
{
    partial class BaseDialogForm
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
            this.fpnlButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.btnNO = new DevComponents.DotNetBar.ButtonX();
            this.btnYes = new DevComponents.DotNetBar.ButtonX();
            this.btnIngore = new DevComponents.DotNetBar.ButtonX();
            this.btnRetry = new DevComponents.DotNetBar.ButtonX();
            this.btnAbort = new DevComponents.DotNetBar.ButtonX();
            this.pnlBackgrond = new DevComponents.DotNetBar.PanelEx();
            this.fpnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpnlButton
            // 
            this.fpnlButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpnlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.fpnlButton.Controls.Add(this.btnCancel);
            this.fpnlButton.Controls.Add(this.btnOK);
            this.fpnlButton.Controls.Add(this.btnNO);
            this.fpnlButton.Controls.Add(this.btnYes);
            this.fpnlButton.Controls.Add(this.btnIngore);
            this.fpnlButton.Controls.Add(this.btnRetry);
            this.fpnlButton.Controls.Add(this.btnAbort);
            this.fpnlButton.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fpnlButton.Location = new System.Drawing.Point(0, 266);
            this.fpnlButton.Name = "fpnlButton";
            this.fpnlButton.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.fpnlButton.Size = new System.Drawing.Size(509, 36);
            this.fpnlButton.TabIndex = 1000;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(442, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 23);
            this.btnCancel.TabIndex = 1000;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnOK.Location = new System.Drawing.Point(372, 7);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(64, 23);
            this.btnOK.TabIndex = 999;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnNO
            // 
            this.btnNO.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNO.Location = new System.Drawing.Point(302, 7);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(64, 23);
            this.btnNO.TabIndex = 1000;
            this.btnNO.Text = "否";
            this.btnNO.Visible = false;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // btnYes
            // 
            this.btnYes.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYes.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnYes.Location = new System.Drawing.Point(232, 7);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(64, 23);
            this.btnYes.TabIndex = 999;
            this.btnYes.Text = "是";
            this.btnYes.Visible = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnIngore
            // 
            this.btnIngore.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnIngore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngore.Location = new System.Drawing.Point(162, 7);
            this.btnIngore.Name = "btnIngore";
            this.btnIngore.Size = new System.Drawing.Size(64, 23);
            this.btnIngore.TabIndex = 1000;
            this.btnIngore.Text = "忽略";
            this.btnIngore.Visible = false;
            this.btnIngore.Click += new System.EventHandler(this.btnIngore_Click);
            // 
            // btnRetry
            // 
            this.btnRetry.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRetry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetry.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnRetry.Location = new System.Drawing.Point(92, 7);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(64, 23);
            this.btnRetry.TabIndex = 1000;
            this.btnRetry.Text = "重试";
            this.btnRetry.Visible = false;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbort.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnAbort.Location = new System.Drawing.Point(22, 7);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(64, 23);
            this.btnAbort.TabIndex = 1000;
            this.btnAbort.Text = "中止";
            this.btnAbort.Visible = false;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // pnlBackgrond
            // 
            this.pnlBackgrond.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBackgrond.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlBackgrond.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlBackgrond.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlBackgrond.Location = new System.Drawing.Point(5, 266);
            this.pnlBackgrond.Name = "pnlBackgrond";
            this.pnlBackgrond.Size = new System.Drawing.Size(515, 48);
            this.pnlBackgrond.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlBackgrond.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.pnlBackgrond.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.pnlBackgrond.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlBackgrond.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlBackgrond.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.pnlBackgrond.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlBackgrond.Style.GradientAngle = 90;
            this.pnlBackgrond.TabIndex = 3;
            // 
            // BaseDialogForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSize = new System.Drawing.Size(523, 302);
            this.Controls.Add(this.fpnlButton);
            this.Controls.Add(this.pnlBackgrond);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseDialogForm";
            this.Padding = new System.Windows.Forms.Padding(0, 4, 0, 36);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "对话框";
            this.fpnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnOK;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private System.Windows.Forms.FlowLayoutPanel fpnlButton;
        private DevComponents.DotNetBar.ButtonX btnNO;
        private DevComponents.DotNetBar.ButtonX btnYes;
        private DevComponents.DotNetBar.ButtonX btnAbort;
        private DevComponents.DotNetBar.ButtonX btnIngore;
        private DevComponents.DotNetBar.ButtonX btnRetry;
        private DevComponents.DotNetBar.PanelEx pnlBackgrond;
    }
}