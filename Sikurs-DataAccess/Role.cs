using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sikurs_DataAccess.Base;

namespace Sikurs_DataAccess
{
    public class Role : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }

        public ICollection<Permission> Permissions { get; set; } = new List<Permission>();
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
