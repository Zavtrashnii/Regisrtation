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
    public partial class AdminForm : Form
    {        
        int Helper;

        public AdminForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            // создание элементов выпадающего меню
            //ToolStripMenuItem VisionColumn = new ToolStripMenuItem("Настройка видимости столбцов");
            ToolStripMenuItem ExportExcel = new ToolStripMenuItem("Экспорт в Excel");

            // добавление элементов в меню
            contextMenuStrip1.Items.AddRange(new[] { /*VisionColumn,*/ ExportExcel });

            // ассоциация контекстного меню с БД
            dataGridView1.ContextMenuStrip = contextMenuStrip1;

            // установка обработки событий
            //VisionColumn.Click += VisionColumn_Click;
            ExportExcel.Click += ExportExcel_Click;            
        }

        // Открытие таблицы в Excel
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

        // Таблица организаций
        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            button1.Visible = true; label1.Visible = true; comboBox1.Visible = true;
            button2.Visible = true; label2.Visible = true; comboBox2.Visible = true;
            button3.Visible = true; label3.Visible = true; textBox1.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            Helper = 1;
            dataGridView1.Height = 522;
            dataGridView1.Location = new Point(186, 120);

            Database database = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("select * from organizations", database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            MySqlConnection conn = new MySqlConnection("server = localhost; username = root; password = root; database = pp");
            conn.Open();
            MySqlCommand command1 = new MySqlCommand("select distinct column_name from information_schema.columns where table_name = 'organizations'", conn);

            MySqlDataReader reader = command1.ExecuteReader();
            comboBox1.Items.Clear();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
            }

            reader.Close();
            conn.Close();
        }

        // Таблица районов
        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            button1.Visible = true; label1.Visible = true; comboBox1.Visible = true;
            button2.Visible = true; label2.Visible = true; comboBox2.Visible = true;
            button3.Visible = true; label3.Visible = true; textBox1.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            Helper = 2;
            dataGridView1.Height = 522;
            dataGridView1.Location = new Point(186, 120);

            Database database = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("select * from regions", database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            MySqlConnection conn = new MySqlConnection("server = localhost; username = root; password = root; database = pp");
            conn.Open();
            MySqlCommand command1 = new MySqlCommand("select distinct column_name from information_schema.columns where table_name = 'regions'", conn);

            MySqlDataReader reader = command1.ExecuteReader();
            comboBox1.Items.Clear();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
            }

            reader.Close();
            conn.Close();
        }

        // Таблица улиц
        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            button1.Visible = true; label1.Visible = true; comboBox1.Visible = true;
            button2.Visible = true; label2.Visible = true; comboBox2.Visible = true;
            button3.Visible = true; label3.Visible = true; textBox1.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            Helper = 3;
            dataGridView1.Height = 522;
            dataGridView1.Location = new Point(186, 120);

            Database database = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("select * from streets", database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            MySqlConnection conn = new MySqlConnection("server = localhost; username = root; password = root; database = pp");
            conn.Open();
            MySqlCommand command1 = new MySqlCommand("select distinct column_name from information_schema.columns where table_name = 'streets'", conn);

            MySqlDataReader reader = command1.ExecuteReader();
            comboBox1.Items.Clear();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
            }

            reader.Close();
            conn.Close();
        }

        // Таблица аккаунтов
        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            button1.Visible = false; label1.Visible = true; comboBox1.Visible = true;
            button2.Visible = false; label2.Visible = true; comboBox2.Visible = true;
            button3.Visible = true; label3.Visible = true; textBox1.Visible = true;
            button4.Visible = false;
            button5.Visible = true;
            Helper = 4;
            dataGridView1.Height = 562;
            dataGridView1.Location = new Point(186, 80); 

            Database database = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("select * from accounts", database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            MySqlConnection conn = new MySqlConnection("server = localhost; username = root; password = root; database = pp");
            conn.Open();
            MySqlCommand command1 = new MySqlCommand("select distinct column_name from information_schema.columns where table_name = 'accounts'", conn);

            MySqlDataReader reader = command1.ExecuteReader();
            comboBox1.Items.Clear();

            while (reader.Read())
            {
                 comboBox1.Items.Add(reader[0].ToString());         
            }

            reader.Close();
            conn.Close();
        }

        // Таблица ролей
        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            button1.Visible = false; label1.Visible = true; comboBox1.Visible = true;
            button2.Visible = false; label2.Visible = true; comboBox2.Visible = true;
            button3.Visible = true; label3.Visible = true; textBox1.Visible = true;
            button4.Visible = false;
            button5.Visible = true;
            Helper = 5;
            dataGridView1.Height = 562;
            dataGridView1.Location = new Point(186, 80);

            Database database = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("select * from roles", database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            MySqlConnection conn = new MySqlConnection("server = localhost; username = root; password = root; database = pp");
            conn.Open();
            MySqlCommand command1 = new MySqlCommand("select distinct column_name from information_schema.columns where table_name = 'roles'", conn);

            MySqlDataReader reader = command1.ExecuteReader();
            comboBox1.Items.Clear();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
            }

            reader.Close();
            conn.Close();
        }

        // Смена пользователя
        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            Close();
            Form loginForm = Application.OpenForms[0];
            loginForm.Show();
        }

        // Выход
        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            Form loginForm = Application.OpenForms[0];
            loginForm.Close();
        }

        // Сохранение БД
        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            SaveDumpForm saveDumpForm = new SaveDumpForm();
            saveDumpForm.Show();
        }

        // Загрузка БД
        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            LoadDumpForm loadDumpForm = new LoadDumpForm();
            loadDumpForm.Show();
        }

        // Удаление записи
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите удалить запись?", "Подтверждение", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Information, 
                MessageBoxDefaultButton.Button1, 
                MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

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
                        command = new MySqlCommand("delete from regions where id_reg = @id;", database.getConnection());
                        output = new MySqlCommand("select * from regions", database.getConnection());
                    }
                    else if (Helper == 3)
                    {
                        command = new MySqlCommand("delete from streets where id_street = @id;", database.getConnection());
                        output = new MySqlCommand("select * from streets", database.getConnection());
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

        // Добавление записи
        private void button1_Click(object sender, EventArgs e)
        {
            if (Helper == 1)
            {
                AddOrg addOrg = new AddOrg();
                addOrg.Show();
            }
            else if (Helper == 2)
            {
                AddReg addReg = new AddReg();
                addReg.Show();
            }
            else if (Helper == 3)
            {
                AddStr addStr = new AddStr();
                addStr.Show();
            }
        }

        // Фильтрация
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0 && comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
                {
                    string parameter1 = comboBox1.SelectedItem.ToString();
                    string condition = comboBox2.SelectedItem.ToString();
                    string parameter2 = textBox1.Text;
                    string TableComm = "";

                    if (Helper == 1)
                    {
                        TableComm = "organizations";
                    }
                    else if (Helper == 2)
                    {
                        TableComm = "regions";
                    }
                    else if (Helper == 3)
                    {
                        TableComm = "streets";
                    }
                    else if (Helper == 4)
                    {
                        TableComm = "accounts";
                    }
                    else if (Helper == 5)
                    {
                        TableComm = "roles";
                    }

                    string cmd = $"select * from {TableComm} where {parameter1} {condition} '{parameter2}'";
                    Database database = new Database();
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand(cmd, database.getConnection());

                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    dataGridView1.DataSource = table; 
                }
                else 
                {
                    MessageBox.Show("Введите значения для фильтра");
                }
            }
            catch (Exception a) 
            {
                MessageBox.Show(a.Message);
            }
        }

        // Обновление таблицы
        private void button4_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();

            if (Helper == 1)
            {
                command = new MySqlCommand("select * from organizations", database.getConnection());
            }
            else if (Helper == 2)
            {
                command = new MySqlCommand("select * from regions", database.getConnection());
            }
            else if (Helper == 3)
            {
                command = new MySqlCommand("select * from streets", database.getConnection());
            }
            else if (Helper == 4)
            {
                command = new MySqlCommand("select * from accounts", database.getConnection());
            }
            else if (Helper == 5)
            {
                command = new MySqlCommand("select * from roles", database.getConnection());
            }

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        // Сброс фильтра
        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = comboBox1.Items.IndexOf(0);
            comboBox2.SelectedIndex = comboBox2.Items.IndexOf(0);
            textBox1.Text = "";
            Database database = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();

            if (Helper == 1)
            {
                command = new MySqlCommand("select * from organizations", database.getConnection());
            }
            else if (Helper == 2)
            {
                command = new MySqlCommand("select * from regions", database.getConnection());
            }
            else if (Helper == 3)
            {
                command = new MySqlCommand("select * from streets", database.getConnection());
            }
            else if (Helper == 4)
            {
                command = new MySqlCommand("select * from accounts", database.getConnection());
            }
            else if (Helper == 5)
            {
                command = new MySqlCommand("select * from roles", database.getConnection());
            }

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
