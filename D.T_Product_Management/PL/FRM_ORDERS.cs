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

#region شرح العمليات الحسابيه
/*
  المبلغ = الكميه * الثمن
 ((المبلغ الاجمالى = المبلغ-(المبلغ *(نسبه الخصم/100 
 */
#endregion
namespace D.T_Product_Management.PL
{
    public partial class FRM_ORDERS : Form
    {
        BL.CLS_ORDERS order = new BL.CLS_ORDERS();
        DataTable dt = new DataTable();

        void CalculateAmount()
        {
            if(txtProductPrice.Text !=String.Empty && txtProductQTE.Text !=String.Empty)
            {
                
                txtProductQTEPrice.Text =( Convert.ToDouble(txtProductPrice.Text) * Convert.ToInt32(txtProductQTE.Text)).ToString();
            }
            
        }

        void CalculateTotalAmount()
        {
            if(txtProductDiscount.Text !=String.Empty && txtProductQTEPrice.Text !=String.Empty)
            {
                
                double Discount = Convert.ToDouble(txtProductDiscount.Text);
                double amount = Convert.ToDouble(txtProductQTEPrice.Text);
                double TotalAmount = amount - (amount * (Discount / 100));
                txtProductTotal.Text = TotalAmount.ToString();
            }
            
        }
        public void CreateDataTable()
        {
            dt.Columns.Add("معرف المنتج");
            dt.Columns.Add("اسم المنتج");
            dt.Columns.Add("الثمن");
            dt.Columns.Add("الكميه");
            dt.Columns.Add("الميلغ");
            dt.Columns.Add("نسبه الخصم(%)");
            dt.Columns.Add("المبلغ الاجمالى");
            DGVNEWOrders.DataSource = dt;

            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //btn.HeaderText = "اختيار منتج";
            //btn.Text = "البحث";
            //btn.UseColumnTextForButtonValue = true;
            //DGWOrders.Columns.Insert(0, btn);          
        }

        void ClearBoxes()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtProductPrice.Clear();
            txtProductQTE.Clear();
            txtProductQTEPrice.Clear();
            txtProductDiscount.Clear();
            txtProductTotal.Clear();
        }
         void ResizeDG()
        {
            this.DGVNEWOrders.RowHeadersWidth = 85;
            this.DGVNEWOrders.Columns[0].Width = 147;
            this.DGVNEWOrders.Columns[1].Width = 274;
            this.DGVNEWOrders.Columns[2].Width = 114;
            this.DGVNEWOrders.Columns[3].Width = 115;
            this.DGVNEWOrders.Columns[4].Width = 119;
            this.DGVNEWOrders.Columns[5].Width = 111;
            this.DGVNEWOrders.Columns[6].Width = 120;
        }

        public FRM_ORDERS()
        {
            InitializeComponent();
            CreateDataTable();
            ResizeDG();

            btnSaveOrder.Enabled = false;
            btnPrintOrder.Enabled = false;
            txtOrderID.Text = order.GET_Last_Orders_ID().Rows[0][0].ToString();

        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            txtOrderID.Text = order.GET_Last_Orders_ID().Rows[0][0].ToString();
            btnSaveOrder.Enabled = true;
            btnNewOrder.Enabled = false;

        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            btnPrintOrder.Enabled = true;
            btnNewOrder.Enabled = true;

        }

        private void btnSelectCust_Click(object sender, EventArgs e)
        {
           
                CustPicture.Image = null;
                PL.FRM_CUSTOMERS_LIST frm = new FRM_CUSTOMERS_LIST();
                frm.ShowDialog();

              if(frm.DGVCustomers.CurrentRow.Cells[5].Value is DBNull)
            {
                MessageBox.Show("هذا العميل لا يتوفر على صوره");
                txtCustID.Text = frm.DGVCustomers.CurrentRow.Cells[0].Value.ToString();
                txtCustFirstName.Text = frm.DGVCustomers.CurrentRow.Cells[1].Value.ToString();
                txtCustLastName.Text = frm.DGVCustomers.CurrentRow.Cells[2].Value.ToString();
                txtCustPhone.Text = frm.DGVCustomers.CurrentRow.Cells[3].Value.ToString();
                txtCustMail.Text = frm.DGVCustomers.CurrentRow.Cells[4].Value.ToString();

                return;

            }
            txtCustID.Text = frm.DGVCustomers.CurrentRow.Cells[0].Value.ToString();
                txtCustFirstName.Text = frm.DGVCustomers.CurrentRow.Cells[1].Value.ToString();
                txtCustLastName.Text = frm.DGVCustomers.CurrentRow.Cells[2].Value.ToString();
                txtCustPhone.Text = frm.DGVCustomers.CurrentRow.Cells[3].Value.ToString();
                txtCustMail.Text = frm.DGVCustomers.CurrentRow.Cells[4].Value.ToString();

                // this for image
                byte[] custImage = (byte[])frm.DGVCustomers.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(custImage);
                CustPicture.Image = Image.FromStream(ms);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCustID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExite_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            PL.FRM_PRODUCTS_LIST frm = new FRM_PRODUCTS_LIST();
            frm.ShowDialog();
            txtProductID.Text = frm.DGVProducts.CurrentRow.Cells[0].Value.ToString();

            txtProductName.Text = frm.DGVProducts.CurrentRow.Cells[1].Value.ToString();

            txtProductPrice.Text = frm.DGVProducts.CurrentRow.Cells[3].Value.ToString();

        }

        private void txtProductQTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            // this to write numbers only
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!=8)
            {
                e.Handled = true;
            }
            CalculateAmount();
            CalculateTotalAmount();
        }

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // this to write numbers only and allow to write float numbers
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
            CalculateAmount();
            CalculateTotalAmount();
        }

        private void txtProductDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            CalculateTotalAmount();
        }

        private void txtProductPrice_KeyDown(object sender, KeyEventArgs e)
        {
            // this if enter number in text box move to another text box and make sure not null
            if (e.KeyCode == Keys.Enter && txtProductPrice.Text !=string.Empty)
            {
                txtProductQTE.Focus();
            }
        }

        private void txtProductQTE_KeyDown(object sender, KeyEventArgs e)
        {
            // this if enter number in text box move to another text box and make sure not null
            if (e.KeyCode == Keys.Enter && txtProductQTE.Text != string.Empty)
            {
                txtProductDiscount.Focus();
            }
        }

        private void txtProductPrice_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
            CalculateTotalAmount();
        }

        private void txtProductQTE_KeyUp(object sender, KeyEventArgs e)
        {

            CalculateAmount();
            CalculateTotalAmount();
        }

        private void txtProductDiscount_KeyUp(object sender, KeyEventArgs e)
        {

            CalculateTotalAmount();
        }

        private void txtProductDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                DataRow r = dt.NewRow();
                r[0] = txtProductID.Text;
                r[1] = txtProductName.Text;
                r[2] = txtProductPrice.Text;
                r[3] = txtProductQTE.Text;
                r[4] = txtProductQTEPrice.Text;
                r[5] = txtProductDiscount.Text;
                r[6] = txtProductTotal.Text;
                dt.Rows.Add(r);
                DGVNEWOrders.DataSource = dt;

                ClearBoxes();
                btnProductSearch.Focus();

                txtOrderSUM.Text=(from DataGridViewRow row in DGVNEWOrders.Rows where row.Cells[6].FormattedValue.ToString() !=String.Empty select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();

            }
        }
    }
}
