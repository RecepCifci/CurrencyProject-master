using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyProject.Model
{
    public class CurrencyRequestModel : BaseRequestModel
    {
        public string Base { get; set; }
        public string date { get; set; }
    }
}
