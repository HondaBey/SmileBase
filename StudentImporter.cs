using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SmileBase
{
    public class StudentImporter
    {

        public void ImportToEntities()
        {
            // Open Excel File
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            var workbook = excelApp.Workbooks.Open(@"C:\temp\smileStudents2.xlsx");
            var sheet = workbook.Sheets[1];
            var range = sheet.UsedRange;
            try
            {
                var rowCount = range.Rows.Count;
                var columnCount = range.Columns.Count;
                var matrix = new string[rowCount, columnCount];
                // Iterate
                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        if (j == 1)
                        {
                            matrix[i, j] = (range.Cells[i, j].Value2.ToString());
                        }
                    }
                }
            }
            finally
            {
                //cleanup
                GC.Collect();
                GC.WaitForPendingFinalizers();

                //rule of thumb for releasing com objects:
                //  never use two dots, all COM objects must be referenced and released individually
                //  ex: [somthing].[something].[something] is bad

                //release com objects to fully kill excel process from running in the background
                Marshal.ReleaseComObject(range);
                Marshal.ReleaseComObject(sheet);

                //close and release
                workbook.Close();
                Marshal.ReleaseComObject(workbook);

                //quit and release
                excelApp.Quit();
                Marshal.ReleaseComObject(excelApp);
            }
            // Map each column to the appropriate Property in Studen Classe

            // Save
        }


    }
}
