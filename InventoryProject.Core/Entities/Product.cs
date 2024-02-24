using InventoryProject.Core.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryProject.Core.Entities
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set;  }
    }
}
