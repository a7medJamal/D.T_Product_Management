using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace D.T_Product_Management.BL
{
    class CLS_CUSTOMERS
    {
        public void ADD_Customer(string FIRST_NAME,string LAST_NAME,string TEL,string EMAIL ,byte[]             IMAGE_CUSTOMER,string Criterion)
        {
            DAL.DataAcessLayer dll = new DAL.DataAcessLayer();
            dll.open();
            SqlParameter[] sqlparam = new SqlParameter[6];
            sqlparam[0] = new SqlParameter("@FIRST_NAME", SqlDbType.VarChar, 25);
            sqlparam[0].Value = FIRST_NAME;
            sqlparam[1] = new SqlParameter("@LAST_NAME", SqlDbType.VarChar, 25);
            sqlparam[1].Value = LAST_NAME;
            sqlparam[2] = new SqlParameter("@TEL", SqlDbType.NVarChar, 15);
            sqlparam[2].Value = TEL;
            sqlparam[3] = new SqlParameter("@EMAIL", SqlDbType.VarChar, 25);
            sqlparam[3].Value = EMAIL;
            sqlparam[4] = new SqlParameter("@IMAGE_CUSTOMER", SqlDbType.Image);
            sqlparam[4].Value = IMAGE_CUSTOMER;

            sqlparam[5] = new SqlParameter("@Criterion", SqlDbType.VarChar,50);
            sqlparam[5].Value = Criterion;

            dll.ExecuteCommand("SP_ADD_CUSTOMERS", sqlparam);
            dll.close();
        }

        public DataTable Select_customers ()
        {
            DAL.DataAcessLayer dll = new DAL.DataAcessLayer();
            dll.open();
            DataTable dt = new DataTable();
           dt=dll.SelectData("SP_SELECT_ALL_CUSTOMER", null);
            dll.close();
            return dt;
        }

        public void Edit_Customer(string FIRST_NAME, string LAST_NAME, string TEL, string EMAIL, byte[] IMAGE_CUSTOMER, string Criterion,int ID)
        {
            DAL.DataAcessLayer dll = new DAL.DataAcessLayer();
            dll.open();
            SqlParameter[] sqlparam = new SqlParameter[7];
            sqlparam[0] = new SqlParameter("@FIRST_NAME", SqlDbType.VarChar, 25);
            sqlparam[0].Value = FIRST_NAME;
            sqlparam[1] = new SqlParameter("@LAST_NAME", SqlDbType.VarChar, 25);
            sqlparam[1].Value = LAST_NAME;
            sqlparam[2] = new SqlParameter("@TEL", SqlDbType.NVarChar, 15);
            sqlparam[2].Value = TEL;
            sqlparam[3] = new SqlParameter("@EMAIL", SqlDbType.VarChar, 25);
            sqlparam[3].Value = EMAIL;
            sqlparam[4] = new SqlParameter("@IMAGE_CUSTOMER", SqlDbType.Image);
            sqlparam[4].Value = IMAGE_CUSTOMER;

            sqlparam[5] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            sqlparam[5].Value = Criterion;

            sqlparam[6] = new SqlParameter("@ID", SqlDbType.Int);
            sqlparam[6].Value = ID;

            dll.ExecuteCommand("SP_Edit_CUSTOM", sqlparam);
            dll.close();
        }

        public void Delete_Customer(int id)
        {
            DAL.DataAcessLayer dll = new DAL.DataAcessLayer();
            dll.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
             dll.ExecuteCommand("SP_DELETE_CUSTOMER", param);
            dll.close();
        }

        public DataTable Search_Customer(string criterion)
        {
            DAL.DataAcessLayer dll = new DAL.DataAcessLayer();
            dll.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = criterion;
            DataTable dt = new DataTable();
            dt = dll.SelectData("SP_SEARCH_CUSTOMER", param);
            dll.close();
            return dt;
        }
    }
}
