using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sikurs_DataAccess.Base;

namespace Sikurs_DataAccess
{
    public class Organization : BaseEntity
    {
        public string? SiteUrl { get; set; }
        public string? PictureUrl { get; set; }

        public Guid ResponsibleUserId { get; set; }
        public User ResponsibleUser { get; set; } = default!;

        public ICollection<Collection> Collections { get; set; } = new List<Collection>();
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
