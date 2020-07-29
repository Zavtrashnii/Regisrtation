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
    public partial class connectionStringForm : Form
    {
        public connectionStringForm()
        {
            InitializeComponent();
        }

        public static string connectionString = "server = localhost; username = root; password = root; database = pp";

        private void saveButton_Click(object sender, EventArgs e)
        {
            connectionString = textConnect.Text;
            Close();
        }
    }
}
