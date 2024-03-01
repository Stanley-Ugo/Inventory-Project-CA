using InventoryProject.Core.Entities;
using InventoryProject.Core.Repositories;
using InventoryProject.Infrastructure.Data;
using InventoryProject.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryProject.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly MainDBContext _mainDBContext;
        public ProductRepository(MainDBContext mainDBContext) : base(mainDBContext)
        {
            _mainDBContext = mainDBContext;
        }
        public async Task<Product> GetProductByName(string productName)
        {
            return await _mainDBContext.Products
                .Where(x => x.Name == productName).FirstOrDefaultAsync();
        }
    }
}
