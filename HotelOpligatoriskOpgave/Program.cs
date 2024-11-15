namespace HotelOpligatoriskOpgave
{
    public class Program{
        static void Main(string[] args){
            DBClient dbc = new DBClient();

            Console.WriteLine();

            FacilityContext fContext = new FacilityContext();
            //fContext.Create("SwimmingPool");
            //fContext.Delete(2);
            //fContext.Update("BowlingHall", 1);
            fContext.Read();
        }
    }
}
