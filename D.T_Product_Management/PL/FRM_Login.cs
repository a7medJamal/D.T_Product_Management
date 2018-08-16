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
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            DataTable dt = CLog.LogIN(txt_User.Text, txt_PWD.Text);
            if(dt.Rows.Count>0)
            {
                // to make all menu active after login successfully
                FRM_Main.getMainForm.العملاءToolStripMenuItem.Enabled = true;
                FRM_Main.getMainForm.المنتوجاتToolStripMenuItem.Enabled = true;
                FRM_Main.getMainForm.المستخدمونToolStripMenuItem.Enabled = true;
                FRM_Main.getMainForm.استعادهنسخهاحتياطيهToolStripMenuItem.Enabled = true;
                FRM_Main.getMainForm.انشاءنسخهاحتياطيهToolStripMenuItem.Enabled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("login Faild");
            }
        }

       
    }
}
