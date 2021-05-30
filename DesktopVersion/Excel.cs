using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace DesktopVersion
{
	public class Excel
	{
		private DataGridView dataGridView { get; set; }

        private Application exApp;
        private Workbook workBook;
        private Worksheet workSheet;

        public Excel(DataGridView dataGridView)
		{
            this.dataGridView = dataGridView;

            exApp = new Application();
            workBook = exApp.Workbooks.Add(System.Reflection.Missing.Value);
            workSheet = (Worksheet)workBook.Worksheets.get_Item(1);
        }
        private void CreateExcelDocument(DataGridView tabl)
        {
            List<int> excelHeader = new List<int>();
            string[] excelHeaderNumber = { "A1", "B1", "C1","D1", "E1", "F1", "G1", "H1", "I1", "J1", "K1", "L1", "M1", "N1", "O1", "P1", "Q1", "R1", "S1", "T1", "U1", "V1" , "W1" , "X1" , "Y1" , "Z1"};
            int maxhead;//проверяет самую длинную строку в столбце и если она меньше то ширина столбца будет равен заголовку + 2 если больше то ширина столбца будет равна количеству символов самой длинной строки +2 
            int[] maxColumnLeght = new int[tabl.Columns.Count];
            for (int i = 0; i < tabl.Columns.Count; i++)
            {
                for (int j = 0; j < tabl.Rows.Count; j++)
                {
                    if (tabl.Rows[j].Cells[i].Value == null) continue;
                    if (tabl.Rows[j].Cells[i].Value.ToString().Length > maxColumnLeght[i])
                    {
                        maxColumnLeght[i] = tabl.Rows[j].Cells[i].Value.ToString().Length;
                    }
                }
                if (tabl.Columns[i].HeaderText.ToString().Length > maxColumnLeght[i])
                {
                    maxhead = tabl.Columns[i].HeaderText.ToString().Length;
                }
                else
                {
                    maxhead = maxColumnLeght[i];
                }
                excelHeader.Add(Convert.ToInt32(maxhead + 2));
            }

            for (int i = 0; i < excelHeader.Count; i++)//задает размер колонок чтобы текст был виден
            {
                Range rangeWidth = workSheet.Range[excelHeaderNumber[i], System.Type.Missing];
                rangeWidth.EntireColumn.ColumnWidth = excelHeader[i];
            }

            for (int i = 1; i < tabl.ColumnCount + 1; i++)//заполняет заголовок первого столбца то есть id в основном цикле хуево работает
            {
                workSheet.Cells[1, i] = tabl.Columns[i - 1].HeaderText;
            }

            for (int i = 2; i < tabl.Rows.Count + 2; i++)//заполняет документ строками и столбцами из таблицы i-2 j-1 потому что в екселе начало с 1 а в таблице с 0 пришлось изъебываться
            {
                for (int j = 1; j < tabl.ColumnCount + 1; j++)
                {
                    workSheet.Cells[i, j] = tabl.Rows[i - 2].Cells[j - 1].Value;
                    Range rangeBord1 = workSheet.Cells[i, j];
                    rangeBord1.Font.Name = "Times New Roman";
                    rangeBord1.Font.Size = 10;
                    rangeBord1.Borders.LineStyle = XlLineStyle.xlContinuous;
                    rangeBord1.Borders.Weight = XlBorderWeight.xlThin;
                    Range rangeBJ = workSheet.Cells[i, j];
                    rangeBJ.HorizontalAlignment = Constants.xlLeft;
                }
            }

            exApp.Visible = true;
            System.Runtime.InteropServices.Marshal.ReleaseComObject(exApp);
            exApp = null;
            workBook = null;
            workSheet = null;
            GC.Collect();
        }
        public async void StartExcel()
        {
            await Task.Run(() => CreateExcelDocument(dataGridView));
        }
    }
}
