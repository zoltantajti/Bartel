using System;
using System.IO;
using OfficeOpenXml;
using libsql;

namespace OfficeSDK
{
    public class Excel
    {
        MySQL db;
        public void SaveToExcel(string bolt)
        {
            db = new MySQL();
            CSVFile csv = new CSVFile();
            string csvString = csv.line1.Replace("{datum}", DateTime.Now.ToString().Replace('.','-'));
            csvString += csv.line2;
            csvString += csv.line3;
            csvString += csv.getTermekElad(bolt);

            string block2 = csv.line4;
            block2 += csv.getTelVetel(bolt);

            string excelFileName = @"Output_"+DateTime.Now.ToString().Replace('.','-').Replace(' ','-').Replace(':','-')+".xls";
            string worksheetsName = "TESZT";

            var format = new ExcelTextFormat();
            format.Delimiter = ';';
            format.EOL = "\r";
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(new FileInfo(excelFileName)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(worksheetsName);
                worksheet.Cells["A1"].LoadFromText(
                    csvString, 
                    format, 
                    OfficeOpenXml.Table.TableStyles.None, 
                    false
                );
                worksheet.Cells["E2"].LoadFromText(
                    block2,
                    format,
                    OfficeOpenXml.Table.TableStyles.None,
                    false
                );
                package.Save();
            };
        }
    }

    public class CSVFile
    {
        MySQL db;
        //A1-től
        public string line1 = "Kisbolt;{datum};\r";
        public string line2 = "Tétel eladás;;\r";
        public string line3 = "Típus;Ár;\r";
        public string getTermekElad(string bolt)
        {
            db = new MySQL();
            string csv = "";
            foreach (string elad in db.getEladToList("tetel_eladas", "*", "WHERE bolt='" + bolt + "' AND nap=CURRENT_DATE"))
            {
                csv += elad + "\r";
            };
            return csv;
        }
        //E2-től
        public string line4 = "Telefon vétel;Ár\r";
        public string getTelVetel(string bolt)
        {
            db = new MySQL();
            string csv = "";
            foreach (string elad in db.getTelVetelToList("telefonok", "*", "WHERE bolt='" + bolt + "' AND nap=CURRENT_DATE"))
            {
                csv += elad + "\r";
            };
            return csv;
        }
    }
}
