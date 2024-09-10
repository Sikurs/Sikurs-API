using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikurs_DataAccess
{
    public class Version
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ReleaseVersion { get; set; } = default!;
        public string? Description { get; set; }
        public DateTime ReleasedAt { get; set; }
    }
}
