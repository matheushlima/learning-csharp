using System;
using System.Globalization;

namespace System
{
    static class DateTimeEnlapsed
    {
        public static string DateEnlapsed(this DateTime obj)
        {
            TimeSpan duration = DateTime.Now.Subtract(obj);
            if(duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
