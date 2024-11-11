namespace HotelOpligatoriskOpgave
{
    public class Program
    {
        static void Main(string[] args)
        {
            DBClient dbc = new DBClient();
            //dbc.Create("MixiHotel", "MixiStreet");
            dbc.Update(5,"JullieHotel", "JullieStreet");
            //dbc.Delete(3);
            dbc.Read();

            FacilityContext fContext = new FacilityContext();
            //fContext.Create("SwimmingPool", 3);
            //fContext.Delete(5);
            fContext.Update("BowlingHall", 3, 4);
            fContext.Read();
        }
    }
}
