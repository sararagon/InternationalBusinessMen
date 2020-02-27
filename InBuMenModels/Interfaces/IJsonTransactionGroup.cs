using System.Collections.Generic;

namespace InBuMenModels.Classes
{
    public interface IJsonTransactionGroup
    {
        List<IJsonTransaction> Transactions { get; set; }
    }
}