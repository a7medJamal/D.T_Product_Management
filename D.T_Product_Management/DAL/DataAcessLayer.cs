using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace D.T_Product_Management.DAL
{
    class DataAcessLayer
    {
        //*1* initialize connection string
        SqlConnection sqlconnection;

        //*2* initialize constractour to this class
        public DataAcessLayer()
        {
            sqlconnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=D.T_Product_Management_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        //*3* initialize to open connection string
        public void open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }

        //*4* initialize to close connection string
        public void close()
        {
            if(sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }

        //*5* Method to read data from database
        public DataTable SelectData (string Stored_Procedure,SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Stored_Procedure;
            cmd.Connection = sqlconnection;
            if (param != null)
            {
                for(int i=0; i<param.Length;i++)
                {
                    cmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //*6* Method to add,delete,update data from DataBase
        public void ExecuteCommand(String Stord_Procedure ,SqlParameter[]param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText= Stord_Procedure;
            cmd.Connection = sqlconnection;
            if(param!=null)
            {
                cmd.Parameters.AddRange(param);
            }
            cmd.ExecuteNonQuery();
        }
    }
}
