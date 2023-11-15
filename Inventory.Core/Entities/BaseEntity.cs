using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core.Entities
{
    internal class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }

        public BaseEntity()
        {
            CreationTime = DateTime.Now;
        }
    }
}
