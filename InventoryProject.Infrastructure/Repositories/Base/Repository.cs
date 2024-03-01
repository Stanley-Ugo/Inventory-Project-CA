using InventoryProject.Core.Entities.Base;
using InventoryProject.Core.Repositories.Base;
using InventoryProject.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryProject.Infrastructure.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly MainDBContext _mainDBContext;
        public Repository(MainDBContext mainDBContext)
        {
            _mainDBContext = mainDBContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _mainDBContext.Set<T>().AddAsync(entity);
            await _mainDBContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _mainDBContext.Set<T>().Remove(entity);
            await _mainDBContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _mainDBContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _mainDBContext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _mainDBContext.Entry(entity).State = EntityState.Modified;
            await _mainDBContext.SaveChangesAsync();
        }
    }
}
