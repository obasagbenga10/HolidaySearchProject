﻿
namespace HolidaySearchProject.Data
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime Arrival_date { get; set; }
        public int Price_per_night { get; set; }
        public List<string> Local_airports { get; set; } = null!;
        public int Nights { get; set; }
    }
}
