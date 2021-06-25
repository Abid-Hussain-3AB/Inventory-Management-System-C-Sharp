using IMS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DL
{
    class EmployeeDL
    {
        DBConnection dbCon;


        public EmployeeDL()
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
                    string queryString = "SELECT Food.ItemID, Food.ItemType , Food.ItemName, Food.ItemCompany , Food.ItemPrice, Food.ItemWeight, Food.ItemMfgDate, Food.ItemexpDate, Food.ItemRemaining FROM Food";
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
                    string queryString = "SELECT Beauty.ItemId, Beauty.ItemType, Beauty.ItemName, Beauty.ItemCompany, Beauty.ItemPrice, Beauty.ItemRemaining FROM Beauty";
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

        internal void ADAcceptedOrderDB(SupplirDTO aSDTO)
        {
            throw new NotImplementedException();
        }

        public DataTable ViewKidsOnly()
        {
            {
                DataTable dt = new DataTable();
                try
                {
                    dbCon.Con.Open();
                    string queryString = "SELECT Kids.ItemId, Kids.ItemType, Kids.ItemName, Kids.ItemPrice, Kids.ItemRemaining FROM Kids";
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
                    string queryString = "SELECT Computing.ItemId, Computing.ItemType , Computing.ItemCompany , Computing.ItemPrice, Computing.ItemRemaining FROM Computing";
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


        public DataTable ViewOrderInDB()
        {
            {
                DataTable dt = new DataTable();
                try
                {
                    dbCon.Con.Open();
                    string queryString = "SELECT Supplir.ItemName, Supplir.CompanyName, Supplir.ItemQuantity From Supplir";
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
        public void DelItemInDB(AddItemsDTO crDTO)
        {
            try
            {
                dbCon.Con.Open();
                string queryString = "update Food SET ItemRemaining= ItemRemaining-1 where ItemID = @Itemid";
                SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                com.Parameters.AddWithValue("@Itemid", crDTO.ItemName);
                int rowAffected = com.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dbCon.Con.Close();
            }
        }

        public void DelSupplirOrderDB(AddItemsDTO crDTO)
        {
            try
            {
                dbCon.Con.Open();
                string queryString = "delete Supplir where ItemName = @ItemName";
                SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                com.Parameters.AddWithValue("@ItemName", crDTO.ItemName);
                int rowAffected = com.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dbCon.Con.Close();
            }
        }


        public void DelIBeautyInDB(AddItemsDTO crDTO)
        {
            try
            {
                dbCon.Con.Open();
                string queryString = "delete Beauty where ItemId = @Itemid";
                SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                com.Parameters.AddWithValue("@Itemid", crDTO.ItemName);
                int rowAffected = com.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dbCon.Con.Close();
            }
        }


        public void DelkidsInDB(AddItemsDTO crDTO)
        {
            try
            {
                dbCon.Con.Open();
                string queryString = "delete Kids where ItemId = @Itemid";
                SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                com.Parameters.AddWithValue("@Itemid", crDTO.ItemName);
                int rowAffected = com.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dbCon.Con.Close();
            }
        }


        public void DelgamesInDB(AddItemsDTO crDTO)
        {
            try
            {
                dbCon.Con.Open();
                string queryString = "delete Computing where ItemId = @Itemid";
                SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                com.Parameters.AddWithValue("@Itemid", crDTO.ItemName);
                int rowAffected = com.ExecuteNonQuery();
  

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dbCon.Con.Close();
            }
        }

       

        public void AddFoodInDB(FoodDTO fDTO)
        {
            try
            {
                dbCon.Con.Open();
                String qurystring = "INSERT INTO Food VALUES('" + fDTO.ItemId + "','" + fDTO.Itemtype + "','" + fDTO.ItemName + "','" + fDTO.Itemcompany + "','" + fDTO.Itemprice + "','" + fDTO.Itemweight + "','" + fDTO.MfgDate + "','" + fDTO.ExpDate + "','" + fDTO.Itemremain + "');";
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

        public void AddbeautyInDB(beautyDTO bDTO)
        {

            try
            {
                dbCon.Con.Open();
                String qurystring = "INSERT INTO Beauty VALUES('" + bDTO.Itemid + "','" + bDTO.Itemtype + "','" + bDTO.ItemName + "','" + bDTO.Itemcompany + "','" + bDTO.Itemprice + "','" + bDTO.Itemremain + "');";
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
        public void AddKidsInDB(kidsDTO kDTO)
        {

            try
            {
                dbCon.Con.Open();
                String qurystring = "INSERT INTO Kids VALUES('" + kDTO.ItemId + "','" + kDTO.Itemtype + "','" + kDTO.ItemName + "','" + kDTO.Itemprice + "','" + kDTO.Itemremain + "');";
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
        public void AddgameInDB(gameDTO gDTO)
        {

            try
            {
                dbCon.Con.Open();
                String qurystring = "INSERT INTO Computing VALUES('" + gDTO.ItemID1 + "','" + gDTO.Itemtype + "','" + gDTO.Itemcompany1 + "','" + gDTO.Itemprice1 + "','" + gDTO.ItemRemaining + "');";
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
        public void OrderSupplir(SupplirDTO SDTO)
        {

            try
            {
                dbCon.Con.Open();
                String qurystring = "INSERT INTO Supplir VALUES('" + SDTO.ItemName + "','" + SDTO.CompanyName + "','" + SDTO.Quantity + "');";
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

        public void ADAcceptedOrderDB(AcceptOrder AODTO)
        {

            try
            {
                dbCon.Con.Open();
                String qurystring = "INSERT INTO AcceptOrder VALUES('" + AODTO.ItemName + "','" + AODTO.CompanyName + "','" + AODTO.Quantity + "');";
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
