using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DL
{
    class VisitorDL
    {
        DBConnection dbCon;

        public VisitorDL()
        {
            dbCon = new DBConnection();
        }
        
        public DataTable ViewFoodOnly()
        {
            {
                DataTable dt = new DataTable();
                try
                {
                    dbCon.Con.Open();
                    string queryString = "SELECT Food.ItemType , Food.ItemName, Food.ItemCompany , Food.ItemPrice, Food.ItemWeight FROM Food";
                    SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                    SqlDataReader reader = com.ExecuteReader();
                    dt.Load(reader);
                    return dt;
                }
                catch (SqlException ex)
                {


                }
                finally
                {
                    dbCon.Con.Close();

                }
                return null;

            }

        }

        public DataTable ViewBeautyOnly()
        {
            {
                DataTable dt = new DataTable();
                try
                {
                    dbCon.Con.Open();
                    string queryString = "SELECT Beauty.ItemType, Beauty.ItemName, Beauty.ItemCompany, Beauty.ItemPrice FROM Beauty";
                    SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                    SqlDataReader reader = com.ExecuteReader();
                    dt.Load(reader);
                    return dt;
                }
                catch (SqlException ex)
                {


                }
                finally
                {
                    dbCon.Con.Close();

                }
                return null;

            }

        }

        public DataTable ViewKidsOnly()
        {
            {
                DataTable dt = new DataTable();
                try
                {
                    dbCon.Con.Open();
                    string queryString = "SELECT Kids.ItemType, Kids.ItemName, Kids.ItemPrice FROM Kids";
                    SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                    SqlDataReader reader = com.ExecuteReader();
                    dt.Load(reader);
                    return dt;
                }
                catch (SqlException ex)
                {


                }
                finally
                {
                    dbCon.Con.Close();

                }
                return null;

            }

        }

        public DataTable ViewGamingOnly()
        {
            {
                DataTable dt = new DataTable();
                try
                {
                    dbCon.Con.Open();
                    string queryString = "SELECT Computing.ItemType , Computing.ItemCompany , Computing.ItemPrice FROM Computing";
                    SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                    SqlDataReader reader = com.ExecuteReader();
                    dt.Load(reader);
                    return dt;
                }
                catch (SqlException ex)
                {


                }
                finally
                {
                    dbCon.Con.Close();

                }
                return null;

            }

        }
    }
}
