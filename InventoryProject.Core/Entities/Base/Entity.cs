using System;

namespace InventoryProject.Core.Entities.Base
{
    public abstract class Entity : EntityBase<int>
    {
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateModified { get; set; }
        public string  ModifiedBy { get; set; }
    }
}
