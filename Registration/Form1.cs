using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Registration
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            // создание элементов выпадающего меню
            ToolStripMenuItem VisionColumn = new ToolStripMenuItem("Настройка видимости столбцов");
            ToolStripMenuItem ExportExcel = new ToolStripMenuItem("Экспорт в Excel");

            // добавление элементов в меню
            contextMenuStrip1.Items.AddRange(new[] { VisionColumn, ExportExcel });

            // ассоциация контекстного меню с БД
            dataGridView1.ContextMenuStrip = contextMenuStrip1;

            // установка обработки событий
            VisionColumn.Click += VisionColumn_Click;
            ExportExcel.Click += ExportExcel_Click;

            button1.FlatStyle = FlatStyle.Flat;
            button2.FlatStyle = FlatStyle.Flat;
            button3.FlatStyle = FlatStyle.Flat;
            button4.FlatStyle = FlatStyle.Flat;
            button5.FlatStyle = FlatStyle.Flat;
            button6.FlatStyle = FlatStyle.Flat;
            button7.FlatStyle = FlatStyle.Flat;
            button8.FlatStyle = FlatStyle.Flat;
            button9.FlatStyle = FlatStyle.Flat;
            button11.FlatStyle = FlatStyle.Flat;
            OnlyOrgBtn.FlatStyle = FlatStyle.Flat;

            OnlyOrgBtn.FlatAppearance.BorderColor = Color.Blue;
            button1.FlatAppearance.BorderColor = Color.Blue;
            button2.FlatAppearance.BorderColor = Color.Blue;
            button3.FlatAppearance.BorderColor = Color.Blue;
            button4.FlatAppearance.BorderColor = Color.Blue;
            button5.FlatAppearance.BorderColor = Color.Blue;
            button6.FlatAppearance.BorderColor = Color.Blue;
            button7.FlatAppearance.BorderColor = Color.Blue;
            button8.FlatAppearance.BorderColor = Color.Blue;
            button9.FlatAppearance.BorderColor = Color.Blue;
            button11.FlatAppearance.BorderColor = Color.Blue;
        }

        private void VisionColumn_Click(object sender, EventArgs e)
        {

        }

        private void ExportExcel_Click(object sender, EventArgs e)
        {
            Excel.Application ExcelApp = new Excel.Application();
            Excel.Workbook ExcelWorkBook;
            Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            //присвоение первым ячейкам имена столбцов

            for (int i = 1; i < dataGridView1.Columns.Count; i++)
            {
                ExcelApp.Cells[1, i] = dataGridView1.Columns[i].HeaderText.ToString();
            }

            for  (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        { 

        }

        private void OnlyOrgBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
