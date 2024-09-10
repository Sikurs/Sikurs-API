using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sikurs_DataAccess.Base;

namespace Sikurs_DataAccess
{
    public class GroupOfItem : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string? PictureUrl { get; set; }

        public Guid? ParentId { get; set; }
        public GroupOfItem Parent { get; set; } = default!;

        public virtual ICollection<ItemAttribute> Attributes { get; set; } = new List<ItemAttribute>();
        public virtual ICollection<GroupOfItem> GroupsOfItem { get; set; } = new List<GroupOfItem>();
        public virtual ICollection<Item> Items { get; set; } = new List<Item>();
        public ICollection<Box> Boxes { get; set; } = new List<Box>();

    }
}
