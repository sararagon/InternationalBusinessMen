using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using InBuMenModels.Interfaces;

namespace InBuMenModels.Classes
{
    public class Currency : ICurrency
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Amount { get; set; }
        public string CurrencyName { get; set; }
    }
}
