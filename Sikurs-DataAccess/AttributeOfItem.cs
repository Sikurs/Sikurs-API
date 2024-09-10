using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sikurs_DataAccess.Base;

namespace Sikurs_DataAccess
{
    public class AttributeOfItem : BaseEntity
    {
        public Guid AttributeId { get; set; }
        public ItemAttribute Attribute { get; set; } = default!;

        public Guid ItemId { get; set; }
        public Item Item { get; set; } = default!;

        public string Value { get; set; } = default!;
    }
}
