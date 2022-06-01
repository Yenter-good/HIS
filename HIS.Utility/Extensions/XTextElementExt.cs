using DCSoft.Writer.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Utility.Extensions
{
    /// <summary>
    /// 作者:wfg
    /// 创建时间:2021-02-24 15:39:46
    /// 描述:
    /// </summary>
    public static class XTextElementExt
    {
        public static void AppendXML(this XTextInputFieldElementBase element, string xml, string format = "xml")
        {
            if (element.OwnerDocument == null) return;
            if (xml.IsNullOrWhiteSpace()) return;
            //element.ContentBuilder.Clear();
            element.ContentBuilder.AppendDocumentContentByString(xml, format, true, true, true, true);
        }
        public static XTextTableRowElement NewRow(this XTextTableElement tableElement, DocumentContentStyle documentContentStyle = null)
        {
            if (tableElement == null)
                return null;
            DocumentContentStyle dataCellStyle = null;
            if (documentContentStyle == null)
            {
                dataCellStyle = new DocumentContentStyle();
                dataCellStyle.PaddingLeft = 15;
                dataCellStyle.PaddingTop = 0;
                dataCellStyle.PaddingRight = 15;
                dataCellStyle.PaddingBottom = 0;
            }
            var row = tableElement.CreateRowInstance();
            var cell = tableElement.CreateCellInstance();
            cell.Style = dataCellStyle;
            row.AppendChildElement(cell);

            return row;
        }

    }
}
