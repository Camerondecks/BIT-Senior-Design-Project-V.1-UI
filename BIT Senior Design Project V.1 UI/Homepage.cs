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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerInformation F2 = new CustomerInformation();
            F2.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Inventory F2 = new Inventory();
            F2.Show();
        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            Materials F2 = new Materials();
            F2.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Sales F2 = new Sales();
            F2.Show();
        }
    }
}
