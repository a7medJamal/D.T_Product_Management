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
    public partial class Login : Form
    {
        BL.CLS_Login CLog = new BL.CLS_Login();
        public Login()
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
                MessageBox.Show("login sucessufly");
            }
            else
            {
                MessageBox.Show("login Faild");
            }
        }

        private void btn_Login_Click_1(object sender, EventArgs e)
        {

        }
    }
}
