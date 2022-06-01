﻿namespace App_Sys.Drug.SplitOrMergeManager
{
    partial class UCMerge
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl = new DevComponents.DotNetBar.PanelEx();
            this.btnSplitAll = new DevComponents.DotNetBar.ButtonX();
            this.btnCustomSplit = new DevComponents.DotNetBar.ButtonX();
            this.intAfterMergeBigPackageQuantity = new DevComponents.Editors.IntegerInput();
            this.intAllowMergeSmallPackageQuantity = new DevComponents.Editors.IntegerInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intAfterMergeBigPackageQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intAllowMergeSmallPackageQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl.Controls.Add(this.btnSplitAll);
            this.pnl.Controls.Add(this.btnCustomSplit);
            this.pnl.Controls.Add(this.intAfterMergeBigPackageQuantity);
            this.pnl.Controls.Add(this.intAllowMergeSmallPackageQuantity);
            this.pnl.Controls.Add(this.labelX2);
            this.pnl.Controls.Add(this.labelX1);
            this.pnl.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(159, 185);
            this.pnl.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.pnl.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.pnl.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl.Style.GradientAngle = 90;
            this.pnl.TabIndex = 0;
            // 
            // btnSplitAll
            // 
            this.btnSplitAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSplitAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSplitAll.Location = new System.Drawing.Point(26, 118);
            this.btnSplitAll.Name = "btnSplitAll";
            this.btnSplitAll.Size = new System.Drawing.Size(105, 23);
            this.btnSplitAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSplitAll.TabIndex = 5;
            this.btnSplitAll.Text = "全部合并";
            this.btnSplitAll.Click += new System.EventHandler(this.btnAllMerge_Click);
            // 
            // btnCustomSplit
            // 
            this.btnCustomSplit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCustomSplit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCustomSplit.Location = new System.Drawing.Point(26, 147);
            this.btnCustomSplit.Name = "btnCustomSplit";
            this.btnCustomSplit.Size = new System.Drawing.Size(105, 23);
            this.btnCustomSplit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCustomSplit.TabIndex = 5;
            this.btnCustomSplit.Text = "自定义合并";
            this.btnCustomSplit.Click += new System.EventHandler(this.btnCustomMerge_Click);
            // 
            // intAfterMergeBigPackageQuantity
            // 
            // 
            // 
            // 
            this.intAfterMergeBigPackageQuantity.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intAfterMergeBigPackageQuantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intAfterMergeBigPackageQuantity.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intAfterMergeBigPackageQuantity.Enabled = false;
            this.intAfterMergeBigPackageQuantity.Location = new System.Drawing.Point(26, 91);
            this.intAfterMergeBigPackageQuantity.Name = "intAfterMergeBigPackageQuantity";
            this.intAfterMergeBigPackageQuantity.Size = new System.Drawing.Size(105, 23);
            this.intAfterMergeBigPackageQuantity.TabIndex = 2;
            // 
            // intAllowMergeSmallPackageQuantity
            // 
            // 
            // 
            // 
            this.intAllowMergeSmallPackageQuantity.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intAllowMergeSmallPackageQuantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intAllowMergeSmallPackageQuantity.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intAllowMergeSmallPackageQuantity.Location = new System.Drawing.Point(26, 40);
            this.intAllowMergeSmallPackageQuantity.Name = "intAllowMergeSmallPackageQuantity";
            this.intAllowMergeSmallPackageQuantity.ShowUpDown = true;
            this.intAllowMergeSmallPackageQuantity.Size = new System.Drawing.Size(105, 23);
            this.intAllowMergeSmallPackageQuantity.TabIndex = 2;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(26, 67);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(122, 20);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "合并后的大包装数";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(26, 16);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(122, 20);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "待合并的小包装数";
            // 
            // UCMerge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl);
            this.Name = "UCMerge";
            this.Size = new System.Drawing.Size(159, 185);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intAfterMergeBigPackageQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intAllowMergeSmallPackageQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.IntegerInput intAllowMergeSmallPackageQuantity;
        private DevComponents.Editors.IntegerInput intAfterMergeBigPackageQuantity;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnCustomSplit;
        private DevComponents.DotNetBar.ButtonX btnSplitAll;
    }
}
