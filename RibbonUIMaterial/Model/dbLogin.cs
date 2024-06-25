using System;
using System.Data;
using System.Data.SqlClient;

namespace RibbonUIMaterial.Model
{
    class dbLogin
    {
        static string strCon = @"Data Source=msi\sqlexpress;Initial Catalog=TodoLists;Integrated Security=True;";

        public static DataTable Login(string _username, string _password)
        {
            DataTable table1 = new DataTable();

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();

                    // Example SQL query to check username and password
                    string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@Username", _username);
                        cmd.Parameters.AddWithValue("@Password", _password);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(table1);
                    }
                }

                // Check if any rows were returned (indicating successful login)
                if (table1.Rows.Count > 0)
                {
                    return table1; // Login successful, return DataTable
                }
                else
                {
                    return null; // Login failed, return null or handle appropriately
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., logging)
                Console.WriteLine("Exception: " + ex.Message);
                return null; // Return null on exception
            }
        }
    }
}
