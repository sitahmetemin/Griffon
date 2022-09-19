using Griffon.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griffon.Domain.Entities
{
    public class User : AuditEntity<Guid>
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string About { get; set; }
        public string PhoneNumber { get; set; }
        public string Socials { get; set; }
    }
}
