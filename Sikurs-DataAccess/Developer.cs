using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikurs_DataAccess
{
    public class Developer
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = default!;
        public string Role { get; set; } = default!;
        public string? SiteUrl { get; set; }
        public string? PictureUrl { get; set; }
    }
}
