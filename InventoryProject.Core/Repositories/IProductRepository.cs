using InventoryProject.Core.Entities;
using InventoryProject.Core.Repositories.Base;
using System.Threading.Tasks;

namespace InventoryProject.Core.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetProductByName(string productName);
    }
}
