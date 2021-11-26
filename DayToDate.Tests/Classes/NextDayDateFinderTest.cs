using DayToDate.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DayToDate.Tests.Classes
{
    // these tests validate the logic used by NextDayDateFinder class, which is the core part of this web application
    [TestClass]
    public class NextDayDateFinderTest
    {
        // proof of concept code to assist constructing NextDayDateFinder class
        [TestMethod]
        public void NextDayDateFinder_KnownStaticDay_Friday()
        {
            DateTime dt = new DateTime(2021, 11, 26);
            Assert.AreEqual(dt.DayOfWeek, DayOfWeek.Friday);
        }

        // proof of concept code to assist constructing NextDayDateFinder class
        [TestMethod]
        public void NextDayDateFinder_KnownStaticDay_Friday_String()
        {
            DateTime dt = new DateTime(2021, 11, 26);
            Assert.AreEqual(dt.DayOfWeek.ToString().ToUpper(), "FRIDAY");
        }

        // validating sample output of NextDayDateFinder method GetNextDate
        [TestMethod]
        public void NextDayDateFinder_KnownStaticDay_Next_Saturday()
        {
            DateTimeOffset dt = new DateTimeOffset(new DateTime(2021, 11, 26));
            NextDayDateFinder dateFinder = new NextDayDateFinder();
            DateTime nextDate = dateFinder.GetNextDate("saturday", dt);
            Assert.AreEqual(nextDate, new DateTime(2021, 11, 27));
        }

        // validating sample output of NextDayDateFinder method GetNextDate
        [TestMethod]
        public void NextDayDateFinder_KnownStaticDay_Next_Monday()
        {
            DateTimeOffset dt = new DateTimeOffset(new DateTime(2021, 11, 26));
            NextDayDateFinder dateFinder = new NextDayDateFinder();
            DateTime nextDate = dateFinder.GetNextDate("MondaY", dt);
            Assert.AreEqual(nextDate, new DateTime(2021, 11, 29));
        }

        // validating sample output of NextDayDateFinder method GetNextDate
        [TestMethod]
        public void NextDayDateFinder_KnownStaticDay_Next_Friday()
        {
            DateTimeOffset dt = new DateTimeOffset(new DateTime(2021, 11, 26));
            NextDayDateFinder dateFinder = new NextDayDateFinder();
            DateTime nextDate = dateFinder.GetNextDate("Friday", dt);
            Assert.AreEqual(nextDate, new DateTime(2021, 12, 3));
        }


    }
}
