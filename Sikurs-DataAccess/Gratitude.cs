using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikurs_DataAccess
{
    public class Gratitude 
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = default!;
        public string Reason { get; set; } = default!;
        public string? SiteUrl { get; set; }
        public string? PictureUrl { get; set; }
    }
}
