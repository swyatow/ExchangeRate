using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRate.Entity
{
    public class Favourite
    {
        [Key]
        public string favLetterCode { get; set; }
    }
}
