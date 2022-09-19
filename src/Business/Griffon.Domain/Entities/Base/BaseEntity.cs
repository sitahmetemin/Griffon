using Griffon.Domain.Entities.Base.Abstraction;

namespace Griffon.Domain.Entities.Base
{
    public class BaseEntity<TPK> : IEntity<TPK>
    {
        public TPK Id { get; set; }
    }
}
