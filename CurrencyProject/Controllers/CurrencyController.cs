using CurrencyProject.BusinessLayer;
using CurrencyProject.BusinessLayer.Concrete;
using CurrencyProject.Model;
using CurrencyProject.WebAPI.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace CurrencyProject.WebAPI.Controllers
{
    [Log]
    [Exc]
    public class CurrencyController : BaseApiController
    {
        [HttpGet, ActionName("currency")]
        public IHttpActionResult GetCurrency(string baseValue = null, string date = null)
        {
            if (Debugger.IsAttached)
                CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            CurrencyResponseModel currencyResponseModel = new CurrencyResponseModel();

            using (var currencyManager = new CurrencyManager())
            {
                currencyResponseModel = currencyManager.GetFloatRates(baseValue, date);
            }
            return Json(currencyResponseModel);
        }
    }
}