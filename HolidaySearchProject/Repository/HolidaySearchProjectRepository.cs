using HolidaySearchProject.Data;
using Newtonsoft.Json;

namespace HolidaySearchProject.Repository
{
    public class HolidaySearchProjectRepository : IHolidaySearchProjectRepository
    {
        public HolidaySearchProjectList Get()
        {
            var pathFlight = Path.Combine("Data", "flight_data.json");
            StreamReader r = new StreamReader(pathFlight);
            string flightJsonString = r.ReadToEnd();
            IEnumerable<Flight> flightsList = JsonConvert.DeserializeObject<IEnumerable<Flight>>(flightJsonString);

            var pathHotel = Path.Combine("Data", "hotel_data.json");
            StreamReader t = new StreamReader(pathHotel);
            string hotelJsonString = t.ReadToEnd();
            IEnumerable<Hotel> hotelsList = JsonConvert.DeserializeObject<IEnumerable<Hotel>>(hotelJsonString);

            HolidaySearchProjectList list = new HolidaySearchProjectList
            {
                Flights = flightsList,
                Hotels = hotelsList,
            };
            return list;
        }
    }
}
