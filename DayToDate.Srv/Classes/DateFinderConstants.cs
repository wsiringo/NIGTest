using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DayToDate.Srv.Classes
{
    public class DateFinderConstants
    {
        public static string DefaultDateFormat = "dd/MM/yyyy"; // output date format is defined as a constant to enforce consistency
        public static DateTime DefaultInvalidResult = DateTime.MinValue; // default value for invalid input
    }
}