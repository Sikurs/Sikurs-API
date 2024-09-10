using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sikurs_DataAccess.Base;

namespace Sikurs_DataAccess
{
    public class ItemInBox : BaseEntity
    {
        public decimal Count { get; set; }
        public string? Name { get; set; }

        public Guid? ItemId { get; set; }
        public Item Item { get; set; } = default!;

        public Guid BoxId { get; set; }
        public Box Box { get; set; } = default!;

        public Guid UnitId { get; set; }
        public Unit Unit { get; set; } = default!;
    }
}
