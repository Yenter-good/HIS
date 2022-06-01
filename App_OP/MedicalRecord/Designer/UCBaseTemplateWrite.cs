using System;
using System.ComponentModel;
using System.Windows.Forms;
using DCSoft.Writer.Dom;
using HIS.Service.Core;
using System.Collections.Generic;
using System.Drawing;
using HIS.Utility.Extensions;
using System.Linq;
using HIS.Core;
using DCSoft.Writer;
using System.Drawing.Printing;

namespace App_OP.MedicalRecord
{
    public partial class UCBaseTemplateWrite : UserControl
    {
        /// <summary>
        /// 数据表格Id
        /// </summary>
        public const string TableContextId = "TableContext";
        /// <summary>
        /// 文档内容
        /// </summary>
        public virtual string Content
        {
            get { return this.cWriter.XMLText; }
            set { this.cWriter.XMLText = value; }
        }
        /// <summary>
        /// 数据表格
        /// </summary>
        public virtual XTextTableElement Table
        { get { return this.GetElement<XTextTableElement>(TableContextId); } }
        /// <summary>
        /// 表格字体样式
        /// </summary>
        public virtual Font TableFont
        { get { return new Font("宋体", 6); } }

        private List<TemplateNodeItem> _templateNodeItems;
        /// <summary>
        /// 模板节点
        /// </summary>
        public List<TemplateNodeItem> TemplateNodeItems
        {
            get
            {
                if (this._templateNodeItems == null)
                {
                    if (this.SysDictQueryService == null)
                        this.SysDictQueryService = ServiceLocator.GetService<ISysDictQueryService>();
                    var templateNodes = this.SysDictQueryService.GetOPTemplateNode();
                    if (templateNodes != null && templateNodes.Count > 0)
                        this._templateNodeItems = templateNodes.Select(d => new TemplateNodeItem { Id = d.Code, Name = d.Value }).ToList();
                    if (this._templateNodeItems == null)
                        this._templateNodeItems = new List<TemplateNodeItem>();
                    this._templateNodeItems.Add(this.DealNode);
                    this._templateNodeItems.Add(this.ExaminationResultNode);
                }

                return this._templateNodeItems;
            }
        }
        /// <summary>
        /// 字典服务
        /// </summary>
        public ISysDictQueryService SysDictQueryService;
        /// <summary>
        /// 处理节点
        /// </summary>
        public TemplateNodeItem DealNode;
        /// <summary>
        /// 辅助检查节点
        /// </summary>
        public TemplateNodeItem ExaminationResultNode;
        /// <summary>
        /// 头风格
        /// </summary>
        public DocumentContentStyle HeaderStyle;
        /// <summary>
        /// 内容风格
        /// </summary>
        public DocumentContentStyle ContentStyle;
        /// <summary>
        /// 存储事件
        /// </summary>
        public event EventHandler<string> Save;

