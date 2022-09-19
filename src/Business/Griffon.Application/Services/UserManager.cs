using Griffon.Application.Services.Base;
using Griffon.Domain.DTOs.User;
using Griffon.Domain.Entities;
using Griffon.Domain.Repositories.Base;
using Griffon.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griffon.Application.Services
{
    public class UserManager : BaseManager<Guid, User, UserDto>, IUserManager
    {
        public UserManager(IBaseRepository<Guid, User> baseRepository) : base(baseRepository)
        {
        }
    }
}
