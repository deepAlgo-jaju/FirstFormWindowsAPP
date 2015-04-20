using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if(tb_user.Text=="01-133122-134"&& tb_pass.Text == "25885225")
            {
                MessageBox.Show("Welcome User");
            }
            else
            {
                MessageBox.Show("Wrong Username or/and Password");
            }
        }
    }
}
