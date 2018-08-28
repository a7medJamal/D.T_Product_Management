using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D.T_Product_Management.PL
{
    public partial class FRM_RESTOREcs : Form
    {
        SqlConnection con = new SqlConnection(@"Server=. ;Database=master ;Integrated Security=true");

        SqlCommand cmd;

        public FRM_RESTOREcs()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSelect.Text = openFileDialog1.FileName;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string strQuery = "ALTER Database dbProduct SET OFFLINE WITH ROLLBACK IMMEDIATE;  Restore Database dbProduct From Disk= '" + txtSelect.Text + "'";
                cmd = new SqlCommand(strQuery, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("تم استعاده النسخه الاحتياطيه ", " استعاده النسخه الاحتياطيه ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
            
        }
    }
}
