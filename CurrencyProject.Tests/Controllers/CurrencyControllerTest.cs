using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyProject;
using CurrencyProject.WebAPI.Controllers;
using System.Diagnostics;
using System.Globalization;

namespace CurrencyProject.Tests.Controllers
{
    [TestClass]
    public class CurrencyControllerTest
    {
        [TestMethod]
        public void CheckIfNullWithEmptyParameter()
        {
            CurrencyController controller = new CurrencyController();

            IHttpActionResult result = controller.GetCurrency();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CheckIfNullWithParameter()
        {
            CurrencyController controller = new CurrencyController();

            IHttpActionResult result = controller.GetCurrency("TRY",DateTime.Now.ToString("yyyy-MM-dd"));

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CheckIfNullWithUSDParameter()
        {
            CurrencyController controller = new CurrencyController();

            IHttpActionResult result = controller.GetCurrency("USD", DateTime.Now.ToString("yyyy-MM-dd"));

            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void CheckIfNullWithUSDParameterAndPastDate()
        {
            CurrencyController controller = new CurrencyController();

            IHttpActionResult result = controller.GetCurrency("USD", DateTime.Now.AddDays(-55).ToString("yyyy-MM-dd"));

            Assert.IsNotNull(result);
        }
    }
}
