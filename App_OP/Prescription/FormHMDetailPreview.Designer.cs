
namespace App_OP.Prescription
{
    partial class FormHMDetailPreview
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
            this.lvDrug = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.SuspendLayout();
            // 
            // lvDrug
            // 
            // 
            // 
            // 
            this.lvDrug.Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.lvDrug.Border.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.lvDrug.Border.BackgroundImageAlpha = ((byte)(0));
            this.lvDrug.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.lvDrug.Border.BorderBottomWidth = 1;
            this.lvDrug.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.lvDrug.Border.BorderLeftWidth = 1;
            this.lvDrug.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.lvDrug.Border.BorderRightWidth = 1;
            this.lvDrug.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.lvDrug.Border.BorderTopWidth = 1;
            this.lvDrug.Border.Class = "ListViewBorder";
            this.lvDrug.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lvDrug.DisabledBackColor = System.Drawing.Color.Empty;
            this.lvDrug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDrug.HideSelection = false;
            this.lvDrug.Location = new System.Drawing.Point(1, 1);
            this.lvDrug.Name = "lvDrug";
            this.lvDrug.Size = new System.Drawing.Size(680, 258);
            this.lvDrug.TabIndex = 0;
            this.lvDrug.UseCompatibleStateImageBehavior = false;
            this.lvDrug.View = System.Windows.Forms.View.Tile;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx2.Location = new System.Drawing.Point(1, 259);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(680, 30);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 5;
            // 
            // FormHMDetailPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 290);
            this.Controls.Add(this.lvDrug);
            this.Controls.Add(this.panelEx2);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHMDetailPreview";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormPrescriptionDetailPreview";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.ListViewEx lvDrug;
        private DevComponents.DotNetBar.PanelEx panelEx2;
    }
}