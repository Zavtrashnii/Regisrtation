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
    public partial class LoginForm : Form
    {
        public int Helper;
        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string login = textLogin.Text;
                string password = textPass.Text;

                Database database = new Database();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * from `Accounts` WHERE `login` = @login AND `password` = @password", database.getConnection());
                MySqlCommand permission = new MySqlCommand("SELECT `id_role` FROM `Accounts` WHERE `login` = @login AND `password` = @password", database.getConnection());

                command.Parameters.Add("@login", MySqlDbType.Text).Value = login;
                command.Parameters.Add("@password", MySqlDbType.Text).Value = password;

                permission.Parameters.Add("@login", MySqlDbType.Text).Value = login;
                permission.Parameters.Add("@password", MySqlDbType.Text).Value = password;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    adapter.SelectCommand = permission;
                    adapter.Fill(table);
                    if (table.Rows[0][1].ToString() == "1")
                    {
                        Hide();
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        Helper = 1;
                    }
                    else
                    {
                        Hide();
                        WorkerForm workerForm = new WorkerForm();
                        workerForm.Show();
                        Helper = 2;
                    }
                    textLogin.Clear();
                    textPass.Clear();
                    textLogin.Select();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль.");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void loginTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                e.Handled = true;
                SelectNextControl(ActiveControl, false, true, true, true);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                buttonLogin_Click(sender, e);
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            connectionStringForm connectionStringForm = new connectionStringForm();
            connectionStringForm.Show();
        }
    }
}
