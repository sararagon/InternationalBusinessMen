using System;
using System.Collections.Generic;
using System.Text;

namespace InBuMenModels.Classes
{
    public class Transaction : ITransaction
    {
        public string Sku { get; set; }
        public Currency Value { get; set; }
    }
}
