namespace Griffon.Domain.DTOs.Base.Abstraction
{
    public interface IEntityDto<TP> : IDto
    {
        TP Id { get; set; }
    }
}
