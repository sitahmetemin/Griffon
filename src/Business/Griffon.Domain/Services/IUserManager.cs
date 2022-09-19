using Griffon.Domain.DTOs.User;
using Griffon.Domain.Entities;
using Griffon.Domain.Services.Base;

namespace Griffon.Domain.Services
{
    public interface IUserManager : IBaseManager<Guid, User, UserDto>
    {
    }
}