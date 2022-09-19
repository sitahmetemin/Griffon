using Griffon.Domain.Entities.Base.Abstraction;

namespace Griffon.Domain.Entities.Base
{
    public class AuditEntity<TP> : BaseEntity<TP>, IAuditEntity<TP>
    {
        public DateTime CreatedDate { get; set; }
        public DateTime EditedDate { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
