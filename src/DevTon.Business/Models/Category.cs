using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTon.Business.Models
{
    public class Category : Entity
    {

        public string Name { get; set; }

        public string Image { get; set; }

        public TypeTransaction TypeTransaction { get; set; }

        public IEnumerable <Transaction> Transactions { get; set; }

    }
}
