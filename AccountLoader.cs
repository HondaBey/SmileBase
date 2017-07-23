//using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StudentService.StudentReader;

namespace SmileBase
{
    public class AccountLoader
    {
        //public DataTable LoadXLS(string excelFilePathFull)
        //{
        //    DataTable result = new DataTable();
        //    DataTable dtSchema;
        //    string vCopyFilePath = String.Empty;

        //    var excelConnectionString = GetExcelConnectionString(excelFilePathFull);
            
        //    try
        //    {
        //        OleDbConnection excelConnection = null;
        //        excelConnection = new OleDbConnection(excelConnectionString);
        //        excelConnection.Open();
        //        dtSchema = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] {null,null,null,"TABLE"});
        //        excelConnection.Close();
        //        excelConnection.Dispose();
        //    }
        //    catch (OleDbException oleDbEx)
        //    {
        //        throw; 
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }

        //    OleDbDataAdapter dataAdapter = null;
        //    try
        //    {
        //        var sheetNames = GetSheetNames(dtSchema);
        //        for (int i = 0; i < sheetNames.Count; i++)
        //        {
        //            selectCommand.CommandText = "SELECT * FROM [" + sheetNames[i] + "]";
        //            selectCommand.Connection = connection;
        //            adapter.SelectCommand = selectCommand;
        //            DataTable Sheet = new DataTable();
        //            Sheet.TableName = sheetNames[i].Replace("$", "").Replace("'", "");
        //            adapter.Fill(Sheet);

        //            if (Sheet.Rows.Count > 0)
        //            {
        //                Records.Tables.Add(Sheet);
        //            }
        //        }
        //        foreach (var sheetName in dtSchema.)
        //        {

        //        }

        //        //  Alle Dollarzeichen aus Tabellenname entfernen.
        //        sheetName = sheetName.Replace("$", string.Empty);
        //        //  Alle einfachen Anf�hrungszeichen aus Tabellenname entfernen.
        //        sheetName = sheetName.Replace("\'", string.Empty);
        //        //  Alle Sharps durch Punkte ersetzen
        //        sheetName = sheetName.Replace("#", ".");
        //        if (sheetName.Contains("#"))
        //        {
        //            throw new Exception("Sharp not allowed in Excel Sheet Name");
        //            return result;
        //        }

        //        string selectString = "SELECT * FROM [" + (sheetName + ("$" + (pRange + "]")));
        //        dataAdapter = new OleDbDataAdapter(selectString, excelConnectionString);
        //        //  Versuch die Datei zu lesen:
        //        dataAdapter.Fill(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        result = null;
        //        Console.WriteLine(ex);
        //        throw;
        //    }
        //    finally
        //    {
        //        dataAdapter.Dispose();
        //    }

        //    return result;
        //}

        private string GetExcelConnectionString (string excelFilePathFull)
        {
            // Setup Connection string based on which excel file format we are using
            var excelType = "Excel 8.0";
            if (excelFilePathFull.EndsWith(".xlsx"))
            {
                excelType = "Excel 12.0 XML";
            }

            //  "HDR=Yes;"    indicates that the first row contains columnnames, not data
            //  "IMEX=1;"     tells the driver to always read "intermixed" data columns as text
            var vXProvider = "Microsoft.ACE.OLEDB.12.0";
            var vXMode = "Read";
            var vExtendedProperties = "\'Excel 12.0;HDR=No;IMEX=1;ReadOnly=TRUE\'";
            string excelConnectionString = String.Empty;
            excelConnectionString = ("Provider=" + (vXProvider + (";" + ("Mode=" + (vXMode + (";" + ("Data Source=" + (excelFilePathFull + (";" + ("Extended Properties=" + vExtendedProperties))))))))));
            return excelConnectionString;
        }

        public DataSet ExcelToDataSet(StudentImport student)
        {
            var excelFilePathFull = GetExcelSheetFullPath(student.CustomerNo);

            return ExcelToDataSet(excelFilePathFull);
        }
        public string GetExcelSheetFullPath(int customerNo)
        {
            var basePath = @"D:\smileDb\Students\";
            var dirs = Directory.GetDirectories(basePath);
            var dir = dirs.FirstOrDefault(d => d.StartsWith($"{basePath}{customerNo.ToString()}_"));
            if (dir == null)
                return $"Path for Customer {customerNo} not found !";

            var filePaths = Directory.GetFiles(dir);
            var filePath = filePaths.FirstOrDefault(f=>f.Contains("Termin-Saldenliste") && f.EndsWith(".xlsx"));
            if (filePath == null)
                return $"Balance-File not found in Directory {dir}";

            return filePath;
        }
        public DataSet ExcelToDataSet(string excelFilePathFull)
        {
            if(excelFilePathFull.Contains("not found"))
            {

                return null;
            }
            var dataSet = new DataSet(excelFilePathFull);

            var connectionString = GetExcelConnectionString(excelFilePathFull);

            // Create a connection to the excel file
            using (var oleDbConnection = new OleDbConnection(connectionString))
            {
                // Get the excel's sheet names
                oleDbConnection.Open();
                var schemaDataTable = (DataTable)oleDbConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                oleDbConnection.Close();
                var sheetsName = GetSheetNames(schemaDataTable);

                // For each sheet name 
                OleDbCommand selectCommand = null;
                for (var i = 0; i < sheetsName.Count; i++)
                {
                    // Setup select command
                    selectCommand = new OleDbCommand();
                    selectCommand.CommandText = "SELECT * FROM [" + sheetsName[i] + "]";
                    selectCommand.Connection = oleDbConnection;

                    // Get the data from the sheet
                    oleDbConnection.Open();
                    using (var oleDbDataReader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        // Convert data to DataTable
                        var dataTable = new DataTable(sheetsName[i].Replace("$", string.Empty).Replace("'", string.Empty));
                        dataTable.Load(oleDbDataReader);

                        // Add to Dataset
                        dataSet.Tables.Add(dataTable);
                    }
                }

                return dataSet;
            }
        }

        private List<string> GetSheetNames(DataTable schemaDataTable)
        {
            var sheets = new List<string>();
            foreach (var dataRow in schemaDataTable.AsEnumerable())
            {
                sheets.Add(dataRow.ItemArray[2].ToString());
            }

            return sheets;
        }
    }
}
