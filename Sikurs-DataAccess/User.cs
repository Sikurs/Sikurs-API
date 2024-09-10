using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sikurs_DataAccess.Base;

namespace Sikurs_DataAccess
{
    public class User : BaseEntity
    {
        public string LastName { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string? FatherName { get; set; }
        public DateOnly DateBirth { get; set; }
        public string Email { get; set; } = default!;
        public string? PhoneNumber { get; set; }
        public string? TelegramId { get; set; }
        public string Password { get; set; } = default!;
        public bool IsBlocked { get; set; }

        public Guid RoleId { get; set; }
        public Role Role { get; set; } = default!;

        public Guid OrganizationId { get; set; }
        public Organization Organization { get; set; } = default!;

        public ICollection<Organization> ResponsibleOrganizations { get; set; } = new List<Organization>();
    }
}
