using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D.T_Product_Management
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
            // this for get SalesMan from login form
        public static string SalesMan;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PL.FRM_ORDERS());
        }
    }
}
