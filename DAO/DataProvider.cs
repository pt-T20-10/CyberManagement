using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberManagementProject.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;


        public static DataProvider Instance 
        { 
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        string connectionSTR = @"Data Source=ACER\MSSQLSERVER03;Initial Catalog=CyberManagement;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;";
        //Data Source=ACER\MSSQLSERVER03;Initial Catalog=CyberManagement;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;

        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand comand = new SqlCommand(query, connection);


                if (parameter != null) 
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            comand.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }

                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(comand);

                try
                {
                    adapter.Fill(data); // Kiểm tra xem có lỗi tại đây không
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);
                }

                connection.Close();
            }  
            return data;
        }

        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand comand = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            comand.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }

                    }
                }
                data = comand.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand comand = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            comand.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }

                    }
                }
                data = comand.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
