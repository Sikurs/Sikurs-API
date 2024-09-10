using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sikurs_DataAccess.Base;

namespace Sikurs_DataAccess
{
    public class Item : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string? Barcode { get; set; }
        public string? PictureUrl { get; set; }

        public Guid GroupOfItemId { get; set; }
        public GroupOfItem GroupOfItem { get; set; } = default!;

        public ICollection<AttributeOfItem> AttributeOfItems { get; set; } = new List<AttributeOfItem>();
        public ICollection<ItemInBox> ItemInBoxes { get; set; } = new List<ItemInBox>();
    }
}
