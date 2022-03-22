using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSystem_WinformDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtName.Text =="admin"  && txtPassword.Text == "admin")
            {
                MessageBox.Show("correct");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPassword.Clear();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
