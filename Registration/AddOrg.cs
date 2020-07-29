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

namespace Registration
{
    public partial class AddOrg : Form
    {
        int id;
        string name;
        string INN;
        string dataRegOrg;
        string commis;
        string mail;
        string phone;
        int region;
        int str;
        internal List<string> regionBox = new List<string>();
        string NbrStr;
        int idAcc;
        string date;

        public AddOrg()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            string connStr = "server=localhost;user=root;database=pp;password=root;";
            // создаём объект для подключения к БД
            MySqlConnection conn = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();
            // запрос
            string sql = "select * from regions";
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql, conn);
            // объект для чтения ответа сервера
            MySqlDataReader reader = command.ExecuteReader();
            // читаем результат

            while (reader.Read())
            {
                comboBox1.Items.Add(reader[1].ToString());
                regionBox.Add(reader[1].ToString());
            };
            reader.Close();

            conn.Close();
        }

        private void comboBox1_Changed(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            string textBoxList = comboBox1.Text;
            int i;
            for (i = 0; textBoxList != regionBox[i] ; i++)
            {
                // мне собсно нужно только i
            }
            i++;

            string connStr = "server=localhost;user=root;database=pp;password=root;";
            // создаём объект для подключения к БД
            MySqlConnection conn = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();
            // запрос

            string sql = $"select name_street from streets where id_region = {i}";
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql, conn);
            // объект для чтения ответа сервера
            MySqlDataReader reader = command.ExecuteReader();
            // читаем результат

            while (reader.Read())
            {
                comboBox2.Items.Add(reader[0].ToString());
            };
            reader.Close();

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Database database = new Database();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                date = DateTime.Today.ToString("d");
                name = NameTextBox.Text;
                INN = INNtextBox.Text;
                dataRegOrg = DataRegOrgTextBox.Text;
                commis = CommisTextBox.Text;
                mail = MailTextBox.Text;
                phone = PhoneTextBox.Text;
                NbrStr = NmbStrTextBox.Text;

                MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=pp;password=root;");
                conn.Open();

                MySqlCommand id_reg = new MySqlCommand("select id_reg from regions where name_reg = @name_reg", conn);
                id_reg.Parameters.Add("@name_reg", MySqlDbType.Text).Value = comboBox1.SelectedItem.ToString();
                MySqlDataReader reader1 = id_reg.ExecuteReader();
                reader1.Read();
                region = Convert.ToInt32(reader1["id_reg"].ToString());
                reader1.Close();

                MySqlCommand id_str = new MySqlCommand("select id_street from streets where name_street = @name_street", conn);
                id_str.Parameters.Add("@name_street", MySqlDbType.Text).Value = comboBox2.SelectedItem.ToString();
                MySqlDataReader reader2 = id_str.ExecuteReader();
                reader2.Read();
                str = Convert.ToInt32(reader2["id_street"].ToString());
                reader2.Close();

                MySqlCommand id_org = new MySqlCommand("select max(id_org) from organizations", conn);
                MySqlDataReader reader3 = id_org.ExecuteReader();
                reader3.Read();
                id = Convert.ToInt32(reader3["max(id_org)"].ToString()) + 1; 
                reader3.Close();
                conn.Close();

                LoginForm loginForm = new LoginForm();
                if (loginForm.Helper == 1) 
                {
                    idAcc = 1;
                }
                else if (loginForm.Helper == 2) 
                {
                    idAcc = 2;
                }

                string cmd = $"insert into organizations value ({id}, '{name}', '{INN}', '{dataRegOrg}', '{commis}', '{mail}', '{phone}', {region}, {str}, '{NbrStr}', '{date}', {idAcc})";
                MySqlCommand command = new MySqlCommand(cmd, database.getConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);
                Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }
    }
}
