using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace D.T_Product_Management.PL
{
    public partial class FRM_ADD_PRODUCT : Form
    {
        BL.CLS_PRODUCT PL = new BL.CLS_PRODUCT();

        //this to make text validation in id product False in form edit
        public string FRMstate = "add";

        public FRM_ADD_PRODUCT()
        {
            InitializeComponent();

            CMD_CATEGERORIES.DataSource = PL.GET_ALL_CATEGORIES();
            CMD_CATEGERORIES.ValueMember = "ID_CAT";
            CMD_CATEGERORIES.DisplayMember = "DESCRIPTION_CAT";

            this.dataGridView1.DataSource = PL.GET_ALL_PRODUCTS();
        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {
            try
            {
                if (FRMstate == "add")
                {
                    //this to convert image to byte data 01010101010101
                    MemoryStream ms = new MemoryStream();
                    PICBOX.Image.Save(ms, PICBOX.Image.RawFormat);
                    byte[] byteImage = ms.ToArray();
                    PL.ADD_PRODUCT(Convert.ToInt32(CMD_CATEGERORIES.SelectedValue), txt_ID.Text, Convert.ToInt32(txt_QUT.Text), txt_Description.Text, Convert.ToInt32(txt_PRICE.Text), byteImage);

                    MessageBox.Show("تمت الاضافه بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = PL.GET_ALL_PRODUCTS();

                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    PICBOX.Image.Save(ms, PICBOX.Image.RawFormat);
                    byte[] byteImage = ms.ToArray();
                    PL.UPDATE_PRODUCT(Convert.ToInt32(CMD_CATEGERORIES.SelectedValue), txt_ID.Text, Convert.ToInt32(txt_QUT.Text), txt_Description.Text, Convert.ToInt32(txt_PRICE.Text), byteImage);

                    MessageBox.Show("تمت التحديث بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = PL.GET_ALL_PRODUCTS();
                    FRM_Products frm = new FRM_Products();
                    this.Close();
                }
                // to updae data in data grid view
                FRM_Products.getMainForm.DGV_Data.DataSource = PL.GET_ALL_PRODUCTS();
            }
            catch (Exception)
            {
                MessageBox.Show("يرجى الادخال بطريقه صحيحه", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btn_SelectPic_Click(object sender, EventArgs e)
        {
            //this to inizialize image 
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور | *.JPG;*PNG;*GIF";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PICBOX.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void txt_ID_Validated(object sender, EventArgs e)
        {
            if (FRMstate == "add")
            {
                DataTable dt = new DataTable();
                dt = PL.VerifyProductID(txt_ID.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا المنتج موجود مسبقا", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txt_ID.Focus();

                    // txt_ID.SelectionStart = 0;
                    //  txt_ID.SelectLenth = txt_ID.textLenth;
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
