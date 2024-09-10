using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikurs_DataAccess
{
    public class ReleaseVersion
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string CurrentReleaseVersion { get; set; } = default!;
        public string? Description { get; set; }
        public DateTime ReleasedAt { get; set; } = DateTime.Now;
    }
}
