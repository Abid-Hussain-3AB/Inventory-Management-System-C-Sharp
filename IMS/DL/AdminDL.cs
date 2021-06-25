using IMS.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DL
{
    class AdminDL
    {
        DBConnection dbCon;

        public AdminDL()
        {
            dbCon = new DBConnection();
        }
        public void CreateAcountDB(UserDTO usDTO)
        {
            try
            {
                dbCon.Con.Open();
                String qurystring = "INSERT INTO MyUser VALUES('" + usDTO.UserID + "','" + usDTO.Password + "','" + usDTO.Role + "');";
                SqlCommand com = new SqlCommand(qurystring, dbCon.Con);
                int rowsAffected = com.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {

            }
            finally
            {
                dbCon.Con.Close();
            }
        }
        public void AddEmployeeInDB(UserDTO usDTO)
        {
            try
            {
                dbCon.Con.Open();
               
                string queryString = "INSERT INTO Employee VALUES('" + usDTO.UserID + "','" + usDTO.Name + "','" + usDTO.Address + "','" + usDTO.Phone + "');";
               
                SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                int rowsAffected = com.ExecuteNonQuery();


            }
            catch (SqlException ex)

            {

            }
            finally
            {
                dbCon.Con.Close();
            }
        }
        public void AddVisitorInDB(UserDTO usDTO)
        {
            try
            {
                dbCon.Con.Open();
               
                string queryString = "INSERT INTO Visitor VALUES('" + usDTO.UserID + "','" + usDTO.Name + "','" + usDTO.Address + "','" + usDTO.Phone + "');";
                
                SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                int rowsAffected = com.ExecuteNonQuery();


            }
            catch (SqlException ex)

            {

            }
            finally
            {
                dbCon.Con.Close();
            }
        }
        public void AddSupplierInDB(UserDTO usDTO)
        {
            try
            {
                dbCon.Con.Open();
                String qurystring = "INSERT INTO MyUser VALUES('" + usDTO.UserID + "','" + usDTO.Password + "','" + usDTO.Role + "');";
                SqlCommand com = new SqlCommand(qurystring, dbCon.Con);
                int rowsAffected = com.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                dbCon.Con.Close();
            }
        }
    }
}
