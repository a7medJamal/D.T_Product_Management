using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace D.T_Product_Management.BL
{
    class CLS_PRODUCT
    {
        // to select to add CATEGORIES data
        public DataTable GET_ALL_CATEGORIES()
        {
            DAL.DataAcessLayer DAL = new DAL.DataAcessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("SP_GET_ALL_CATEGORIES", null);
            return dt;
        }

        // to inisialize to add product data
        public void ADD_PRODUCT (int ID_CAT,string ID_PRODUCT,int QTE,string LABEL_Product,int PRICE,byte[] IMG)
        {
            DAL.DataAcessLayer DAL = new DAL.DataAcessLayer();
            DAL.open();
            SqlParameter[] sqlparam = new SqlParameter[6];
            sqlparam[0] = new SqlParameter("@ID_CAT",SqlDbType.Int);
            sqlparam[0].Value = ID_CAT;
            sqlparam[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar,30);
            sqlparam[1].Value = ID_PRODUCT;
            sqlparam[2] = new SqlParameter("@QTE", SqlDbType.Int);
            sqlparam[2].Value = QTE;
            sqlparam[3] = new SqlParameter("@LABEL", SqlDbType.VarChar, 30);
            sqlparam[3].Value = LABEL_Product;
            sqlparam[4] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            sqlparam[4].Value = PRICE;
            sqlparam[5] = new SqlParameter("@IMG", SqlDbType.Image);
            sqlparam[5].Value = IMG;
            DAL.ExecuteCommand("SP_ADD_PRODUCT", sqlparam);
            DAL.close();


        }
    }
}
