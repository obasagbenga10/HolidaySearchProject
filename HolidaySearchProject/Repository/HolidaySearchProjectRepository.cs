using HolidaySearchProject.Data;
using Newtonsoft.Json;

namespace HolidaySearchProject.Repository
{
    public class HolidaySearchProjectRepository : IHolidaySearchProjectRepository
    {
        public HolidaySearchProjectList Get()
        {
            StreamReader r = new StreamReader("Data\\flight_data.json");
            string flightJsonString = r.ReadToEnd();
            IEnumerable<Flight> flightsList = JsonConvert.DeserializeObject<IEnumerable<Flight>>(flightJsonString);

            StreamReader t = new StreamReader("Data\\hotel_data.json");
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
