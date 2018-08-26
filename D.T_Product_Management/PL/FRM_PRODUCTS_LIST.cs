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
    public partial class FRM_PRODUCTS_LIST : Form
    {
        BL.CLS_PRODUCT clsPro = new BL.CLS_PRODUCT();
        public FRM_PRODUCTS_LIST()
        {
            InitializeComponent();
            DGVProducts.DataSource = clsPro.GET_ALL_PRODUCTS();
        }

        private void DGVProducts_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
