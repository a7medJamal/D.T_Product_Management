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
    public partial class FRM_USER_LIST : Form
    {
        BL.CLS_Login login = new BL.CLS_Login();
        public FRM_USER_LIST()
        {
            InitializeComponent();
            DGV_Userlist.DataSource = login.SEARCH_Users("");
        }

        private void FRM_USER_LIST_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER FRM = new FRM_ADD_USER();
            FRM.btnSave.Text = "حفظ المستخدم";
            FRM.Text = "اضاقه المستخدم";
            FRM.ShowDialog();
            DGV_Userlist.DataSource = login.SEARCH_Users("");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER FRM = new FRM_ADD_USER();
            FRM.txtUser.Text = DGV_Userlist.CurrentRow.Cells[0].Value.ToString();
            FRM.txtName.Text = DGV_Userlist.CurrentRow.Cells[1].Value.ToString();
            FRM.txtPass.Text = DGV_Userlist.CurrentRow.Cells[2].Value.ToString();
            FRM.txtConPass.Text = DGV_Userlist.CurrentRow.Cells[2].Value.ToString();
            FRM.cmType.Text = DGV_Userlist.CurrentRow.Cells[3].Value.ToString();
            FRM.btnSave.Text = "تعديل المستخدم";
            FRM.Text = "تعديل المستخدم";
            FRM.ShowDialog();
            DGV_Userlist.DataSource = login.SEARCH_Users("");

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           this. DGV_Userlist.DataSource = login.SEARCH_Users(txtSearch.Text);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل تريد الحذف","حذف مستخدم",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                login.DELETE_User(DGV_Userlist.CurrentRow.Cells[0].Value.ToString());

                MessageBox.Show("تم الحذف بنجاح", "حذف مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV_Userlist.DataSource = login.SEARCH_Users("");

            }

        }
    }
}
