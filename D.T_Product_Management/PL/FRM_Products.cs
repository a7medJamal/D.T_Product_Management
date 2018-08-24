using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;

namespace D.T_Product_Management.PL
{
    public partial class FRM_Products : Form
    {
        #region TO control from FRM add product
        // this code to initialize FRM controls to Another FRM add product
        private static FRM_Products frm;
        static void frm_formClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FRM_Products getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_Products();
                    frm.FormClosed += new FormClosedEventHandler(frm_formClosed);
                }
                return frm;
            }
        }
        #endregion

        BL.CLS_PRODUCT cl = new BL.CLS_PRODUCT();
        public FRM_Products()
        {
            InitializeComponent();
            //TO control from FRM add product
            if (frm == null)
                frm = this;


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

        //this to delet rows from database
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل تريد الحذف","حذف المنتج",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation)==DialogResult.OK)
            {
                cl.DELETE_PRODUCT(DGV_Data.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تم الحذف بنجاح", "حذف المنتج", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DGV_Data.DataSource = cl.GET_ALL_PRODUCTS();
            }
            else
            {
                MessageBox.Show("تم الغاءالحذف ", "حذف المنتج", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.txt_ID.Text = DGV_Data.CurrentRow.Cells[0].Value.ToString();
            frm.txt_PRICE.Text = DGV_Data.CurrentRow.Cells[3].Value.ToString();
            frm.txt_QUT.Text = DGV_Data.CurrentRow.Cells[2].Value.ToString();
            frm.txt_Description.Text = DGV_Data.CurrentRow.Cells[4].Value.ToString();
            frm.CMD_CATEGERORIES.Text = DGV_Data.CurrentRow.Cells[1].Value.ToString();
            frm.Text = "تعديل المنتج" + DGV_Data.CurrentRow.Cells[0].Value.ToString();
            frm.btn_ADD.Text = "تعديل المنتج";
            frm.FRMstate = "edit";
            frm.txt_ID.ReadOnly = true;
            byte[] image = (byte[])cl.Select_Image(this.DGV_Data.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.PICBOX.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void btn_Image_Click(object sender, EventArgs e)
        {
            FRM_PREVIEW frm = new FRM_PREVIEW();
            frm.Text = "عرض صوره المنتج" + " "+  " " +DGV_Data.CurrentRow.Cells[0].Value.ToString();
            // to get data image byte
            byte[] image = (byte[])cl.Select_Image(this.DGV_Data.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.PIC_PREVIEW.Image = Image.FromStream(ms);
            frm.ShowDialog();

        }

        private void btn_Print_Selected_Click(object sender, EventArgs e)
        {
            RPT.RPT_PRODUCT_SINGLE myreport = new RPT.RPT_PRODUCT_SINGLE();
            myreport.SetParameterValue("@ID", this.DGV_Data.CurrentRow.Cells[0].Value.ToString());
            RPT.FRM_PRT_PRODUCT frm = new RPT.FRM_PRT_PRODUCT();
            frm.crystalReportViewer1.ReportSource=myreport;
            frm.ShowDialog();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            RPT.RPT_PRODUCT_ALL myreport = new RPT.RPT_PRODUCT_ALL();
            RPT.FRM_PRT_PRODUCT frm = new RPT.FRM_PRT_PRODUCT();
            frm.crystalReportViewer1.ReportSource = myreport;
            frm.ShowDialog();

        }

        // this to save all product exel (you can save to pdf or any format)
        private void btn_Sava_Excel_Click(object sender, EventArgs e)
        {
            RPT.RPT_PRODUCT_ALL myreport = new RPT.RPT_PRODUCT_ALL();

            //create export options
            ExportOptions expoert = new ExportOptions();

            //create object for destination
            DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();

            ExcelFormatOptions exelformat = new ExcelFormatOptions();
            //set the path of destionation
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "ملفات exel | *.xls";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dfoptions.DiskFileName = ofd.FileName;

            }
            expoert = myreport.ExportOptions;

            expoert.ExportDestinationType = ExportDestinationType.DiskFile;

            expoert.ExportFormatType = ExportFormatType.Excel;

            expoert.ExportFormatOptions = exelformat;
            expoert.ExportDestinationOptions = dfoptions;
            myreport.Export();
            MessageBox.Show("تم حفظ الملف بنجاح","الحفظ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_Exite_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
