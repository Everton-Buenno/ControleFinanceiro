using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTon.Business.Models
{
    public class Transaction : Entity
    {
        public Guid CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Value { get; set; }

        public DateTime TransactionDate { get; set; }

        public Category Category { get; set; }
    }
}
