﻿namespace InBuMenModels.Interfaces
{
    public interface IJsonTransaction
    {
        string Sku { get; set; }
        string Amount { get; set; }
        string Currency { get; set; }
    }
}