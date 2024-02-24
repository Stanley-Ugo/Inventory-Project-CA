namespace InventoryProject.Core.Entities.Base
{
    public interface IEntityBase<Tid>
    {
        Tid Id { get; }
    }
}
