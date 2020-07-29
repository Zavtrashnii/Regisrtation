using MySql.Data.MySqlClient;
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
    public partial class WorkerForm : Form
    {
        int Helper;
        public WorkerForm()
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

            Database database = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();

            command = new MySqlCommand("select * from organizations", database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
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

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                ExcelApp.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText.ToString();
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
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

        private void OnlyOrgBtn_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.organizationsTableAdapter.FillBy(this.ppDataSet.organizations);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {

        }

        //завершить работу
        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            Form loginForm = Application.OpenForms[0];
            loginForm.Close();
        }


        //сменить пользователя
        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            Close();
            Form loginForm = Application.OpenForms[0];
            loginForm.Show();
        }

        // все районы
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            if (Helper == 1)
            {
                command = new MySqlCommand("select * from organizations", database.getConnection());
            }
            else
            {
                command = new MySqlCommand("select * from streets", database.getConnection());
            }
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        // ленинский район
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            if (Helper == 1)
            {
                command = new MySqlCommand("select * from organizations where id_region = 1", database.getConnection());
            }
            else
            {
                command = new MySqlCommand("select * from streets where id_region = 1", database.getConnection());
            }
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        // октябрьский район
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            if (Helper == 1)
            {
                command = new MySqlCommand("select * from organizations where id_region = 2", database.getConnection());
            }
            else
            {
                command = new MySqlCommand("select * from streets where id_region = 2", database.getConnection());
            }
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        // кировский район
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            if (Helper == 1)
            {
                command = new MySqlCommand("select * from organizations where id_region = 3", database.getConnection());
            }
            else
            {
                command = new MySqlCommand("select * from streets where id_region = 3", database.getConnection());
            }
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        // железнодорожный район
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            if (Helper == 1)
            {
                command = new MySqlCommand("select * from organizations where id_region = 4", database.getConnection());
            }
            else
            {
                command = new MySqlCommand("select * from streets where id_region = 4", database.getConnection());
            }
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        // свердловский район
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            if (Helper == 1)
            {
                command = new MySqlCommand("select * from organizations where id_region = 5", database.getConnection());
            }
            else
            {
                command = new MySqlCommand("select * from streets where id_region = 5", database.getConnection());
            }
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        // советский район
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            if (Helper == 1)
            {
                command = new MySqlCommand("select * from organizations where id_region = 6", database.getConnection());
            }
            else
            {
                command = new MySqlCommand("select * from streets where id_region = 6", database.getConnection());
            }
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        // центральный район
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            if (Helper == 1)
            {
                command = new MySqlCommand("select * from organizations where id_region = 7", database.getConnection());
            }
            else
            {
                command = new MySqlCommand("select * from streets where id_region = 7", database.getConnection());
            }
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        // таблица организаций
        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Helper = 1;
            toolStripMenuItem1.Visible = true;
            Database database = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("select * from organizations", database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        // таблица районов
        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Helper = 2;
            toolStripMenuItem1.Visible = false;
            Database database = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("select * from regions", database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        // таблица улиц
        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Helper = 3;
            toolStripMenuItem1.Visible = true;
            Database database = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("select * from streets", database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        // сохранить БД
        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            SaveDumpForm saveDumpForm = new SaveDumpForm();
            saveDumpForm.Show();
        }

        // загрузить базу
        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            LoadDumpForm loadDumpForm = new LoadDumpForm();
            loadDumpForm.Show();
        }

        // добавить запись
        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddOrg addOrg = new AddOrg();
            addOrg.Show();
        }

        // удалить запись
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите удалить запись?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string id = dataGridView1.CurrentCell.Value.ToString();

                    Database database = new Database();
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();
                    MySqlCommand output = new MySqlCommand();

                    if (Helper == 1)
                    {
                        command = new MySqlCommand("delete from organizations where id_org = @id;", database.getConnection());
                        output = new MySqlCommand("select * from organizations", database.getConnection());
                    }
                    else if (Helper == 2)
                    {
                        command = new MySqlCommand("delete from regions where id_org = @id;", database.getConnection());
                        output = new MySqlCommand("select * from regions", database.getConnection());
                    }
                    else if (Helper == 3)
                    {
                        command = new MySqlCommand("delete from streets where id_org = @id;", database.getConnection());
                        output = new MySqlCommand("select * from streets", database.getConnection());
                    }
                    else if (Helper == 4)
                    {
                        command = new MySqlCommand("delete from accounts where id_org = @id;", database.getConnection());
                        output = new MySqlCommand("select * from accounts", database.getConnection());
                    }
                    else if (Helper == 5)
                    {
                        command = new MySqlCommand("delete from roles where id_org = @id;", database.getConnection());
                        output = new MySqlCommand("select * from roles", database.getConnection());
                    }

                    command.Parameters.Add("@id", MySqlDbType.Text).Value = id;

                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    adapter.SelectCommand = output;
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;

                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
        }

        // кнопка подтверждения пароля
        private void AcceptPasswordBtn_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "1432")
            {
                AddBtn.Visible = true;
                DeleteBtn.Visible = true;
                toolStripMenuItem16.Visible = true;
                toolStripMenuItem17.Visible = true;

                label1.Visible = false;
                AcceptPasswordBtn.Visible = false;
                PasswordTextBox.Visible = false;
            }
        }
    }
}
