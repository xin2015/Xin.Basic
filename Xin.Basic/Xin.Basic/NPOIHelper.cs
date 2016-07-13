using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xin.Basic
{
    public class NPOIHelper
    {
        public static void Export()
        {
            IWorkbook wb = new XSSFWorkbook();
            ISheet s1 = wb.CreateSheet("Sheet1");
            ICellStyle style = wb.CreateCellStyle();
            style.Alignment = HorizontalAlignment.Center;
            style.VerticalAlignment = VerticalAlignment.Center;
            style.WrapText = true;
            style.BorderTop = BorderStyle.Thin;
            style.BorderRight = BorderStyle.Thin;
            style.BorderBottom = BorderStyle.Thin;
            style.BorderLeft = BorderStyle.Thin;
            ICellStyle thStyle = wb.CreateCellStyle();
            thStyle.CloneStyleFrom(style);


            IRow row = s1.CreateRow(0);
            ICell cell = row.CreateCell(0);
            cell.SetCellValue(string.Format("时间：{0}", DateTime.Today.ToString("yyyy年MM月dd日")));
            cell.CellStyle = thStyle;
            s1.AddMergedRegion(new CellRangeAddress(0, 0, 0, 20));

            row = s1.CreateRow(1);
            cell = row.CreateCell(0);
            cell.SetCellValue("城市名称");
            cell.CellStyle = thStyle;
            s1.AddMergedRegion(new CellRangeAddress(1, 4, 0, 0));
            cell = row.CreateCell(1);
            cell.SetCellValue("监测点位名称");
            cell.CellStyle = thStyle;
            s1.AddMergedRegion(new CellRangeAddress(1, 4, 1, 1));
            cell = row.CreateCell(2);
            cell.SetCellValue("污染物浓度及空气质量分指数（IAQI）");
            cell.CellStyle = thStyle;
            s1.AddMergedRegion(new CellRangeAddress(1, 1, 2, 15));
            cell = row.CreateCell(16);
            cell.SetCellValue("空气质量指数（AQI）");
            cell.CellStyle = thStyle;
            s1.AddMergedRegion(new CellRangeAddress(1, 4, 16, 16));
            cell = row.CreateCell(17);
            cell.SetCellValue("首要污染物");
            cell.CellStyle = thStyle;
            s1.AddMergedRegion(new CellRangeAddress(1, 4, 17, 17));
            cell = row.CreateCell(18);
            cell.SetCellValue("空气质量指数级别");
            cell.CellStyle = thStyle;
            s1.AddMergedRegion(new CellRangeAddress(1, 4, 18, 18));
            cell = row.CreateCell(19);
            cell.SetCellValue("空气质量指数类别");
            cell.CellStyle = thStyle;
            s1.AddMergedRegion(new CellRangeAddress(1, 2, 19, 20));

            row = s1.CreateRow(2);
            cell = row.CreateCell(2);
            cell.SetCellValue("二氧化硫（SO<sub>2</sub>）24小时平均");
            cell.CellStyle = thStyle;
            s1.AddMergedRegion(new CellRangeAddress(2, 3, 2, 3));
            cell = row.CreateCell(4);
            cell.SetCellValue("二氧化氮（NO<sub>2</sub>）24小时平均");
            cell.CellStyle = thStyle;
            s1.AddMergedRegion(new CellRangeAddress(2, 3, 4, 5));
            cell = row.CreateCell(6);
            cell.SetCellValue("颗粒物（粒径小于等于10μm）24小时平均");
            cell.CellStyle = thStyle;
            s1.AddMergedRegion(new CellRangeAddress(2, 3, 6, 7));
            cell = row.CreateCell(8);
            cell.SetCellValue("一氧化碳（CO）24小时平均");
            cell.CellStyle = thStyle;
            s1.AddMergedRegion(new CellRangeAddress(2, 3, 8, 9));
            cell = row.CreateCell(10);
            cell.SetCellValue("臭氧（O<sub>3</sub>）最大1小时平均");
            cell.CellStyle = thStyle;
            s1.AddMergedRegion(new CellRangeAddress(2, 3, 10, 11));
            cell = row.CreateCell(12);
            cell.SetCellValue("臭氧（O<sub>3</sub>）最大8小时滑动平均");
            cell.CellStyle = thStyle;
            s1.AddMergedRegion(new CellRangeAddress(2, 3, 12, 13));
            cell = row.CreateCell(14);
            cell.SetCellValue("颗粒物（粒径小于等于2.5μm）24小时平均");
            cell.CellStyle = thStyle;
            s1.AddMergedRegion(new CellRangeAddress(2, 3, 14, 15));

            row = s1.CreateRow(3);
            cell = row.CreateCell(19);
            cell.SetCellValue("类别");
            cell.CellStyle = thStyle;
            s1.AddMergedRegion(new CellRangeAddress(3, 4, 19, 19));
            cell = row.CreateCell(20);
            cell.SetCellValue("颜色");
            cell.CellStyle = thStyle;
            s1.AddMergedRegion(new CellRangeAddress(3, 4, 20, 20));

            row = s1.CreateRow(4);
            int colNum = 2;
            row.CreateCell(colNum).SetCellValue("浓度 /（μg / m³）");
            row.GetCell(colNum++).CellStyle = thStyle;
            row.CreateCell(colNum).SetCellValue("分指数");
            row.GetCell(colNum++).CellStyle = thStyle;
            row.CreateCell(colNum).SetCellValue("浓度 /（μg / m³）");
            row.GetCell(colNum++).CellStyle = thStyle;
            row.CreateCell(colNum).SetCellValue("分指数");
            row.GetCell(colNum++).CellStyle = thStyle;
            row.CreateCell(colNum).SetCellValue("浓度 /（μg / m³）");
            row.GetCell(colNum++).CellStyle = thStyle;
            row.CreateCell(colNum).SetCellValue("分指数");
            row.GetCell(colNum++).CellStyle = thStyle;
            row.CreateCell(colNum).SetCellValue("浓度 /（mg / m³）");
            row.GetCell(colNum++).CellStyle = thStyle;
            row.CreateCell(colNum).SetCellValue("分指数");
            row.GetCell(colNum++).CellStyle = thStyle;
            row.CreateCell(colNum).SetCellValue("浓度 /（μg / m³）");
            row.GetCell(colNum++).CellStyle = thStyle;
            row.CreateCell(colNum).SetCellValue("分指数");
            row.GetCell(colNum++).CellStyle = thStyle;
            row.CreateCell(colNum).SetCellValue("浓度 /（μg / m³）");
            row.GetCell(colNum++).CellStyle = thStyle;
            row.CreateCell(colNum).SetCellValue("分指数");
            row.GetCell(colNum++).CellStyle = thStyle;
            row.CreateCell(colNum).SetCellValue("浓度 /（μg / m³）");
            row.GetCell(colNum++).CellStyle = thStyle;
            row.CreateCell(colNum).SetCellValue("分指数");
            row.GetCell(colNum).CellStyle = thStyle;

            FileStream fs = File.Create("test.xlsx");
            wb.Write(fs);
            fs.Close();
        }

        //public static MemoryStream ExportDayAQIReport(List<DayAQIReport> list, string path)
        //{
        //    IWorkbook workbook = new XSSFWorkbook(path);
        //    ISheet sheet = workbook.GetSheetAt(0);
        //    ICellStyle cellStyle = workbook.CreateCellStyle();
        //    cellStyle.Alignment = HorizontalAlignment.Center;
        //    cellStyle.VerticalAlignment = VerticalAlignment.Center;
        //    IFont font = sheet.Workbook.CreateFont();
        //    font.FontHeight = 14;
        //    font.FontName = "宋体";
        //    cellStyle.SetFont(font);

        //    int rowNum = 5, colNum = 0;
        //    list.ForEach(o =>
        //    {
        //        colNum = 0;
        //        IRow row = sheet.CreateRow(rowNum++);
        //        ICell cell = row.CreateCell(colNum++);
        //        cell.SetCellValue("广州市");
        //        cell.CellStyle = cellStyle;
        //        cell = row.CreateCell(colNum++);
        //        cell.SetCellValue("未知点位");
        //        cell.CellStyle = cellStyle;
        //        cell = row.CreateCell(colNum++);
        //        cell.SetCellValue(o.SO2.ToString());
        //        cell.CellStyle = cellStyle;
        //        cell = row.CreateCell(colNum++);
        //        cell.SetCellValue(o.ISO2.ToString());
        //        cell.CellStyle = cellStyle;
        //        cell = row.CreateCell(colNum++);
        //        cell.SetCellValue(o.NO2.ToString());
        //        cell.CellStyle = cellStyle;
        //        cell = row.CreateCell(colNum++);
        //        cell.SetCellValue(o.INO2.ToString());
        //        cell.CellStyle = cellStyle;
        //        cell = row.CreateCell(colNum++);
        //        cell.SetCellValue(o.PM10.ToString());
        //        cell.CellStyle = cellStyle;
        //        cell = row.CreateCell(colNum++);
        //        cell.SetCellValue(o.IPM10.ToString());
        //        cell.CellStyle = cellStyle;
        //        cell = row.CreateCell(colNum++);
        //        cell.SetCellValue(o.CO.ToString());
        //        cell.CellStyle = cellStyle;
        //        cell = row.CreateCell(colNum++);
        //        cell.SetCellValue(o.ICO.ToString());
        //        cell.CellStyle = cellStyle;
        //        cell = row.CreateCell(colNum++);
        //        cell.SetCellValue(o.O3.ToString());
        //        cell.CellStyle = cellStyle;
        //        cell = row.CreateCell(colNum++);
        //        cell.SetCellValue(o.IO3.ToString());
        //        cell.CellStyle = cellStyle;
        //        cell = row.CreateCell(colNum++);
        //        cell.SetCellValue(o.O38H.ToString());
        //        cell.CellStyle = cellStyle;
        //        cell = row.CreateCell(colNum++);
        //        cell.SetCellValue(o.IO38H.ToString());
        //        cell.CellStyle = cellStyle;
        //        cell = row.CreateCell(colNum++);
        //        cell.SetCellValue(o.PM25.ToString());
        //        cell.CellStyle = cellStyle;
        //        cell = row.CreateCell(colNum++);
        //        cell.SetCellValue(o.IPM25.ToString());
        //        cell.CellStyle = cellStyle;
        //        cell = row.CreateCell(colNum++);
        //        cell.SetCellValue(o.AQI.ToString());
        //        cell.CellStyle = cellStyle;
        //        cell = row.CreateCell(colNum++);
        //        cell.SetCellValue(o.PrimaryPollutant);
        //        cell.CellStyle = cellStyle;
        //        cell = row.CreateCell(colNum++);
        //        cell.SetCellValue(o.Level);
        //        cell.CellStyle = cellStyle;
        //        cell = row.CreateCell(colNum++);
        //        cell.SetCellValue(o.Type);
        //        cell.CellStyle = cellStyle;
        //        cell = row.CreateCell(colNum++);
        //        cell.SetCellValue(o.Color);
        //        cell.CellStyle = cellStyle;
        //    });

        //    MemoryStream ms = new MemoryStream();
        //    workbook.Write(ms);
        //    return ms;
        //}

        public static MemoryStream ExportTable(Table table, string fileName, int colSplit = 0)
        {
            IWorkbook workbook = new XSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("Sheet1");
            ICellStyle style = workbook.CreateCellStyle();
            style.Alignment = HorizontalAlignment.Center;
            style.VerticalAlignment = VerticalAlignment.Center;
            IFont font = workbook.CreateFont();
            font.FontHeight = 14;
            font.FontName = "宋体";
            style.SetFont(font);
            ICellStyle thStyle = workbook.CreateCellStyle();
            thStyle.CloneStyleFrom(style);
            IFont thFont = workbook.CreateFont();
            thFont.FontHeight = 14;
            thFont.FontName = "宋体";
            thFont.IsBold = true;
            thStyle.SetFont(thFont);

            foreach (Row tr in table.Thead)
            {
                IRow row = sheet.CreateRow(tr.Index);
                foreach (Cell th in tr.Cells)
                {
                    ICell cell = row.CreateCell(th.Index);
                    cell.SetCellValue(th.Value);
                    cell.CellStyle = thStyle;
                    if (th.Rowspan > 1 || th.Colspan > 1)
                    {
                        sheet.AddMergedRegion(new CellRangeAddress(tr.Index, tr.Index + th.Rowspan - 1, th.Index, th.Index + th.Colspan - 1));
                    }
                }
            }

            foreach (Row tr in table.Tbody)
            {
                IRow row = sheet.CreateRow(tr.Index);
                foreach (Cell td in tr.Cells)
                {
                    ICell cell = row.CreateCell(td.Index);
                    cell.SetCellValue(td.Value);
                    cell.CellStyle = style;
                    if (td.Rowspan > 1 || td.Colspan > 1)
                    {
                        sheet.AddMergedRegion(new CellRangeAddress(tr.Index, tr.Index + td.Rowspan - 1, td.Index, td.Index + td.Colspan - 1));
                    }
                }
            }

            foreach (Row tr in table.Tfoot)
            {
                IRow row = sheet.CreateRow(tr.Index);
                foreach (Cell td in tr.Cells)
                {
                    ICell cell = row.CreateCell(td.Index);
                    cell.SetCellValue(td.Value);
                    cell.CellStyle = style;
                    if (td.Rowspan > 1 || td.Colspan > 1)
                    {
                        sheet.AddMergedRegion(new CellRangeAddress(tr.Index, tr.Index + td.Rowspan - 1, td.Index, td.Index + td.Colspan - 1));
                    }
                }
            }

            int colCount = 0;
            foreach (Cell th in table.Thead.First().Cells)
            {
                colCount += th.Colspan;
            }

            for (int colNum = 0; colNum < colCount; colNum++)
            {
                int width = sheet.GetColumnWidth(colNum) / 256;
                foreach (IRow row in sheet)
                {
                    ICell cell = row.GetCell(colNum);
                    if (cell != null)
                    {
                        int length = Encoding.UTF8.GetBytes(cell.StringCellValue).Length;
                        if (length > width)
                        {
                            width = length;
                        }
                    }
                }
                sheet.SetColumnWidth(colNum, width * 256);
            }

            sheet.CreateFreezePane(colSplit, table.Tbody.First().Index);

            MemoryStream ms = new MemoryStream();
            workbook.Write(ms);
            return ms;
        }
    }
}
