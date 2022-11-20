using DevTon.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTon.Business.Interfaces
{
    internal interface ITransactionRepository : IGenericRepository<Transaction>
    {
        Task<IEnumerable<Transaction>> GetTransactionPerCategory(Guid CategoryId);
        Task<IEnumerable<Transaction>> GetTransactionPerDate();
    }
}
