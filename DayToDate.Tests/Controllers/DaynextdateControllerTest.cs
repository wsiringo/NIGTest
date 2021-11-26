using DayToDate;
using DayToDate.Classes;
using DayToDate.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace DayToDate.Tests.Controllers
{
    [TestClass]
    public class DaynextdateControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            DaynextdateController controller = new DaynextdateController();

            // Act
            string result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(DateFinderConstants.DefaultInvalidResult.ToString(DateFinderConstants.DefaultDateFormat), result);
        }

    }
}
