namespace Griffon.Domain.Entities.Base.Abstraction
{
    public interface IEntity<TPK>
    {
        TPK Id { get; set; }
    }
}
