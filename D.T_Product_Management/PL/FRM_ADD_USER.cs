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
    public partial class FRM_ADD_USER : Form
    {
        BL.CLS_Login login = new BL.CLS_Login();

        public FRM_ADD_USER()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != txtConPass.Text)
            {
                MessageBox.Show("كلمات السر غير متطابقه", "اضافه مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtUser.Text == String.Empty || txtName.Text == String.Empty || txtPass.Text == String.Empty || txtConPass.Text == String.Empty)
            {
                MessageBox.Show("ادخل البيانات بالكامل", "اضافه مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if(btnSave.Text== "حفظ المستخدم")
            {
                login.ADD_User(txtUser.Text, txtName.Text, txtPass.Text, cmType.Text);
                MessageBox.Show("تمت الاضافه بنجاح", "اضافه مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if(btnSave.Text== "تعديل المستخدم")
            {
                login.EDIT_User(txtUser.Text,txtName.Text, txtPass.Text, cmType.Text);
                MessageBox.Show("تم التعديل بنجاح", "تعديل مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            txtUser.Clear();
             txtName.Clear();
            txtPass.Clear();
            txtConPass.Clear();
            txtUser.Focus();


        }

        private void txtConPass_Validated(object sender, EventArgs e)
        {
            if(txtPass.Text != txtConPass.Text)
            {
                MessageBox.Show("كلمات السر غير متطابقه", "اضافه مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
