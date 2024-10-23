using System;
using System.Data.SqlClient;

namespace HotelOpligatoriskOpgave{
    public class DBClient{
        public void Read(){
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string queryString = "select * from DemoHotel";
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
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string queryString = $"delete from DemoHotel where Hotel_No {Hotel_No}";
            using(SqlConnection connection = new SqlConnection(connectionString)){
                SqlCommand delete = new SqlCommand(queryString, connection);
                delete.Connection.Open();
                delete.ExecuteNonQuery();
            }
        }
        public void Reseed(){
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string queryString = "DBCC CHECKIDENT ('DemoHotel', RESEED, 0)";
            using(SqlConnection connection = new SqlConnection(connectionString)){
                SqlCommand reseed = new SqlCommand(queryString, connection);
                reseed.Connection.Open();
                reseed.ExecuteNonQuery();
            }
        }
        public void Insert(string HotelName, string HotelAddress){
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string queryString = $"Insert into DemoHotel Values('{HotelName}','{HotelAddress}')";

            using(SqlConnection connection = new SqlConnection(connectionString)){
                SqlCommand insert = new SqlCommand(queryString, connection);
                insert.Connection.Open();
                insert.ExecuteNonQuery();
            }
        }
    }
}
