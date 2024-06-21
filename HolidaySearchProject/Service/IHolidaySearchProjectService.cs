using HolidaySearchProject.Models;

namespace HolidaySearchProject.Service
{
    public interface IHolidaySearchProjectService
    {
        string BestHoliday(HolidaySearchProjectParams search);
    }
}
