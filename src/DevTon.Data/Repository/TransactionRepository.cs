using DevTon.Business.Interfaces;
using DevTon.Business.Models;
using DevTon.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTon.Data.Repository
{
    public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
    {

        public TransactionRepository(DataContext context) : base(context) { }
       
        public Task<IEnumerable<Transaction>> GetTransactionPerCategory(Guid CategoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Transaction>> GetTransactionPerDate()
        {
            throw new NotImplementedException();
        }
    }
}
