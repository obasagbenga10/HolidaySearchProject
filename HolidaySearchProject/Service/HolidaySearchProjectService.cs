using HolidaySearchProject.Models;
using HolidaySearchProject.Repository;

namespace HolidaySearchProject.Service
{
    public class HolidaySearchProjectService : IHolidaySearchProjectService
    {
        private readonly IHolidaySearchProjectRepository _repository;

        public HolidaySearchProjectService()
        {
           _repository = new HolidaySearchProjectRepository();
        }
        public string BestHoliday(HolidaySearchProjectParams search)
        {
            var list = _repository.Get();

            string holidayId = default;

            if (search.DepartingFrom != "Any")
            {
                var orderedflights = list.Flights.OrderBy(t => t.Price).Where(s => (s.From == search.DepartingFrom && s.To == search.TravellingTo) && (s.Departure_date == search.DepartureDate)).ToList();

                var orderedHotels = list.Hotels.OrderBy(t => t.Price_per_night).Where(s => s.Local_airports.Contains(search.TravellingTo) && s.Arrival_date == search.DepartureDate && s.Nights == search.Duration).ToList();

                if (orderedHotels.Count() == 0 ||  orderedflights.Count() == 0)
                {
                    holidayId = "Sorry there are no available holidays. Please try again.";
                }
                else
                {
                    holidayId = $"Flight : {orderedflights.First().Id} Hotel : {orderedHotels.First().Id}";
                }
               
            }
            else
            {
                var orderedflights = list.Flights.OrderBy(t => t.Price).Where(s =>  s.To == search.TravellingTo && (s.Departure_date == search.DepartureDate)).ToList();

                var orderedHotels = list.Hotels.OrderBy(t => t.Price_per_night).Where(s => s.Local_airports.Contains(search.TravellingTo) && s.Arrival_date == search.DepartureDate && s.Nights == search.Duration).ToList();

                if (orderedHotels.Count() == 0 || orderedflights.Count() == 0)
                {
                    holidayId = "Sorry there are no available holidays. Please try again";
                }
                else
                {
                    holidayId = $"Flight : {orderedflights.First().Id} Hotel : {orderedHotels.First().Id}";
                }
            }

            return holidayId;
        }

    }
}
