using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace D.T_Product_Management.BL
{
    class CLS_Login
    {
        //*7* initialize to login from DataBase
        public DataTable LogIN(String ID,String PWD)
        {
            DAL.DataAcessLayer DAL = new DAL.DataAcessLayer();
            SqlParameter[] sqlparam = new SqlParameter[2];
            sqlparam[0] = new SqlParameter("ID", SqlDbType.VarChar, 50);
            sqlparam[0].Value = ID;
            sqlparam[1] = new SqlParameter("PWD", SqlDbType.VarChar, 50);
            sqlparam[1].Value = PWD;
            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("SP_LOGIN", sqlparam);
            return dt;
        }
    }
}
