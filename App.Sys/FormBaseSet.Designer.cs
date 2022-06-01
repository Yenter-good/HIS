namespace App_Sys
{
    partial class FormBaseSet
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
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btiReflesh = new DevComponents.DotNetBar.ButtonItem();
            this.btiAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btiEdit = new DevComponents.DotNetBar.ButtonItem();
            this.btiRemover = new DevComponents.DotNetBar.ButtonItem();
            this.btiRemoverAll = new DevComponents.DotNetBar.ButtonItem();
            this.grid = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.pnl = new DevComponents.DotNetBar.PanelEx();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.btiRightMenu = new DevComponents.DotNetBar.ButtonItem();
            this.btiM_Edit = new DevComponents.DotNetBar.ButtonItem();
            this.btiM_Remover = new DevComponents.DotNetBar.ButtonItem();
            this.btiM_RemoverAll = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btiReflesh,
            this.btiAdd,
            this.btiEdit,
            this.btiRemover,
            this.btiRemoverAll});
            this.bar1.Location = new System.Drawing.Point(96, 12);
            this.bar1.Name = "bar1";
            this.bar1.RoundCorners = false;
            this.bar1.Size = new System.Drawing.Size(772, 27);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btiReflesh
            // 
            this.btiReflesh.Name = "btiReflesh";
            this.btiReflesh.Text = "刷新";
            this.btiReflesh.Click += new System.EventHandler(this.btiReflesh_Click);
            // 
            // btiAdd
            // 
            this.btiAdd.BeginGroup = true;
            this.btiAdd.Name = "btiAdd";
            this.btiAdd.Text = "添加";
            this.btiAdd.Click += new System.EventHandler(this.btiAdd_Click);
            // 
            // btiEdit
            // 
            this.btiEdit.Name = "btiEdit";
            this.btiEdit.Text = "修改";
            this.btiEdit.Click += new System.EventHandler(this.btiEdit_Click);
            // 
            // btiRemover
            // 
            this.btiRemover.Name = "btiRemover";
            this.btiRemover.Text = "删除";
            this.btiRemover.Click += new System.EventHandler(this.btiRemover_Click);
            // 
            // btiRemoverAll
            // 
            this.btiRemoverAll.Name = "btiRemoverAll";
            this.btiRemoverAll.Text = "全部删除";
            this.btiRemoverAll.Click += new System.EventHandler(this.btiRemoverAll_Click);
            // 
            // grid
            // 
            this.contextMenuBar1.SetContextMenuEx(this.grid, this.btiRightMenu);
            this.grid.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grid.Location = new System.Drawing.Point(163, 118);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(461, 273);
            this.grid.TabIndex = 1;
            this.grid.Text = "superGridControl1";
            this.grid.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.grid_RowDoubleClick);
            this.grid.SelectionChanged += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridEventArgs>(this.Grid_SelectionChanged);
            // 
            // pnl
            // 
            this.pnl.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl.Location = new System.Drawing.Point(85, 372);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(631, 329);
            this.pnl.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl.Style.GradientAngle = 90;
            this.pnl.TabIndex = 2;
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.AntiAlias = true;
            this.contextMenuBar1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.contextMenuBar1.IsMaximized = false;
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btiRightMenu});
            this.contextMenuBar1.Location = new System.Drawing.Point(686, 206);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(87, 27);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.contextMenuBar1.TabIndex = 6;
            this.contextMenuBar1.TabStop = false;
            this.contextMenuBar1.Text = "contextMenuBar1";
            // 
            // btiRightMenu
            // 
            this.btiRightMenu.AutoExpandOnClick = true;
            this.btiRightMenu.Name = "btiRightMenu";
            this.btiRightMenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btiM_Edit,
            this.btiM_Remover,
            this.btiM_RemoverAll});
            this.btiRightMenu.Text = "右键菜单";
            this.btiRightMenu.PopupOpen += new DevComponents.DotNetBar.DotNetBarManager.PopupOpenEventHandler(this.btiRightMenu_PopupOpen);
            // 
            // btiM_Edit
            // 
            this.btiM_Edit.Name = "btiM_Edit";
            this.btiM_Edit.Text = "修改";
            this.btiM_Edit.Click += new System.EventHandler(this.btiEdit_Click);
            // 
            // btiM_Remover
            // 
            this.btiM_Remover.Name = "btiM_Remover";
            this.btiM_Remover.Text = "删除";
            this.btiM_Remover.Click += new System.EventHandler(this.btiRemover_Click);
            // 
            // btiM_RemoverAll
            // 
            this.btiM_RemoverAll.Name = "btiM_RemoverAll";
            this.btiM_RemoverAll.Text = "全部删除";
            this.btiM_RemoverAll.Click += new System.EventHandler(this.btiRemoverAll_Click);
            // 
            // FormBaseSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 849);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.contextMenuBar1);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.bar1);
            this.Name = "FormBaseSet";
            this.Text = "FormBaseSet";
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevComponents.DotNetBar.Bar bar1;
        public DevComponents.DotNetBar.SuperGrid.SuperGridControl grid;
        public DevComponents.DotNetBar.PanelEx pnl;
        public DevComponents.DotNetBar.ButtonItem btiReflesh;
        public DevComponents.DotNetBar.ButtonItem btiAdd;
        public DevComponents.DotNetBar.ButtonItem btiEdit;
        public DevComponents.DotNetBar.ButtonItem btiRemover;
        public DevComponents.DotNetBar.ButtonItem btiRemoverAll;
        private DevComponents.DotNetBar.ButtonItem btiRightMenu;
        public DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        public DevComponents.DotNetBar.ButtonItem btiM_Edit;
        public DevComponents.DotNetBar.ButtonItem btiM_Remover;
        public DevComponents.DotNetBar.ButtonItem btiM_RemoverAll;
    }
}