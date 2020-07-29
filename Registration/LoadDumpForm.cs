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
    public partial class LoadDumpForm : Form
    {
        public LoadDumpForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionStringForm.connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            try
                            {
                                mb.ImportFromFile(textBox1.Text);
                                MessageBox.Show("Копия загружена");
                            }
                            catch (Exception d)
                            {
                                MessageBox.Show(d.Message);
                            }
                        }
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            Close();
        }
    }
}
