using Griffon.Domain.DTOs.Base.Abstraction;

namespace Griffon.Domain.DTOs.Base
{
    public class EntityDto<TP> : IEntityDto<TP>
    {
        public TP Id { get; set; }
    }
}
