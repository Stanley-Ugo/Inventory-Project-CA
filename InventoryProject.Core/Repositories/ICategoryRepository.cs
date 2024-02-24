using InventoryProject.Core.Entities;
using InventoryProject.Core.Repositories.Base;
using System.Threading.Tasks;

namespace InventoryProject.Core.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category> GetCategoryByName(string categoryName);
    }
}
