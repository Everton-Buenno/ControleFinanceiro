using DevTon.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTon.Business.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : Entity
    {


        Task Add(TEntity entity);

        Task Update(TEntity entity);

        Task Delete(Guid id);

        Task<List<TEntity>> GetAll();

        Task<TEntity> FindById(Guid id);

        Task<int> SaveChanges();
    }
}
