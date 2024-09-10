using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikurs_DataAccess.Base
{
    public class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();


        public Guid? CreateById { get; set; }
        public User CreateBy { get; set; } = default!;
        public DateTime? CreateAt { get; set; }


        public Guid? UpdateById { get; set; }
        public User UpdateBy { get; set; } = default!;
        public DateTime? UpdateAt { get; set; }

        public bool IsEnabled { get; set; } = true;
    }
}
