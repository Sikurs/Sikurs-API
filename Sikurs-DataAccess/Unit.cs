using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sikurs_DataAccess.Base;

namespace Sikurs_DataAccess
{
    public class Unit : BaseEntity
    {
        public string FullName { get; set; } = default!;
        public string ShortName { get; set; } = default!;
        public string Accuracy { get; set; } = default!;

        public ICollection<ItemInBox> ItemInBoxes { get; set; } = new List<ItemInBox>();
    }
}
