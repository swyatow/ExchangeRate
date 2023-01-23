using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRate.Models
{
    public static class CurrencyList
    {
        public static List<CurrencyItem> List = new List<CurrencyItem>();

        public static List<CurrencyItem> GetList() => List;
    }
}
