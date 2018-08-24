using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using System.IO;

namespace D.T_Product_Management.PL
{
    // this form and class make single code not connect with data Acess layer
    public partial class FRM_CATEGORIES : Form
    {
        //this direct connection string
        SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-T23O7L29;Initial Catalog=dbProduct;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter da;
        DataTable dt = new DataTable ();

        //this for make direct connection to data
        BindingManagerBase bmb;

        //this for edit ,add ,delete
        SqlCommandBuilder cmd;

        public FRM_CATEGORIES()
        {
            InitializeComponent();

            //this for make select data from category table
            da = new SqlDataAdapter(@"select ID_CAT as 'الرقم الكودى للصنف', DESCRIPTION_CAT as 'اسم الصنف' from tbl_Categories", sqlcon);
            da.Fill(dt);
            dataGridView1.DataSource=dt;

            //copy data from data grid view to textbox
            txtID.DataBindings.Add("text",dt, "الرقم الكودى للصنف");
            txtDesc.DataBindings.Add("text", dt, "اسم الصنف");

            //this to copy data to lable
            bmb = this.BindingContext[dt];
            lblPosition.Text = (bmb.Position+1) + " / " + bmb.Count;

            //this to make add button not active
            btnAdd.Enabled = false;

        }

        private void btnExite_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;

        }

        private void btnPreview1_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            btnAdd.Enabled = true;
            btnNew.Enabled=false;

            //this to add +1 in (new)text id
            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;
            txtID.Text =id.ToString();
            txtDesc.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmd = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تم الاضافه بنجاح","الاضافه",MessageBoxButtons.OK,MessageBoxIcon.Information);
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //this to remove this item from data binding
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmd = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تم الحذف بنجاح", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //this to update this item from data binding
            bmb.EndCurrentEdit();
            cmd = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تم التعيل بنجاح", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;

        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            RPT.rpt_all_Categories myreport = new RPT.rpt_all_Categories();

            //create export options
            ExportOptions expoert = new ExportOptions();

            //create object for destination
            DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();

            PdfFormatOptions pdfformat = new PdfFormatOptions();

            //set the path of destionation
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "ملفات pdf | *.pdf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dfoptions.DiskFileName = ofd.FileName;

            }
            expoert = myreport.ExportOptions;

            expoert.ExportDestinationType = ExportDestinationType.DiskFile;

            expoert.ExportFormatType = ExportFormatType.PortableDocFormat;

            expoert.ExportFormatOptions = pdfformat;
            expoert.ExportDestinationOptions = dfoptions;

            myreport.Refresh();
            myreport.Export();
            MessageBox.Show("تم حفظ الملف بنجاح", "الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            RPT.rpt_all_Categories rpt = new RPT.rpt_all_Categories();
            RPT.FRM_PRT_PRODUCT frm = new RPT.FRM_PRT_PRODUCT();
            rpt.Refresh();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void btnSelectPrint_Click(object sender, EventArgs e)
        {
            RPT.RPT_SINGLE_CATEGORE rpt = new RPT.RPT_SINGLE_CATEGORE();
            RPT.FRM_PRT_PRODUCT frm = new RPT.FRM_PRT_PRODUCT();
            rpt.SetParameterValue("@ID",Convert.ToInt32(txtID.Text));
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();

        }

        private void btnSelectPdf_Click(object sender, EventArgs e)
        {
            RPT.RPT_SINGLE_CATEGORE myreport = new RPT.RPT_SINGLE_CATEGORE();

            //create export options
            ExportOptions expoert = new ExportOptions();

            //create object for destination
            DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();

            PdfFormatOptions pdfformat = new PdfFormatOptions();

            //set the path of destionation
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "ملفات pdf | *.pdf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dfoptions.DiskFileName =ofd.FileName;

            }


            expoert = myreport.ExportOptions;

            expoert.ExportDestinationType = ExportDestinationType.DiskFile;

            expoert.ExportFormatType = ExportFormatType.PortableDocFormat;

            expoert.ExportFormatOptions = pdfformat;
            expoert.ExportDestinationOptions = dfoptions;

            // set parameters
            myreport.SetParameterValue("@ID", Convert.ToInt32(txtID.Text));

            // make refresh
           // myreport.Refresh();

            myreport.Export();
            MessageBox.Show("تم حفظ الملف بنجاح", "الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
