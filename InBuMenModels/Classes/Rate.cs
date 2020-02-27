using System;
using System.Collections.Generic;
using System.Text;

namespace InBuMenModels.Classes
{
    public class Rate : IRate
    {
        public string FromCurrency { get; set; }
        public string ToCurrency { get; set; }
        public int value { get; set; }
    }
}
