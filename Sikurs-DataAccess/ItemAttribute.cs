using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sikurs_DataAccess.Base;
using Sikurs_DataAccess.Enums;

namespace Sikurs_DataAccess
{
    public class ItemAttribute : BaseEntity
    {
        public string Name { get; set; } = default!;
        public TypeOfValue TypeOfValue { get; set; }

        public Guid GroupOfItemId { get; set; }
        public GroupOfItem GroupOfItem { get; set; } = default!;

        public ICollection<AttributeOfItem> AttributeOfItems { get; set; } = new List<AttributeOfItem>();
    }
}
