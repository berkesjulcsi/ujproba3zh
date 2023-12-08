using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ujproba3zh.Models;

using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace ujproba3zh
{
    public partial class Excel_UC : UserControl
    {
        TelefonContext telefonContext = new TelefonContext();

        Excel.Application xlApp; // A Microsoft Excel alkalmazás
        Excel.Workbook xlWB;     // A létrehozott munkafüzet
        Excel.Worksheet xlSheet; // Munkalap a munkafüzeten belül
        public Excel_UC()
        {
            InitializeComponent();
        }

        private void excelgen_Click(object sender, EventArgs e)
        {
            try
            {
                // Excel elindítása és az applikáció objektum betöltése
                xlApp = new Excel.Application();

                // Új munkafüzet
                xlWB = xlApp.Workbooks.Add(Missing.Value);

                // Új munkalap
                xlSheet = xlWB.ActiveSheet;

                // Tábla létrehozása
                TáblaKészítés(); // Ennek megírása a következő feladatrészben következik

                // Control átadása a felhasználónak
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex) // Hibakezelés a beépített hibaüzenettel
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                // Hiba esetén az Excel applikáció bezárása automatikusan
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }
        private void TáblaKészítés()
        {
            string[] fejlécek = new string[]
            {
                "Név",
                "Szülidő",
                "Telszám",
                "Email",
                "CsomaID",
                "BővíthetőE"
            };
            for (int i = 0; i < fejlécek.Length; i++)
            {
                xlSheet.Cells[1, i + 1] = fejlécek[i];
            }

            var adatok = telefonContext.Ügyfeleks.ToList();

            object[,] adatTömb = new object[adatok.Count(), fejlécek.Count()];
            for (int i = 0; i < adatok.Count(); i++)
            {
                adatTömb[i, 0] = adatok[i].Név;
                adatTömb[i, 1] = adatok[i].SzülIdő;
                adatTömb[i, 2] = adatok[i].TelSzám;
                adatTömb[i, 3] = adatok[i].Email;
                adatTömb[i, 4] = adatok[i].CsomagId;
                adatTömb[i, 5] = adatok[i].BővíthetőE;

            }
            int sorokSzáma = adatTömb.GetLength(0);
            int oszlopokSzáma = adatTömb.GetLength(1);

            Excel.Range adatRange = xlSheet.get_Range("A2", Type.Missing).get_Resize(sorokSzáma, oszlopokSzáma);
            adatRange.Value2 = adatTömb;

            adatRange.Columns.AutoFit();

            Excel.Range fejllécRange = xlSheet.get_Range("A1", Type.Missing).get_Resize(1, 6);
            fejllécRange.Font.Bold = true;

        }

        private void diagramgen_Click(object sender, EventArgs e)
        {
            // Start Excel and get Application object.
            var excelApp = new Excel.Application();
            excelApp.Visible = true;

            // Create a new, empty workbook and add a worksheet.
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

            // Add data to cells of the first worksheet in the new workbook.
            worksheet.Cells[1, "A"] = "Data Set";
            worksheet.Cells[1, "B"] = "Value";
            worksheet.Cells[2, "A"] = "Point 1";
            worksheet.Cells[2, "B"] = 10;
            worksheet.Cells[3, "A"] = "Point 2";
            worksheet.Cells[3, "B"] = 20;
            worksheet.Cells[4, "A"] = "Point 3";
            worksheet.Cells[4, "B"] = 30;
            worksheet.Cells[5, "A"] = "Point 4";
            worksheet.Cells[5, "B"] = 40;

            // Create a range for the data.
            Excel.Range chartRange = worksheet.get_Range("A1", "B5");

            // Add a chart to the worksheet.
            Excel.ChartObjects xlCharts = (Excel.ChartObjects)worksheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = xlCharts.Add(10, 80, 300, 250);
            Excel.Chart chartPage = myChart.Chart;

            // Set chart range.
            chartPage.SetSourceData(chartRange);

            // Set chart properties.
            chartPage.ChartType = Excel.XlChartType.xlLine;
            chartPage.ChartWizard(Source: chartRange,
                Title: "Example Chart",
                CategoryTitle: "Data Set",
                ValueTitle: "Value");

            // Save the workbook and quit Excel.
            //workbook.SaveAs(@"C:\YourPath\ExcelChartExample.xlsx");
            //excelApp.Quit();
        }
    }
}