        public UCBaseTemplateWrite()
        {
            InitializeComponent();
            this.btnSave.Enabled = false;
            this.cWriter.ContextMenuStrip = this.contextMenuStrip;
            this.cWriter.CommandControler = this.wComm;
            this.cWriter.CommandControler.Start();
            this.cWriter.PageSettings.PaperKind = PaperKind.A5;
            this.DealNode = new TemplateNodeItem() { Id = "DealWith", Name = "处理" };
            this.ExaminationResultNode = new TemplateNodeItem() { Id = "ExaminationResult", Name = "辅助检查" };
            this.HeaderStyle = new DocumentContentStyle() { FontStyle = FontStyle.Bold, FontSize = 10, FontName = "宋体" };
            this.ContentStyle = new DocumentContentStyle() { FontSize = 10, FontName = "宋体" };
        }
        #region 方法
        public void FileSaveToXml()
        {
            this.cWriter.DialogFileSaveToXml();
        }
        public T GetElementValue<T>(string fieldid, bool xmlFormat = false)
        {
            T returnValue = default(T);
            XTextElement xtee = cWriter.GetElementById(fieldid);
            if (xtee != null)
            {
                if (xtee is XTextInputFieldElement)
                    xtee = xtee as XTextInputFieldElement;
            }
            if (xmlFormat)
                returnValue = (T)Convert.ChangeType(xtee.OuterXML, typeof(T));
            else
                returnValue = (T)Convert.ChangeType(xtee.Text, typeof(T));

            return returnValue;
        }
        public T GetElement<T>(string id) where T : class
        {
            return this.cWriter.GetElementById(id) as T;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys)Shortcut.CtrlS)
            {
                if (this.btnSave.Enabled)
                {
                    this.btnSave_Click(null, null);
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void InsertInputElementToTable(XTextTableRowElement xTextTableRowElement, XTextInputFieldElement input, string name)
        {
            XTextTableElement table = this.Table;
            var cell = xTextTableRowElement.Cells[0] as XTextTableCellElement;
            cell.ContentBuilder.AppendTextWithStyle(name + ":", this.HeaderStyle);
            cell.ContentBuilder.AppendWithStyle(input, this.ContentStyle);
            cell.EditorRefreshView();
            table.InsertChildElement(this.cWriter.Document.CurrentTableCell.RowIndex + 1, xTextTableRowElement);
            table.EditorRefreshView();
            input.Focus();
        }
        public void InsertTemplateNode(TemplateNodeItem templateNodeItem)
        {
            //判断数据表格是否存在
            XTextTableElement table = this.Table;
            if (table == null)
            {
                MsgBox.OK("请先插入数据表格");
                return;
            }
            //判断节点是否存在
            XTextInputFieldElement input = this.GetElement<XTextInputFieldElement>(templateNodeItem.Id);
            if (input != null)
            {
                input.Focus();
                return;
            }
            input = (XTextInputFieldElement)this.cWriter.Document.CreateElementByType(typeof(XTextInputFieldElement));
            input.ID = templateNodeItem.Id;

            XTextTableRowElement row = table.NewRow();
            foreach (XTextTableRowElement item in table.Elements)
            {
                XTextTableCellElement cell = item.Cells[0] as XTextTableCellElement;
                XTextInputFieldElement inputTmp = cell.GetFirstElementByType(typeof(XTextInputFieldElement)) as XTextInputFieldElement;
                if (inputTmp == null)
                {
                    row = item;
                    break;
                }
            }

            this.InsertInputElementToTable(row, input, templateNodeItem.Name);
        }
        public virtual XTextTableElement CreateTable(Font tableFont)
        {
            XTextTableElement table = new XTextTableElement();
            table.Style.Font = new DCSoft.Drawing.XFontValue(tableFont);
            table.ID = TableContextId;

            XTextTableColumnElement col = table.CreateColumnInstance();
            table.Columns.Add(col);
            table.Rows.Add(table.NewRow());
            this.cWriter.ExecuteCommand(StandardCommandNames.Table_InsertTable, false, table);

            return table;
        }
        #endregion

        #region 事件
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Save?.Invoke(this, this.Content);
        }
        private void SpecialNodeClick(object sender, EventArgs e)
        {
            object tag = (sender as ToolStripMenuItem).Tag;
            if (tag == null) return;
            var templateNodeItem = tag as TemplateNodeItem;
            if (this.cWriter.CurrentTable != null && this.cWriter.CurrentTable.ID == TableContextId)
                this.InsertTemplateNode(templateNodeItem);
            else
            {
                DCSoft.Writer.Commands.InsertStringCommandParameter p
                    = new DCSoft.Writer.Commands.InsertStringCommandParameter();
                p.Text = templateNodeItem.Name + ":";
                p.Style = new DocumentContentStyle();
                p.Style.Bold = true;
                p.Style.FontSize = 10.5f;
                p.Style.FontName = "宋体";
                this.cWriter.ExecuteCommand(StandardCommandNames.InsertString, false, p);

                XTextInputFieldElement field = new XTextInputFieldElement();
                field.ID = templateNodeItem.Id;
                this.cWriter.ExecuteCommand(StandardCommandNames.InsertInputField, false, field);
            }
        }
        private void Bti_Click(object sender, EventArgs e)
        {
            this.InsertTemplateNode((sender as ToolStripMenuItem).Tag as TemplateNodeItem);
        }
        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (this.InsertToolStripMenuItem.DropDownItems.Count == 0)
            {
                foreach (var templateNodeItem in this.TemplateNodeItems)
                {
                    if (templateNodeItem == this.DealNode || templateNodeItem == this.ExaminationResultNode)
                        continue;
                    ToolStripMenuItem tsmi = new ToolStripMenuItem();
                    tsmi.Text = templateNodeItem.Name;
                    tsmi.Tag = templateNodeItem;
                    tsmi.Click += Bti_Click;

                    this.InsertToolStripMenuItem.DropDownItems.Add(tsmi);
                }

                ToolStripMenuItem btiDealWith = new ToolStripMenuItem();
                btiDealWith.Text = this.DealNode.Name;
                btiDealWith.Tag = this.DealNode;

                ToolStripMenuItem btiExaminationResult = new ToolStripMenuItem();
                btiExaminationResult.Text = this.ExaminationResultNode.Name;
                btiExaminationResult.Tag = this.ExaminationResultNode;

                this.InsertToolStripMenuItem.DropDownItems.Add(btiDealWith);
                this.InsertToolStripMenuItem.DropDownItems.Add(btiExaminationResult);

                btiDealWith.Click += SpecialNodeClick;
                btiExaminationResult.Click += SpecialNodeClick;
            }
        }
        private void InsertDataTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Table == null)
            {
                this.CreateTable(this.TableFont);
            }
        }
        #endregion
    }
}
