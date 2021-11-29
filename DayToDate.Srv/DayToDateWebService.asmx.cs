using DayToDate.Srv.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DayToDate.Srv
{
    /// <summary>
    /// Summary description for DayToDateWebService
    /// </summary>
    [WebService(Namespace = "https://wiltodaytodate.azurewebsites.net")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DayToDateWebService : System.Web.Services.WebService
    {
        private static NextDayDateFinder _dateFinder = new NextDayDateFinder();

        [WebMethod]
        public string DayNextDate(string dayname)
        {
            DateTime nextDate = _dateFinder.GetNextDate(dayname);
            return nextDate.ToString(DateFinderConstants.DefaultDateFormat);
        }
    }
}
