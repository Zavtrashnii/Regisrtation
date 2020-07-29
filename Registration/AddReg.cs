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
    public partial class AddReg : Form
    {
        string name;
        int id;

        public AddReg()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                Database database = new Database();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                name = NameTextBox.Text;

                MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=pp;password=root;");
                conn.Open();

                MySqlCommand id_reg = new MySqlCommand("select max(id_reg) from regions", conn);
                MySqlDataReader reader = id_reg.ExecuteReader();
                reader.Read();
                id = Convert.ToInt32(reader["max(id_reg)"].ToString()) + 1;
                reader.Close();
                conn.Close();

                string cmd = $"insert into regions value ({id}, '{name}')";
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
