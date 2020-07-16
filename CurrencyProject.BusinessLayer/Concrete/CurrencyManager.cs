using CurrencyProject.BusinessLayer.Abstract;
using CurrencyProject.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CurrencyProject.BusinessLayer.Concrete
{
    public class CurrencyManager : IDisposable, ICurrencyService
    {
        public CurrencyResponseModel GetFloatRates(string Base, string date)
        {
            Base = String.IsNullOrEmpty(Base) ? ConfigurationManager.AppSettings["baseCurrency"] : Base;
            date = String.IsNullOrEmpty(date) ? DateTime.Now.ToString("yyyy-MM-dd") : date;

            string apiUrl = String.Format(ConfigurationManager.AppSettings["apiUrl"], date, Base);

            XDocument xmlDoc = XDocument.Load(apiUrl);

            return ConvertToResponse(xmlDoc);
        }
        private CurrencyResponseModel ConvertToResponse(XDocument xmlDoc)
        {
            CurrencyResponseModel currencyModel = new CurrencyResponseModel();
            CultureInfo culture = new CultureInfo("en-US");

            currencyModel.Base = xmlDoc.Element("channel").Element("baseCurrency").Value;
            currencyModel.Rates = xmlDoc.Descendants("channel").Elements("item").ToDictionary(
                                                                        x => x.Element("targetCurrency").Value,
                                                                        x => Math.Round(1 / Convert.ToDecimal(x.Element("exchangeRate").Value, culture), 4));
            return currencyModel;
        }

        public void Dispose()
        {
        }
    }
}
