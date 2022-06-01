using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DCSoft.Writer.Dom;
using HIS.Utility;
using HIS.Utility.Extensions;
using DCSoft.Writer.Controls;
using HIS.Core;

namespace App_OP.MedicalRecord
{
    internal partial class UCTemplateSampleWrite : UCBaseTemplateWrite
    {
        public override string Content
        {
            get
            {
                XTextTableElement table = this.Table;
                if (table != null && table.Elements.Count > 0)
                {
                    List<TemplateNodeItem> templateNodeItems = new List<TemplateNodeItem>();
                    foreach (XTextTableRowElement item in table.Elements)
                    {
                        XTextTableCellElement tableCell = item.Cells[0] as XTextTableCellElement;
                        XTextInputFieldElement inputField = tableCell.GetFirstElementByType(typeof(XTextInputFieldElement)) as XTextInputFieldElement;
                        if (inputField != null)
                        {
                            templateNodeItems.Add(new TemplateNodeItem()
                            {
                                XML = inputField.InnerXML,
                                Id = inputField.ID,
                                Name = this.TemplateNodeItems.Find(d => d.Id == inputField.ID).Name
                            });
                        }
                    }
                    return templateNodeItems.BeginJsonSerializable();
                }

                return null;
            }
            set
            {
                var table = this.Table;
                if (table == null)
                {
                    table = this.CreateTable(this.Font);
                }
                if (value == null)
                    return;
                table.Rows.Clear();
                this.InsertRowDownFromTable(table);
                var templateNodeItems = value.BeginJsonDeserialize<List<TemplateNodeItem>>();
                foreach (var item in templateNodeItems)
                {
                    var input = this.cWriter.Document.CreateElementByType(typeof(XTextInputFieldElement)) as XTextInputFieldElement;
                    if (item.XML != "")
                        input.AppendXML(item.XML);
                    input.ID = item.Id;
                    this.cWriter.FormView = FormViewMode.Disable;
                    this.InsertInputElementToTable(input, item.Name);
                }
            }
        }
        private void InsertInputElementToTable(XTextInputFieldElement input, string name)
        {
            XTextTableElement table = this.cWriter.GetElementById(TableContextId) as XTextTableElement;
            var cell = table.LastCell;
            cell.ContentBuilder.AppendTextWithStyle(name + ":", this.HeaderStyle);
            cell.ContentBuilder.AppendWithStyle(input, this.ContentStyle);
            cell.EditorRefreshView();
            this.InsertRowDownFromTable(table);
            this.cWriter.FormView = FormViewMode.Strict;
            input.Focus();
        }
        public override XTextTableElement CreateTable(Font tableFont)
        {
            XTextTableElement table = null;
            this.cWriter.SafeOperation(() =>
            {
                table = base.CreateTable(tableFont);
            });
            return table;
        }
        #region 作废
        //private void SetInputElementStyle(List<XTextInputFieldElement> inputs, int BorderWidth, bool updateUI = false)
        //{
        //    foreach (XTextInputFieldElement item in inputs)
        //    {
        //        SetInputElementStyle(item, BorderWidth, updateUI);
        //    }
        //}
        /// <summary>
        /// 设置指定输入域的样式
        /// </summary>
        /// <param name="input"></param>
        //private void SetInputElementStyle(XTextInputFieldElement input, int BorderWidth, bool updateUI = false)
        //{
        //    XTextElementList list = input.GetElementsByType(typeof(XTextInputFieldElement));
        //    foreach (XTextInputFieldElement item in list)
        //    {
        //        var style = item.Style.Clone();
        //        //判断是否为临时样式
        //        bool isTempStyle = item.GetAttribute("IsTempStyle").AsBoolean();
        //        //如果元素不存在边框 则启用临时样式
        //        if (!isTempStyle && !style.BorderBottom && BorderWidth > 0)
        //        {
        //            item.SetAttribute("IsTempStyle", "true");
        //        }
        //        if (item.GetAttribute("IsTempStyle").AsBoolean())
        //        {
        //            style.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        //            style.BorderBottom = BorderWidth == 0 ? false : true;
        //            style.BorderBottomColor = Color.Black;
        //            style.BorderWidth = BorderWidth;
        //            item.Style = style as DocumentContentStyle;
        //        }
        //    }
        //    if (updateUI)
        //        input.EditorRefreshView();
        //}
        #endregion
        private void InsertRowDownFromTable(XTextTableElement table, bool updateUI = false)
        {
            table.Style.Font = new DCSoft.Drawing.XFontValue(this.TableFont);
            DocumentContentStyle dataCellStyle = new DocumentContentStyle();
            dataCellStyle.PaddingLeft = 15;
            dataCellStyle.PaddingTop = 0;
            dataCellStyle.PaddingRight = 15;
            dataCellStyle.PaddingBottom = 0;
            XTextTableRowElement row = table.CreateRowInstance();
            XTextTableCellElement cell = table.CreateCellInstance();
            //row.Style = rowStyle as DocumentContentStyle;
            cell.Style = dataCellStyle;
            table.AppendChildElement(row);
            row.AppendChildElement(cell);
            if (updateUI)
                table.EditorRefreshView();
        }
        internal void RemoverTable()
        {
            if (this.Table != null)
            {
                this.cWriter.FormView = FormViewMode.Disable;
                this.Table.EditorDelete(false);
            }
        }
        public UCTemplateSampleWrite()
        {
            InitializeComponent();
            ToolStripMenuItem removerRowToolStripMenuItem = new ToolStripMenuItem();
            removerRowToolStripMenuItem.Text = "删除行";
            this.contextMenuStrip.Items.Add(removerRowToolStripMenuItem);
            removerRowToolStripMenuItem.Click += RemoverRowToolStripMenuItem_Click;
            this.Enabled = false;
            this.cWriter.SetZoomRate(1.25f);
            this.cWriter.DocumentContentChanged += (x, y) => { this.btnSave.Enabled = true; };
            this.cWriter.FormView = FormViewMode.Strict;
        }
        private void RemoverRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inputField = this.cWriter.CurrentInputField;
            string id = inputField.ID;
            if (!this.TemplateNodeItems.Exists(d => d.Id == id))
            {
                MsgBox.OK("当前节点无法删除");
                return;
            }
            var row = inputField.GetOwnerParent(typeof(XTextTableRowElement), false) as XTextTableRowElement;
            row.EditorDelete(false);
        }
    }
}
