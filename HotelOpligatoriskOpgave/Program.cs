namespace HotelOpligatoriskOpgave
{
    public class Program
    {
        static void Main(string[] args)
        {
            DBClient dbc = new DBClient();
            //dbc.Reseed();
            dbc.Insert("MixiHotel", "MixiStreet");
            dbc.Insert("MaxHotel", "MaxStreet");
            dbc.Read();
        }
    }
}
