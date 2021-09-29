using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIT_Senior_Design_Project_V._1_UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtEnterPassword.Text == "")
            {
                MessageBox.Show("Please Enter Your Password");
            }
            else if(txtEnterPassword.Text == "Admin")
            {
                Homepage F2 = new Homepage();
                F2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK);
            }

        }
    }
}
