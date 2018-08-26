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
    }
}
