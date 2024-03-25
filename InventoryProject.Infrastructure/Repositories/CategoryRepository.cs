using InventoryProject.Core.Entities;
using InventoryProject.Core.Repositories;
using InventoryProject.Infrastructure.Data;
using InventoryProject.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryProject.Infrastructure.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly MainDBContext _mainDBContext;
        public CategoryRepository(MainDBContext mainDBContext) : base(mainDBContext)
        {
            _mainDBContext = mainDBContext;
        }
        public async Task<Category> GetCategoryByName(string categoryName)
        {
            return await _mainDBContext.Categories
                .Where(x => x.Name == categoryName).FirstOrDefaultAsync();
        }
    }
}
