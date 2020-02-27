using System;
using System.Collections.Generic;
using System.Text;
using InBuMenModels.Interfaces;

namespace InBuMenModels.Classes
{
    public class Currency : ICurrency
    {
        public int Amount { get; set; }
        public string CurrencyName { get; set; }
    }
}
