using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sikurs_DataAccess.Base;
using Sikurs_DataAccess.Enums;

namespace Sikurs_DataAccess
{
    public class Permission : BaseEntity
    {
        public string Entity { get; set; } = default!;

        public bool CanCreate { get; set; }
        public PermissionScope CreateScope { get; set; }

        public bool CanRead { get; set; }
        public PermissionScope ReadScope { get; set; }

        public bool CanUpdate { get; set; }
        public PermissionScope UpdateScope { get; set; }

        public bool CanDelete { get; set; }
        public PermissionScope DeleteScope { get; set; }

        public Guid RoleId { get; set; }
        public Role Role { get; set; } = default!;  
    }
}
