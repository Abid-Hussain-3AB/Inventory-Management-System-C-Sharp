using System;
using System.Data.SqlClient;

namespace IMS.DL
{
    internal class DBConnection
    {

        private SqlConnection con;
        public DBConnection()
        {

            string Path = System.Environment.CurrentDirectory;
            string[] appPath = Path.Split(new string[] { "bin" }, StringSplitOptions.None);
            AppDomain.CurrentDomain.SetData("DataDirectory", appPath[0]);
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + appPath[0] + @"IMS.mdf;Integrated Security=True";

            con = new SqlConnection(conString);
        }

        public SqlConnection Con { get => con; }
    }
}