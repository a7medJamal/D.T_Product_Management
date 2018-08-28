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

        public void ADD_User(string ID, string fULLNAME, string PWD, string USERTYPE)
        {
            DAL.DataAcessLayer dll = new DAL.DataAcessLayer();
            dll.open();
            SqlParameter[] sqlparam = new SqlParameter[4];
            sqlparam[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            sqlparam[0].Value = ID;
            sqlparam[1] = new SqlParameter("@fULLNAME", SqlDbType.VarChar, 50);
            sqlparam[1].Value = fULLNAME;
            sqlparam[2] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            sqlparam[2].Value = PWD;
            sqlparam[3] = new SqlParameter("@USERTYPE", SqlDbType.VarChar, 50);
            sqlparam[3].Value = USERTYPE;
           
            dll.ExecuteCommand("SP_ADD_USER", sqlparam);
            dll.close();
        }

        public DataTable SEARCH_Users(string Criterion)
        {
            DAL.DataAcessLayer dll = new DAL.DataAcessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] sqlparam = new SqlParameter[1];
            sqlparam[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            sqlparam[0].Value = Criterion;

            dt = dll.SelectData("SP_SEARCH_USER", sqlparam);
            dll.close();
            return dt;
        }

        public void EDIT_User(string ID, string fULLNAME, string PWD, string USERTYPE)
        {
            DAL.DataAcessLayer dll = new DAL.DataAcessLayer();
            dll.open();
            SqlParameter[] sqlparam = new SqlParameter[4];
            sqlparam[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            sqlparam[0].Value = ID;
            sqlparam[1] = new SqlParameter("@fULLNAME", SqlDbType.VarChar, 50);
            sqlparam[1].Value = fULLNAME;
            sqlparam[2] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            sqlparam[2].Value = PWD;
            sqlparam[3] = new SqlParameter("@USERTYPE", SqlDbType.VarChar, 50);
            sqlparam[3].Value = USERTYPE;

            dll.ExecuteCommand("SP_EDIT_USERS", sqlparam);
            dll.close();
        }

        public void DELETE_User(string ID)
        {
            DAL.DataAcessLayer dll = new DAL.DataAcessLayer();
            dll.open();
            SqlParameter[] sqlparam = new SqlParameter[1];
            sqlparam[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            sqlparam[0].Value = ID;

            dll.ExecuteCommand("SP_DELET_USER", sqlparam);
            dll.close();
        }

    }
}
