using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace D.T_Product_Management.BL
{
    class CLS_ORDERS
    {
        public DataTable GET_Last_Orders_ID()
        {
            DAL.DataAcessLayer dll = new DAL.DataAcessLayer();
            DataTable dt = new DataTable();
            dt = dll.SelectData("SP_GET_LAST_ORDER", null);
            dll.close();
            return dt;
        }

        public void ADD_Orders(int ID_ORDER, DateTime DATE_ORDER, int CUSTOMER_ID, string DESCRIPTION_ORDER, string SALESMAN)
        {
            DAL.DataAcessLayer dll = new DAL.DataAcessLayer();
            dll.open();
            SqlParameter[] sqlparam = new SqlParameter[5];
            sqlparam[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            sqlparam[0].Value = ID_ORDER;
            sqlparam[1] = new SqlParameter("@DATE_ORDER", SqlDbType.DateTime);
            sqlparam[1].Value = DATE_ORDER;
            sqlparam[2] = new SqlParameter("@CUSTOMER_ID", SqlDbType.Int);
            sqlparam[2].Value = CUSTOMER_ID;
            sqlparam[3] = new SqlParameter("@DESCRIPTION_ORDER", SqlDbType.VarChar, 75);
            sqlparam[3].Value = DESCRIPTION_ORDER;
            sqlparam[4] = new SqlParameter("@SALESMAN", SqlDbType.VarChar,75);
            sqlparam[4].Value = SALESMAN;

            dll.ExecuteCommand("SP_ADD_ORDER", sqlparam);
            dll.close();
        }

        public void ADD_Order_Details(string ID_PRODUCT, int ID_ORDER, int QTE, string PRICE, float DISCOUNT,string AMOUNT, string TOTAL_AMOUNT)
        {
            DAL.DataAcessLayer dll = new DAL.DataAcessLayer();
            dll.open();
            SqlParameter[] sqlparam = new SqlParameter[7];
            sqlparam[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar,30);
            sqlparam[0].Value = ID_PRODUCT;
            sqlparam[1] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            sqlparam[1].Value = ID_ORDER;
            sqlparam[2] = new SqlParameter("@QTE", SqlDbType.Int);
            sqlparam[2].Value = QTE;
            sqlparam[3] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            sqlparam[3].Value = PRICE;
            sqlparam[4] = new SqlParameter("@DISCOUNT", SqlDbType.Float);
            sqlparam[4].Value = DISCOUNT;
            sqlparam[5] = new SqlParameter("@AMOUNT", SqlDbType.VarChar, 50);
            sqlparam[5].Value = AMOUNT;
            sqlparam[6] = new SqlParameter("@TOTAL_AMOUNT", SqlDbType.VarChar, 50);
            sqlparam[6].Value = TOTAL_AMOUNT;

            dll.ExecuteCommand("SP_ADD_ORDER_DETAILS", sqlparam);
            dll.close();
        }

        public DataTable VERIFYQTY(string ID_PRODUCT, int QTY_ENTERED)
        {
            DAL.DataAcessLayer dll = new DAL.DataAcessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] sqlparam = new SqlParameter[2];
            sqlparam[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 30);
            sqlparam[0].Value = ID_PRODUCT;
            sqlparam[1] = new SqlParameter("@QTY_ENTERED", SqlDbType.Int);
            sqlparam[1].Value = QTY_ENTERED;
           dt= dll.SelectData("SP_VERIFYQTY", sqlparam);
            dll.close();
            return dt;
        }

        public DataTable GET_Last_Orders_ID_FOR_PRINT()
        {
            DAL.DataAcessLayer dll = new DAL.DataAcessLayer();
            DataTable dt = new DataTable();
            dt = dll.SelectData("SP_GET_LAST_ORDER_FOR_PRINT", null);
            dll.close();
            return dt;
        }

        public DataTable GetOrderDetails(int ID_Order)
        {
            DAL.DataAcessLayer dll = new DAL.DataAcessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] sqlparam = new SqlParameter[1];
            sqlparam[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            sqlparam[0].Value = ID_Order;
           
            dt = dll.SelectData("SP_GetOrderDetails", sqlparam);
            dll.close();
            return dt;
        }

        public DataTable SEARCH_ORDERS(string Criterion)
        {
            DAL.DataAcessLayer dll = new DAL.DataAcessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] sqlparam = new SqlParameter[1];
            sqlparam[0] = new SqlParameter("@Criterion", SqlDbType.VarChar,50);
            sqlparam[0].Value = Criterion;

            dt = dll.SelectData("SP_SEARCH_ORDERS", sqlparam);
            dll.close();
            return dt;
        }

        public DataTable SEARCH_BARCODE(string ID)
        {
            DAL.DataAcessLayer DLL = new DAL.DataAcessLayer();
            DLL.open();
            SqlParameter[] sqlparam = new SqlParameter[1];
            sqlparam[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            sqlparam[0].Value = ID;
            DataTable dt = new DataTable();
            dt = DLL.SelectData("SP_SEARCH_BARCODE", sqlparam);
            DLL.close();
            return dt;
        }

    }
}
