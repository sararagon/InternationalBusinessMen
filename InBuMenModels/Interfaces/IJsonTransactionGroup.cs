using System.Collections.Generic;

namespace InBuMenModels.Interfaces
{
    public interface IJsonTransactionGroup
    {
        List<IJsonTransaction> Transactions { get; set; }
    }
}