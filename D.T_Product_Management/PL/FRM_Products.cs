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
    public partial class FRM_Products : Form
    {
        BL.CLS_PRODUCT cl = new BL.CLS_PRODUCT();
        public FRM_Products()
        {
            InitializeComponent();
          this.DGV_Data.DataSource = cl.GET_ALL_PRODUCTS();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cl.SEARCH_PRODUCT(txt_Search.Text);
            this.DGV_Data.DataSource = dt;
            this.DGV_Data.Refresh();
        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.ShowDialog();
        }
    }
}
