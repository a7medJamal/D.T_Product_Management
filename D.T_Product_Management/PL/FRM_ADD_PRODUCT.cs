﻿using System;
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
        public FRM_ADD_PRODUCT()
        {
            InitializeComponent();

            CMD_CATEGERORIES.DataSource = PL.GET_ALL_CATEGORIES();
            CMD_CATEGERORIES.ValueMember = "ID_CAT";
            CMD_CATEGERORIES.DisplayMember = "DESCRIPTION_CAT";

            this.dataGridView1.DataSource = PL.GET_ALL_PRODUCTS();


        }


        private void monoFlat_ThemeContainer1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {
            try
            {
                //this to convert image to byte data 01010101010101
                MemoryStream ms = new MemoryStream();
                PICBOX.Image.Save(ms, PICBOX.Image.RawFormat);
                byte[] byteImage = ms.ToArray();
                PL.ADD_PRODUCT(Convert.ToInt32(CMD_CATEGERORIES.SelectedValue), txt_ID.Text, Convert.ToInt32(txt_QUT.Text), txt_Description.Text, Convert.ToInt32(txt_PRICE.Text), byteImage);

                MessageBox.Show("تمت الاضافه بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("يرجى الادخال بطريقه صحيحه", "عمليه الاضافه", MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
        }

        //this code to select pic from computer
        private void btn_SelectPic_Click_1(object sender, EventArgs e)
        {
            //this to inizialize image 
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور | *.JPG;*PNG;*GIF";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PICBOX.Image = Image.FromFile(ofd.FileName);
            }


        }

        // this code to Validated data from database
        private void txt_ID_Validated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = PL.VerifyProductID(txt_ID.Text);
            if(dt.Rows.Count>0)
            {
                MessageBox.Show("هذا المنتج موجود مسبقا", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txt_ID.Focus();
                
                // txt_ID.SelectionStart = 0;
              //  txt_ID.SelectLenth = txt_ID.textLenth;

            }
        }
    }
}
