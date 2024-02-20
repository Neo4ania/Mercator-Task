using System.Globalization;

namespace ProvidusMerchantAPI.Domain.DTOs
{
    public class FilterByTimeDTO
    {
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int Year => Date.Year;
        public int Month => Date.Month;
        public int Week => CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
            Date,
            CultureInfo.CurrentCulture.DateTimeFormat.CalendarWeekRule,
            CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek);
    }
}
