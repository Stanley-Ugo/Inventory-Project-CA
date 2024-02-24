using InventoryProject.Core.Entities.Base;
using System.Collections.Generic;

namespace InventoryProject.Core.Entities
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
