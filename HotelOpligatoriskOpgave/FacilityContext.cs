using System.Data.SqlClient;

namespace HotelOpligatoriskOpgave{
    public class FacilityContext{

        public void Create(string facilityName, int hotelId){
            string queryString = $"insert into Facility values ('{facilityName}')";
            using(SqlConnection connection = new SqlConnection(connectionString)){
                SqlCommand create = new SqlCommand(queryString, connection);
                create.Connection.Open();
                create.ExecuteNonQuery();
            }
        }
        public void Read(){
            string queryString = "select * from Facility";
            using(SqlConnection connection = new SqlConnection(connectionString)){
                SqlCommand read = new SqlCommand(queryString, connection);
                read.Connection.Open();
                SqlDataReader reader = read.ExecuteReader();

                while(reader.Read()){
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    int hotelId = reader.GetInt32(2);
                    Console.WriteLine($"Facility {id}: - {name} on hotel: {hotelId}");
                }
            }
        }
        public void Update(string facilityName, int hotelNo, int facilityId){
            string queryString = $"update Facility set Facility_Name= '{facilityName}', Hotel_No = '{hotelNo}' where Facility_Id = '{facilityId}'";
            using(SqlConnection connection = new SqlConnection(connectionString)){
                SqlCommand update = new SqlCommand(queryString, connection);
                update.Connection.Open();
                update.ExecuteNonQuery();
            }
        }
        public void Delete(int id){
            string queryString = $"delete from Facility where Facility_Id = '{id}'";
            using(SqlConnection connection = new SqlConnection(connectionString)){
                SqlCommand delete = new SqlCommand(queryString, connection);
                delete.Connection.Open();
                delete.ExecuteNonQuery();
            }
        }
    }
}
