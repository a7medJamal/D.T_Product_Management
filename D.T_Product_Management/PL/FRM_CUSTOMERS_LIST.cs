using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D.T_Product_Management.PL
{
    public partial class FRM_CUSTOMERS_LIST : Form
    {
        BL.CLS_CUSTOMERS cust = new BL.CLS_CUSTOMERS();
        public FRM_CUSTOMERS_LIST()
        {
            InitializeComponent();

            DGVCustomers.DataSource = cust.Select_customers();
            this.DGVCustomers.Columns[0].Visible = false;
            this.DGVCustomers.Columns[5].Visible = false;
        }

        private void DGVCustomers_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
