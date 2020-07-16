using CurrencyProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyProject.BusinessLayer.Abstract
{
    interface ICurrencyService
    {
        CurrencyResponseModel GetFloatRates(string Base, string date);
    }
}
