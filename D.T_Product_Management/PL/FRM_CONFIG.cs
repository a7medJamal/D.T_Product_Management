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
    public partial class FRM_CONFIG : Form
    {
        public FRM_CONFIG()
        {
            InitializeComponent();
        }

        private void btnExite_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //to save all setting in properties data
            Properties.Settings.Default.Server = txtServer.Text;
            Properties.Settings.Default.Database = txtDatabase.Text;

            Properties.Settings.Default.Mode = rdoSQLAuth.Checked == true ? "SQL" : "Windows";

            Properties.Settings.Default.Password = txtPass.Text;
            Properties.Settings.Default.ID = txtUser.Text;

            Properties.Settings.Default.Save();
        }
    }
}
