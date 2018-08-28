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
    public partial class FRM_Login : Form
    {
        BL.CLS_Login CLog = new BL.CLS_Login();
        public FRM_Login()
        {
            InitializeComponent();

            groupBox1.Focus();
            txt_User.Focus();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void txt_User_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_PWD.Focus();
            }

        }

        private void btn_Login_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_PWD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGO.Focus();
            }

        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            DataTable dt = CLog.LogIN(txt_User.Text, txt_PWD.Text);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][2].ToString() == "ADMIN")
                {
                    // to make all menu active after login successfully
                    FRM_Main.getMainForm.العملاءToolStripMenuItem.Enabled = true;
                    FRM_Main.getMainForm.المنتوجاتToolStripMenuItem.Enabled = true;
                    FRM_Main.getMainForm.المستخدمونToolStripMenuItem.Enabled = true;
                    FRM_Main.getMainForm.المستخدمونToolStripMenuItem.Visible = true;

                    FRM_Main.getMainForm.استعادهنسخهاحتياطيهToolStripMenuItem.Enabled = true;
                    FRM_Main.getMainForm.انشاءنسخهاحتياطيهToolStripMenuItem.Enabled = true;

                    // to get user name
                    Program.SalesMan = dt.Rows[0]["FULLNAME"].ToString();

                    //FRM_Main frm = new FRM_Main();
                    //frm.ShowDialog();

                    this.Close();
                }
                else if (dt.Rows[0][2].ToString() == "USER")
                {
                    // to make all menu active after login successfully
                    FRM_Main.getMainForm.العملاءToolStripMenuItem.Enabled = true;
                    FRM_Main.getMainForm.المنتوجاتToolStripMenuItem.Enabled = true;
                    FRM_Main.getMainForm.المستخدمونToolStripMenuItem.Visible = false;
                    FRM_Main.getMainForm.استعادهنسخهاحتياطيهToolStripMenuItem.Enabled = false;
                    FRM_Main.getMainForm.انشاءنسخهاحتياطيهToolStripMenuItem.Enabled = true;

                    // to get user name
                    Program.SalesMan = dt.Rows[0]["FULLNAME"].ToString();


                    //FRM_Main frm = new FRM_Main();
                    //frm.ShowDialog();
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("ادخل اسم المستخدم أو كلمه المرور غير صحيحه", "تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
