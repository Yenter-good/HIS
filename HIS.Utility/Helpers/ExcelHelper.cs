
using DevComponents.DotNetBar.SuperGrid;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace HIS.Utility
{
    /// <summary>
    /// 用于Excel操作
    /// </summary>
    public class ExcelHelper
    {
        #region 导出

        #region Excel

        /// <summary>
        /// 导出Excel格式文件
        /// </summary>
        /// <param name="dataTable">数据表</param>
        /// <param name="headerColumn">数据表字段名-说明对应列表</param>
        /// <param name="fileName">文件路径</param>
        private static void InnerExportXls(DataTable dataTable, Dictionary<string, string> headerColumn, string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            HSSFWorkbook workbook = new HSSFWorkbook();
            MemoryStream ms = new MemoryStream();
            ISheet sheet = workbook.CreateSheet();
            IRow headerRow = sheet.CreateRow(0);

            // 写出表头
            int i = 0;
            foreach (var item in headerColumn)
            {
                headerRow.CreateCell(i).SetCellValue(item.Value);
                i++;
            }
            // 行索引号
            int rowIndex = 1;

            // 写出数据
            foreach (DataRow dataTableRow in dataTable.Rows)
            {
                IRow dataRow = sheet.CreateRow(rowIndex);

                i = -1;
                foreach (var item in headerColumn)
                {
                    i++;
                    if (!dataTable.Columns.Contains(item.Key))
                        continue;
                    var column = dataTable.Columns[item.Key];
                    switch (column.DataType.ToString())
                    {
                        case "System.String":
                        default:
                            dataRow.CreateCell(i).SetCellValue(
                                Convert.ToString(Convert.IsDBNull(dataTableRow[i]) ? "" : dataTableRow[i])
                                );
                            break;

                        case "System.Int16":
                        case "System.Int32":
                        case "System.Int64":
                        case "System.Decimal":
                        case "System.Double":
                            dataRow.CreateCell(i).SetCellValue(
                                Convert.ToDouble(Convert.IsDBNull(dataTableRow[i]) ? 0 : dataTableRow[i])
                                );
                            break;
                    }
                }

                rowIndex++;
            }

            workbook.Write(ms);
            byte[] data = ms.ToArray();

            ms.Flush();
            ms.Close();

            fs.Write(data, 0, data.Length);
            fs.Flush();
            fs.Close();
        }


        /// <summary>
        /// 导出Excel格式文件
        /// </summary>
        /// <param name="fileName">文件路径</param>
        private static void InnerExportXls(GridPanel panel, string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);

            HSSFWorkbook workbook = new HSSFWorkbook();
            MemoryStream ms = new MemoryStream();
            ISheet sheet = workbook.CreateSheet();
            IRow headerRow = sheet.CreateRow(0);

            // 写出表头
            int i = 0;
            foreach (GridColumn gc in panel.Columns)
            {
                if (!gc.Visible) continue;
                headerRow.CreateCell(i).SetCellValue(string.IsNullOrEmpty(gc.HeaderText) ? gc.Name : gc.HeaderText);
                i++;
            }
            // 行索引号
            int rowIndex = 1;

            // 写出数据
            foreach (GridRow gr in panel.Rows)
            {
                IRow ir = sheet.CreateRow(rowIndex);

                i = -1;
                int cellIndex = -1;
                foreach (GridColumn gc in panel.Columns)
                {
                    if (!gc.Visible)
                    {
                        cellIndex++;
                        continue;
                    }
                    cellIndex++;
                    i++;
                    if (gc.DataType == null)
                    {
                        if (gr[cellIndex] != null)
                            ir.CreateCell(i).SetCellValue(gr[cellIndex].Value.AsNotNullString());
                    }
                    else
                    {
                        switch (gc.DataType.ToString())
                        {
                            case "System.String":
                            default:
                                ir.CreateCell(i).SetCellValue(gr[cellIndex].Value.AsNotNullString());
                                break;

                            case "System.Int16":
                            case "System.Int32":
                            case "System.Int64":
                            case "System.Decimal":
                            case "System.Double":
                                ir.CreateCell(i).SetCellValue(gr[cellIndex].Value.AsDouble(0));
                                break;
                        }
                    }
                }
                rowIndex++;
            }

            workbook.Write(ms);
            byte[] data = ms.ToArray();

            ms.Flush();
            ms.Close();

            fs.Write(data, 0, data.Length);
            fs.Flush();
            fs.Close();
        }


        /// <summary>
        /// 导出Excel格式文件
        /// </summary>
        /// <param name="fileName">文件路径</param>
        private static void InnerExportXls<T>(List<T> list, Dictionary<string, string> headerColumn, string fileName)
        {
            if (list == null) return;
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);

            HSSFWorkbook workbook = new HSSFWorkbook();
            MemoryStream ms = new MemoryStream();
            ISheet sheet = workbook.CreateSheet();
            IRow headerRow = sheet.CreateRow(0);

            // 写出表头
            int i = 0;
            foreach (var hc in headerColumn)
            {
                headerRow.CreateCell(i).SetCellValue(hc.Value);
                i++;
            }
            // 行索引号
            int rowIndex = 1;
            var properties = typeof(T).GetProperties().ToList();
            // 写出数据
            foreach (var item in list)
            {
                IRow ir = sheet.CreateRow(rowIndex);

                i = -1;
                foreach (var hc in headerColumn)
                {
                    i++;
                    if (!properties.Exists(p => p.Name == hc.Key))
                        continue;
                    var prop = properties.Find(p => p.Name == hc.Key);
                    switch (prop.PropertyType.ToString())
                    {
                        case "System.String":
                        default:
                            ir.CreateCell(i).SetCellValue(prop.GetValue(item, null).AsNotNullString());
                            break;

                        case "System.Int16":
                        case "System.Int32":
                        case "System.Int64":
                        case "System.Decimal":
                        case "System.Double":
                            ir.CreateCell(i).SetCellValue(prop.GetValue(item, null).AsDouble(0));
                            break;
                    }
                }
                rowIndex++;
            }

            workbook.Write(ms);
            byte[] data = ms.ToArray();

            ms.Flush();
            ms.Close();

            fs.Write(data, 0, data.Length);
            fs.Flush();
            fs.Close();
        }

        #endregion Excel


        #endregion 导出

        #region 导入


        /// <summary>
        /// 加载Excel数据
        /// </summary>
        /// <param name="fileName">Excel文件路径</param>
        /// <param name="sheetName">加载的工作簿名称</param>
        /// <param name="excelColumn">填充的数据模板样式</param>
        /// <param name="existsErrorData">是否存在错误数据</param>
        /// <returns>数据表</returns>
        public static DataTable LoadData(string fileName, string sheetName, List<ExcelColumn> excelColumn, out bool existsErrorData)
        {
            DataTable dt = CreateTable(excelColumn);
            Dictionary<int, string> errorDict = new Dictionary<int, string>();

            using (FileStream fileStream = File.OpenRead(fileName))
            {
                HSSFWorkbook workBook = new HSSFWorkbook(fileStream);
                HSSFSheet sheet = (HSSFSheet)workBook.GetSheet(sheetName);
                if (sheet != null && sheet.LastRowNum > 1)
                {
                    HSSFRow headerRow = (HSSFRow)sheet.GetRow(1);
                    if (headerRow == null)
                    {
                        throw new Exception("Excel不符合系统预设的模板定义,请通过程序生成的模板文件导入数据");
                    }

                    Dictionary<string, int> colDict = new Dictionary<string, int>();
                    foreach (DataColumn col in dt.Columns)
                    {
                        if (headerRow.Cells.Exists(h => h.StringCellValue.Trim().Equals(col.Caption)))
                        {
                            HSSFCell hearderCell = (HSSFCell)headerRow.Cells.Find(h => h.StringCellValue.Trim().Equals(col.Caption));
                            colDict.Add(col.ColumnName, hearderCell.ColumnIndex);
                        }
                    }

                    if (colDict.Count != dt.Columns.Count)
                    {
                        throw new Exception("Excel不符合系统预设的模板定义,请通过程序生成的模板文件导入数据");
                    }

                    for (int rowIndex = 2; rowIndex <= sheet.LastRowNum; rowIndex++)
                    {
                        HSSFRow bodyRow = (HSSFRow)sheet.GetRow(rowIndex);
                        if (bodyRow == null)
                            continue;
                        bool isError = false;
                        DataRow dataRow = dt.NewRow();
                        foreach (var colKey in colDict)
                        {
                            HSSFCell cell = (HSSFCell)bodyRow.GetCell(colKey.Value);
                            var column = dt.Columns[colKey.Key];
                            if (cell == null)
                            {
                                if (column.AllowDBNull)
                                {
                                    dataRow[colKey.Key] = DBNull.Value;
                                    continue;
                                }
                                else
                                {
                                    if (excelColumn.Find(t => t.Name == colKey.Key).AllowDefault)
                                    {
                                        dataRow[colKey.Key] = excelColumn.Find(t => t.Name == colKey.Key).DefaultValue;
                                        continue;
                                    }
                                    else
                                    {
                                        isError = true;
                                        errorDict.Add(bodyRow.RowNum, "【" + column.Caption + "】 数据不能为空");
                                        break;
                                    }
                                }
                            }
                            object value = null;
                            try
                            {
                                Type columnType = column.DataType;
                                if (columnType == typeof(bool))
                                {
                                    if (cell.CellType == NPOI.SS.UserModel.CellType.Boolean)
                                        value = cell.BooleanCellValue;
                                    else
                                       if (cell.CellType == NPOI.SS.UserModel.CellType.Numeric)
                                    {
                                        value = cell.NumericCellValue > 0;
                                    }
                                }
                                else
                                if (columnType == typeof(DateTime))
                                    value = cell.DateCellValue;
                                else
                                if ((columnType == typeof(int) || columnType == typeof(float) || columnType == typeof(double)
                                    || columnType == typeof(decimal) || columnType == typeof(long) || columnType == typeof(short))
                                    && cell.CellType == NPOI.SS.UserModel.CellType.Numeric)
                                    value = cell.NumericCellValue;
                                else
                                if (columnType == typeof(string) && cell.CellType == NPOI.SS.UserModel.CellType.String)
                                    value = cell.StringCellValue;
                                else
                                    value = Convert.ChangeType(cell.ToString(), column.DataType);
                            }
                            catch
                            {
                                if (column.AllowDBNull)
                                    value = DBNull.Value;
                                else
                                {
                                    errorDict.Add(bodyRow.RowNum, "【" + column.Caption + "】 数据类型与系统指定【" + column.DataType.ToString() + "】不一致,不能相互转换");
                                    isError = true;
                                    break;
                                }
                            }
                            dataRow[colKey.Key] = value;
                        }
                        if (!isError)
                            dt.Rows.Add(dataRow);
                    }
                }
            }
            existsErrorData = errorDict.Count > 0;
            if (existsErrorData)
            {
                WriteErrorInfo(fileName, errorDict);
            }
            return dt;
        }

        /// <summary>
        /// 在原excel模板文件添加错误日志信息
        /// </summary>
        /// <param name="fileName">Excel模板文件路径</param>
        /// <param name="errorDict">错误日志信息</param>
        private static void WriteErrorInfo(string fileName, Dictionary<int, string> errorDict)
        {
            FileStream fileStream = new FileStream(fileName, FileMode.Open);
            HSSFWorkbook workBook = new HSSFWorkbook(fileStream);
            fileStream.Close();

            HSSFSheet errorSheet = (HSSFSheet)workBook.GetSheet("错误日志");
            if (errorSheet != null)
            {
                workBook.RemoveSheetAt(workBook.GetSheetIndex(errorSheet));
                errorSheet = null;
            }

            errorSheet = (HSSFSheet)workBook.CreateSheet("错误日志");
            //添加表头
            HSSFRow errorHeader = (HSSFRow)errorSheet.CreateRow(0);
            errorHeader.CreateCell(0).SetCellValue("错误行号");
            errorHeader.CreateCell(1).SetCellValue("原因");
            int rowIndex = 1;
            foreach (var errorKey in errorDict)
            {
                HSSFRow errorRow = (HSSFRow)errorSheet.CreateRow(rowIndex);
                errorRow.CreateCell(0).SetCellValue(errorKey.Key);
                errorRow.CreateCell(1).SetCellValue(errorKey.Value);
                rowIndex++;
            }

            using (FileStream writeStream = new FileStream(fileName, FileMode.Create))
            {
                workBook.Write(writeStream);
            }
        }

        /// <summary>
        /// 通过模板单元信息创建数据表格
        /// </summary>
        /// <param name="excelColumns"></param>
        /// <returns></returns>
        private static DataTable CreateTable(List<ExcelColumn> excelColumns)
        {
            DataTable data = new DataTable();
            foreach (var templateCell in excelColumns)
            {
                data.Columns.Add(new DataColumn { ColumnName = templateCell.Name, AllowDBNull = templateCell.AllowNull, Caption = templateCell.Header, DataType = templateCell.DataType });
            }
            return data;
        }


        #endregion 导入
    }

    /// <summary>
    /// Excel模板列
    /// </summary>
    public class ExcelColumn
    {
        private bool _AllowNull = true;
        private Type _DataType = typeof(string);
        private bool _AllowDefault = false;

        /// <summary>
        /// 标题
        /// </summary>
        public string Header { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 是否允许空值
        /// </summary>
        public bool AllowNull
        {
            get { return _AllowNull; }
            set { _AllowNull = value; }
        }

        /// <summary>
        /// 数据类型
        /// </summary>
        public Type DataType
        {
            get { return _DataType; }
            set { _DataType = value; }
        }

        /// <summary>
        /// 默认值
        /// </summary>
        public object DefaultValue { get; set; }

        /// <summary>
        /// 是否允许系统默认
        /// </summary>
        public bool AllowDefault
        {
            get { return _AllowDefault; }
            set { _AllowDefault = value; }
        }
    }

    /// <summary>
    /// 导入事件参数
    /// </summary>
    public class ExcelImportEventArgs : EventArgs
    {
        private BackgroundWorker m_bgk = null;

        /// <summary>
        /// 上传的数据
        /// </summary>
        public DataTable Data { get; private set; }

        /// <summary>
        /// 报告进度
        /// </summary>
        /// <param name="percentProgress">百分比 值为0-100</param>
        public void ReportProgress(int percentProgress)
        {
            if (m_bgk == null || !m_bgk.WorkerReportsProgress) return;
            m_bgk.ReportProgress(percentProgress);
        }

        public ExcelImportEventArgs(BackgroundWorker bgk, DataTable data)
        {
            m_bgk = bgk;
            this.Data = data;
        }
    }
}