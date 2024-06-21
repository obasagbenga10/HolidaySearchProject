
namespace HolidaySearchProject.Data
{
    public class Flight
    {
        public int Id { get; set; }
        public string Airline { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int Price { get; set; }
        public DateTime Departure_date { get; set; }
    }
}
