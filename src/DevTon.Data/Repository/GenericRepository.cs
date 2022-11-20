using DevTon.Business.Interfaces;
using DevTon.Business.Models;
using DevTon.Data.Context;
using Microsoft.EntityFrameworkCore;


namespace DevTon.Data.Repository
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : Entity, new()
    {

        protected readonly DataContext _context;
        protected readonly DbSet<TEntity> DbSet;


        protected GenericRepository(DataContext context)
        {
            _context = context;
            DbSet = context.Set<TEntity>();
        }


        public async Task Add(TEntity entity)
        {
           DbSet.Add(entity);
            await SaveChanges();
        }

        public async Task Delete(Guid id)
        {
            DbSet.Remove(new TEntity { Id = id });
            await SaveChanges();
        }

        public async Task<TEntity> FindById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task Update(TEntity entity)
        {
            DbSet.Update(entity);
            await SaveChanges();
        }
    }
}
