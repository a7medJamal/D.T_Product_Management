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
    public partial class FRM_CUSTOMERS : Form
    {
        BL.CLS_CUSTOMERS cust = new BL.CLS_CUSTOMERS();
        int id;
        int posision;
        public FRM_CUSTOMERS()
        {
            InitializeComponent();
            //to select all data to grid view list
            this.dataGridView1.DataSource = cust.Select_customers();
            //this to make any columns not appear
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;

            btnAdd.Enabled = false;

        }

        public void Clear()
        {
            txtEmail.Clear();
            txtEndName.Clear();
            txtFirstName.Clear();
            txtPhone.Clear();
            pictureBox1.Image = null;
            txtFirstName.Focus();
        }

        public void Navigate(int Index)
        {
            try
            {
                pictureBox1.Image = null;
                //    DataTable dt = cust.Select_customers();
                DataRowCollection DRC = cust.Select_customers().Rows;
                id= (int)DRC[Index][0];
                txtFirstName.Text = DRC[Index][1].ToString();
                txtEndName.Text = DRC[Index][2].ToString();
                txtPhone.Text = DRC[Index][3].ToString();
                txtEmail.Text = DRC[Index][4].ToString();
                byte[] picture = (byte[])DRC[Index][5];
                MemoryStream ms = new MemoryStream(picture);
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            Navigate(0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //this for convert image to byte
                byte[] picture;
                if (pictureBox1.Image==null)
                {
                    picture = new byte[0];
                    cust.ADD_Customer(txtFirstName.Text, txtEndName.Text, txtPhone.Text, txtEmail.Text, picture, "without_image");
                    MessageBox.Show("تم الاضافه بنجاح", "الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = cust.Select_customers();
                    Clear();
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    picture = ms.ToArray();

                    cust.ADD_Customer(txtFirstName.Text, txtEndName.Text, txtPhone.Text, txtEmail.Text, picture, "with_image");
                    MessageBox.Show("تم الاضافه بنجاح", "الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = cust.Select_customers();
                    Clear();
                }
            }
            catch
            {
                // this is for dont stop application if fond any error
                return;
            }
            finally
            {
                btnAdd.Enabled = false;
                btnNew.Enabled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "ملفات الصور |*.jpg;.*png";
            if(op.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(op.FileName);
            }
            this.dataGridView1.DataSource = cust.Select_customers();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();

            btnAdd.Enabled = true;
            btnNew.Enabled = false;
        }

        private void btnExite_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                txtEndName.Focus();
            }
        }

        private void txtEndName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPhone.Focus();
            }
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.Focus();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                pictureBox1.Image = null;
                txtFirstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtEndName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtPhone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                //convert image data to byte and show in picture box
                byte[] picture = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(picture);
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                {
                    MessageBox.Show("لا يوجد عميل لتعديله", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //this for convert image to byte
                byte[] picture;
                if (pictureBox1.Image == null)
                {
                    picture = new byte[0];
                    cust.Edit_Customer(txtFirstName.Text, txtEndName.Text, txtPhone.Text, txtEmail.Text, picture, "without_image",id);
                    MessageBox.Show("تم التعديل بنجاح", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = cust.Select_customers();
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    picture = ms.ToArray();

                    cust.Edit_Customer(txtFirstName.Text, txtEndName.Text, txtPhone.Text, txtEmail.Text, picture, "with_image",id);
                    MessageBox.Show("تم التعديل بنجاح", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = cust.Select_customers();
                }
            }
            catch
            {
                // this is for dont stop application if fond any error
                return;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(id==0)
            {
                MessageBox.Show("لا يوجد عميل لحذفه", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(MessageBox.Show("هل تريد الحذف","الحذف",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                cust.Delete_Customer(id);
                this.dataGridView1.DataSource = cust.Select_customers();
                Clear();
                MessageBox.Show("تم الحذف بنجاح", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cust.Search_Customer(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = cust.Search_Customer(txtSearch.Text);

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            // this if you write something in textbox and press enter key  will send you in saerch button and make action
            if(e.KeyCode==Keys.Enter)
            {
                btnSearch_Click(sender ,e);
            }
        }

        private void btnPreview1_Click(object sender, EventArgs e)
        {
            posision = cust.Select_customers().Rows.Count - 1;
            Navigate(posision);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(posision==0)
            {
                MessageBox.Show("هذا هو اول عميل");
                return;
            }
            posision -= 1;
            Navigate(posision);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (posision == cust.Select_customers().Rows.Count-1)
            {
                MessageBox.Show("هذا هو اخر عميل");
                return;
            }
            posision += 1;
            Navigate(posision);
        }
    }
}
