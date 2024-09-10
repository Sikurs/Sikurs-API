using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sikurs_DataAccess.Base;

namespace Sikurs_DataAccess
{
    public class Collection : BaseEntity
    {
        public string Name { get; set; } = default!;

        public Guid OrganizationId { get; set; }
        public Organization Organization { get; set; } = default!;

        public ICollection<Box> Boxes { get; set; } = new List<Box>();
    }
}
