
namespace HIS.ControlLib.Popups
{
    partial class ComboTreePopupView
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symbolBox1 = new DevComponents.DotNetBar.Controls.SymbolBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFilter = new HIS.ControlLib.DelayTextBox();
            this.treeFilter = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // symbolBox1
            // 
            this.symbolBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.symbolBox1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.symbolBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.symbolBox1.Location = new System.Drawing.Point(127, 8);
            this.symbolBox1.Name = "symbolBox1";
            this.symbolBox1.Size = new System.Drawing.Size(19, 13);
            this.symbolBox1.Symbol = "";
            this.symbolBox1.SymbolColor = System.Drawing.Color.SteelBlue;
            this.symbolBox1.TabIndex = 1;
            this.symbolBox1.Text = "symbolBox1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.symbolBox1);
            this.panel1.Controls.Add(this.txtFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.panel1.Size = new System.Drawing.Size(150, 30);
            this.panel1.TabIndex = 2;
            // 
            // txtFilter
            // 
            // 
            // 
            // 
            this.txtFilter.Border.Class = "TextBoxBorder";
            this.txtFilter.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFilter.DelayTime = 200;
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilter.Location = new System.Drawing.Point(0, 4);
            this.txtFilter.MarkString = null;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PreventEnterBeep = true;
            this.txtFilter.Size = new System.Drawing.Size(150, 21);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            // 
            // treeFilter
            // 
            this.treeFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treeFilter.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.treeFilter.BackgroundStyle.BorderColor = System.Drawing.Color.Transparent;
            this.treeFilter.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.treeFilter.BackgroundStyle.BorderTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(225)))));
            this.treeFilter.BackgroundStyle.BorderTopWidth = 1;
            this.treeFilter.BackgroundStyle.Class = "TreeBorderKey";
            this.treeFilter.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.treeFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeFilter.DragDropEnabled = false;
            this.treeFilter.DragDropNodeCopyEnabled = false;
            this.treeFilter.ExpandButtonType = DevComponents.AdvTree.eExpandButtonType.Triangle;
            this.treeFilter.Location = new System.Drawing.Point(0, 30);
            this.treeFilter.Name = "treeFilter";
            this.treeFilter.NodesConnector = this.nodeConnector1;
            this.treeFilter.NodeStyle = this.elementStyle1;
            this.treeFilter.PathSeparator = ";";
            this.treeFilter.Size = new System.Drawing.Size(150, 120);
            this.treeFilter.Styles.Add(this.elementStyle1);
            this.treeFilter.TabIndex = 3;
            this.treeFilter.Text = "advTree1";
            this.treeFilter.NodeClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treeFilter_NodeClick);
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // ComboTreePopupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeFilter);
            this.Controls.Add(this.panel1);
            this.Name = "ComboTreePopupView";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DelayTextBox txtFilter;
        private DevComponents.DotNetBar.Controls.SymbolBox symbolBox1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.AdvTree.AdvTree treeFilter;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
    }
}
