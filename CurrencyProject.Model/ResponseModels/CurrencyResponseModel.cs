using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyProject.Model
{
    public class CurrencyResponseModel: BaseResponseModel
    {
        public string Base { get; set; }
        public Dictionary<string, decimal> Rates { get; set; }
    }
}
