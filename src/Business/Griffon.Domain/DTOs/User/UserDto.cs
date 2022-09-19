using Griffon.Domain.DTOs.Base;

namespace Griffon.Domain.DTOs.User
{
    public class UserDto : AuditEntityDto<Guid>
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public string About { get; set; }
        public string PhoneNumber { get; set; }
        public string Socials { get; set; }
    }
}