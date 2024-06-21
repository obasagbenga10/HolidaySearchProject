using HolidaySearchProject.Service;
using HolidaySearchProject.Models;


namespace HolidaySearchProjectTests
{
    [TestClass]
    public class UnitTest1
    {
        private IHolidaySearchProjectService _searchService;
        public UnitTest1()
        {
            _searchService = new HolidaySearchProjectService();
        }
        [TestMethod]
        public void Test1()
        {
            var x = _searchService.BestHoliday(new HolidaySearchProjectParams { DepartingFrom = "MAN", TravellingTo = "AGP", DepartureDate = new DateTime(2023, 7, 1), Duration = 7 });

            Assert.AreEqual( "Flight : 2 Hotel : 9",x);
        }

        [TestMethod]
        public void Test2()
        {
            var x = _searchService.BestHoliday(new HolidaySearchProjectParams { DepartingFrom = "LGW", TravellingTo = "PMI", DepartureDate = new DateTime(2023, 6, 15), Duration = 10 });

            Assert.AreEqual( "Flight : 6 Hotel : 5",x);
        }

        [TestMethod]
        public void Test3()
        {
            var x = _searchService.BestHoliday(new HolidaySearchProjectParams { DepartingFrom = "Any", TravellingTo = "LPA", DepartureDate = new DateTime(2022, 11, 10), Duration = 14 });

            Assert.AreEqual("Flight : 7 Hotel : 6",x);
        }
    }
}