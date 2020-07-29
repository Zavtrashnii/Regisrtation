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
    public partial class AddStr : Form
    {
        string name;
        int id;
        int region;
        internal List<string> regionBox = new List<string>();

        public AddStr()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=pp;password=root;");
            conn.Open();
            
            string sql = "select * from regions";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader[1].ToString());
                regionBox.Add(reader[1].ToString());
            };

            reader.Close();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            name = NameTextBox.Text;

            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=pp;password=root;");
            conn.Open();

            MySqlCommand id_str = new MySqlCommand("select max(id_street) from streets", conn);
            MySqlDataReader readerStr = id_str.ExecuteReader();
            readerStr.Read();
            id = Convert.ToInt32(readerStr["max(id_street)"].ToString()) + 1;
            readerStr.Close();

            MySqlCommand id_reg = new MySqlCommand("select id_reg from regions where name_reg = @name_reg", conn);
            id_reg.Parameters.Add("@name_reg", MySqlDbType.Text).Value = comboBox1.SelectedItem.ToString();
            MySqlDataReader readerReg = id_reg.ExecuteReader();
            readerReg.Read();
            region = Convert.ToInt32(readerReg["id_reg"].ToString());
            readerReg.Close();
            conn.Close();

            string cmd = $"insert into streets value ({id}, {region}, '{name}')";
            MySqlCommand command = new MySqlCommand(cmd, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            Close();
        }
    }
}
