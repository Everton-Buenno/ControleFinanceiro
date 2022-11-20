using DevTon.Business.Models;

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
