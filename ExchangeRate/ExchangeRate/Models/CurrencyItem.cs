using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeRate.Models
{
    public class CurrencyItem
    {
        public string LetterCode { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int Nominal { get; set; }

        public double DifInCurrency { get; set; }

        public double DifInPercent { get; set; }

        public bool NA { get; set; }

        public CurrencyItem() {}
    }
}
