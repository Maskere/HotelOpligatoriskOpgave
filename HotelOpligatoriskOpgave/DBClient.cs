using System;
using System.Data.SqlClient;

namespace HotelOpligatoriskOpgave{
    public class DBClient{
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelObligatoriskOpgave;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void Read(){
            string queryString = "select * from Hotel";
            using(SqlConnection connection = new SqlConnection(connectionString)){
                SqlCommand read = new SqlCommand(queryString, connection);
                read.Connection.Open();
                SqlDataReader reader = read.ExecuteReader();
                
                while(reader.Read()){
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string street = reader.GetString(2);
                    Console.WriteLine($"{id} - {name} - {street}");
                }
            }
        }
        public void Delete(int Hotel_No){
            string queryString = $"delete from Hotel where Hotel_No = '{Hotel_No}'";
            using(SqlConnection connection = new SqlConnection(connectionString)){
                SqlCommand delete = new SqlCommand(queryString, connection);
                delete.Connection.Open();
                delete.ExecuteNonQuery();
            }
        }
        public void Create(string HotelName, string HotelAddress){
            string queryString = $"Insert into Hotel Values ('{HotelName}','{HotelAddress}')";
            using(SqlConnection connection = new SqlConnection(connectionString)){
                SqlCommand insert = new SqlCommand(queryString, connection);
                insert.Connection.Open();
                insert.ExecuteNonQuery();
            }
        }
        public void Update(int Hotel_No,string HotelName, string HotelAddress){
            string queryString = $"update Hotel set Name= '{HotelName}', Address = '{HotelAddress}' where Hotel_No = '{Hotel_No}'";
            using(SqlConnection connection = new SqlConnection(connectionString)){
                SqlCommand update = new SqlCommand(queryString, connection);
                update.Connection.Open();
                update.ExecuteNonQuery();
            }
        }
    }
}
