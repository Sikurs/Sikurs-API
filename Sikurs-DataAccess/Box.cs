using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sikurs_DataAccess.Base;

namespace Sikurs_DataAccess
{
    public class Box : BaseEntity
    {
        public string Name { get; set; } = default!;

        public Guid CollectionId { get; set; }
        public Collection Collection { get; set; } = default!;

        public Guid GroupOfItemId { get; set; }
        public GroupOfItem? GroupOfItem { get; set; } = default!;

        public ICollection<ItemInBox> ItemsInBox { get; set; } = new List<ItemInBox>();
    }
}
