using System;

namespace Persistence.Models
{
    public class Transactions
    {
        public string ShopName { get; set; }

        public decimal Amount { get; set; }

        public DateTime DateCreated { get; set; }
    }
}