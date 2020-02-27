using System;
using System.Collections.Generic;
using System.Text;
using InBuMenModels.Interfaces;

namespace InBuMenModels.Classes
{
    public class JsonTransactionGroup : IJsonTransactionGroup
    {
        public List<IJsonTransaction> Transactions { get; set; }
    }

}
