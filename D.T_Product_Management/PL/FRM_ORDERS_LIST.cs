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
    public partial class FRM_ORDERS_LIST : Form
    {
        BL.CLS_ORDERS order = new BL.CLS_ORDERS();
        public FRM_ORDERS_LIST()
        {
            InitializeComponent();
            DGV_ORDERSlist.DataSource = order.SEARCH_ORDERS("");
        }

        private void FRM_ORDERS_LIST_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DGV_ORDERSlist.DataSource = order.SEARCH_ORDERS(txtSearch.Text);
            }
            catch
            {
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //this to make cursor waiting
            this.Cursor = Cursors.WaitCursor;
            //get last order
            int order_id = Convert.ToInt32(DGV_ORDERSlist.CurrentRow.Cells[0].Value);
            // form for crestal report
            RPT.rpt_Orders report = new RPT.rpt_Orders();
            RPT.FRM_PRT_PRODUCT frm = new RPT.FRM_PRT_PRODUCT();
            report.SetDataSource(order.GetOrderDetails(order_id));
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();

            //this to make cursor Default
            this.Cursor = Cursors.Default;
        }
    }
}
