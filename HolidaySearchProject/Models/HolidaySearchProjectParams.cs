
namespace HolidaySearchProject.Models
{
    public class HolidaySearchProjectParams
    {
        public string DepartingFrom { get; set; } = null!;
        public string TravellingTo { get; set; } = null!;
        public DateTime DepartureDate { get; set; }
        public int Duration { get; set; }

    }
}
