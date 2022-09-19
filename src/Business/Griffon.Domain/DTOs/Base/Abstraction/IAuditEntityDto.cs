namespace Griffon.Domain.DTOs.Base.Abstraction
{
    public interface IAuditEntityDto<TP> : IEntityDto<TP>
    {
        DateTime CreatedDate { get; set; }
        DateTime EditedDate { get; set; }
        DateTime DeletedDate { get; set; }
    }
}
