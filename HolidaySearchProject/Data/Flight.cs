
namespace HolidaySearchProject.Data
{
    public class Flight
    {
        public int Id { get; set; }
        public string Airline { get; set; } = null!;
        public string From { get; set; } = null!;
        public string To { get; set; } = null!;
        public int Price { get; set; }
        public DateTime Departure_date { get; set; }
    }
}
