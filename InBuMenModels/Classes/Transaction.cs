using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using InBuMenModels.Interfaces;

namespace InBuMenModels.Classes
{
    public class Transaction : ITransaction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Sku { get; set; }
        public Currency Value { get; set; }
    }
}
