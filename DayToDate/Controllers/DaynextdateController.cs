using DayToDate.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace DayToDate.Controllers
{
    public class DaynextdateController : ApiController
    {
        // it is safe to use a shared single instance of NextDayDateFinder as its operations are not dependant
        // on caller's state
        private static NextDayDateFinder _dateFinder = new NextDayDateFinder();

        // a default response to parameterless GET request
        public string Get()
        {
            return DateFinderConstants.DefaultInvalidResult.ToString(DateFinderConstants.DefaultDateFormat);
        }

        // the handler for legitimate GET request with string input parameter
        public string Get(string inputstring)
        {
            DateTime nextDate = _dateFinder.GetNextDate(inputstring);
            return nextDate.ToString(DateFinderConstants.DefaultDateFormat);
        }
    }
}