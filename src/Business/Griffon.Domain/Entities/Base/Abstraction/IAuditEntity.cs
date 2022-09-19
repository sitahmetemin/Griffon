namespace Griffon.Domain.Entities.Base.Abstraction
{
    public interface IAuditEntity<TPK> : IEntity<TPK>
    {
        DateTime CreatedDate { get; set; }
        DateTime EditedDate { get; set; }
        DateTime DeletedDate { get; set; }
    }
}
