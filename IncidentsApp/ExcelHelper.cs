using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace IncidentsApp
{
    internal class ExcelHelper
    {
        private ExcelPackage package;
        private ExcelWorksheet worksheet;

        public ExcelWorksheet getCurrentWorksheet() { return worksheet; }   

        public List<Incident> getIncidentsList()
        {
            List<Incident> incidents = new List<Incident>();

            int colCount = worksheet.Dimension.End.Column;
            int rowCount = worksheet.Dimension.End.Row;

            for (int row = 2; row <= rowCount; row++)
            {
                Incident inc = new Incident(row);

                for (int col = 2; col <= 36; col++)
                {
                    inc.parameters.Add(Double.Parse(worksheet.Cells[row, col].Value.ToString()));
                }

                incidents.Add(inc);
            }

            return incidents;
        }

        public void setupExcelPackage(FileInfo file)
        {
            package = new ExcelPackage(file);
        }

        public void saveDataToFile()
        {
            worksheet.Tables.Delete(0);
            package.Save();
        }

        public void saveDataToNewFile(string filename)
        {
            worksheet.Tables.Delete(0);
            package.SaveAs(new FileInfo(filename));
        }

        public void writeDataToWorksheet(List<Incident> incidents)
        {
            int colCount = worksheet.Dimension.End.Column + 1;
            int rowCount = worksheet.Dimension.End.Row;

            worksheet.Cells[1, 37].Value = "Priority";
            worksheet.Cells[1, 1].CopyStyles(worksheet.Cells[1, 1]);
            worksheet.Cells[1, 37].StyleID = worksheet.Cells[1, 36].StyleID;

            for (int row = 2; row <= rowCount; row++)
            {
                worksheet.Cells[row, 37].Value = incidents[row - 2].priority;
            }

            worksheet.Cells[1, 37, rowCount, 37].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            worksheet.Cells[1, 37, rowCount, 37].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            worksheet.Cells[1, 37, rowCount, 37].Style.Border.Left.Style = ExcelBorderStyle.Thin;
            worksheet.Cells[1, 37, rowCount, 37].Style.Border.Right.Style = ExcelBorderStyle.Thin;
            worksheet.Cells[1, 37, rowCount, 37].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
        }

        private ExcelTable getTableFromWorksheet(ExcelWorksheet worksheet, ExcelCellAddress startCell, ExcelCellAddress endCell)
        {
            if (worksheet.Tables.Count > 0 )
            {
                worksheet.Tables.Delete(0);
            }
            ExcelRange range = worksheet.Cells[startCell.Row, startCell.Column, endCell.Row, endCell.Column];
            ExcelTable excelTable = worksheet.Tables.Add(range, "table");

            return excelTable;
        }

        public DataTable readTableFromExcel()
        {
            DataTable table = new DataTable();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            worksheet = package.Workbook.Worksheets[0];

            ExcelCellAddress startCell = worksheet.Dimension.Start;
            ExcelCellAddress endCell = worksheet.Dimension.End;

            ProgressBarForm pbf = new ProgressBarForm(endCell.Row);
            pbf.Show(); 

            for (int i = 2; i <= endCell.Row; i++)
            {
                try
                {
                    worksheet.Cells[i, 1].Value = DateTime.FromOADate(Double.Parse(worksheet.Cells[i, 1].Value.ToString()));
                }
                catch (Exception ex) { }

                pbf.performStep();
            }

            pbf.Close();

            table = getTableFromWorksheet(worksheet, startCell, endCell).ToDataTable();

            return table;
        }

        public void clearData()
        {
            worksheet.Dispose();
            package.Dispose();
            worksheet = null;
            package = null;
        }
    }
}
