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

namespace D.T_Product_Management.PL
{
    
    public partial class FRM_BACKUP : Form
    {

        // this connection string for me (Database GIT online code)
        // sqlconnection = new SqlConnection(@"Data Source=LAPTOP-T23O7L29;Initial Catalog=dbProduct;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        // this short connection string for client server 
        SqlConnection con = new SqlConnection(@"Server=. ;Database=Product_Ma ;Integrated Security=true");

        SqlCommand cmd;
        public FRM_BACKUP()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                txtSelect.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string fileName = txtSelect.Text + "\\dbProduct" + "-"+DateTime.Now.ToShortDateString().Replace('/','-') + "-" + DateTime.Now.ToLongTimeString().Replace(':','-');
            string strQuery = "Backup Database dbProduct to Disk='"+fileName +".bak'";
            cmd = new SqlCommand(strQuery,con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


            MessageBox.Show("تم انشاء النسخه الاحتياطيه ", " نسخه احتياطيه", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
