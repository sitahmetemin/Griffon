using Griffon.Domain.DTOs.Base.Abstraction;

namespace Griffon.Domain.DTOs.Base
{
    public class AuditEntityDto<TP> : EntityDto<TP>, IAuditEntityDto<TP>
    {
        public DateTime CreatedDate { get; set; }
        public DateTime EditedDate { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
