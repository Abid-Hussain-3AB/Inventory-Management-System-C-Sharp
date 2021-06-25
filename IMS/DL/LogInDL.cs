using IMS.DTO;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DL
{
    class LogInDL
    {
        DBConnection dbCon;

        public LogInDL()
        {
            dbCon = new DBConnection();
        }
        public UserDTO VerifyUserFromDB(LogInDTO lg)
        {
            UserDTO usDTO = new UserDTO();

            try
            {
               
                dbCon.Con.Open();

                string queryString = "SELECT * FROM MyUser WHERE UserID=@UserID AND Password=@Password;";

                SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                com.Parameters.AddWithValue("@UserID", lg.Username);
                com.Parameters.AddWithValue("@Password", lg.Password);
                SqlDataReader reader = com.ExecuteReader();
               
                while (reader.Read())
                {
                    usDTO.UserID = reader["UserID"].ToString();
                    usDTO.Password = reader["Password"].ToString();
                    usDTO.Role = reader["Role"].ToString();
                    return usDTO;
                }
            }
            catch (SqlException ex)
            {
                return null;


            }
            finally
            {

                dbCon.Con.Close();
            }
            return null;


        }



    
}
}
