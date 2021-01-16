using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Extensions
{
    public static class DateTimeExtentions
    {
        public static int CalculateAge(this DateTime birthDare)
        {
            var today = DateTime.Today;
            var age = today.Year - birthDare.Year;
            if (birthDare.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}
