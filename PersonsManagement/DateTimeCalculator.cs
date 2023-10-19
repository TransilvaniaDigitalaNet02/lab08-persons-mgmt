using Microsoft.VisualBasic;

namespace PersonsManagement
{
    internal static class DateTimeCalculator
    {
        public static long YearsDiff(DateTime dateTime1, DateTime dateTime2)
        {
            long yearsDiff = Math.Abs(DateAndTime.DateDiff(DateInterval.Year, dateTime1, dateTime2));
            return yearsDiff;
        }
    }
}
