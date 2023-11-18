using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core.Entities
{
    public class Order
    {

        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }

        public string OrderType { get; set; }
        public string OrderColor { get; set; }
        public int OrderCount { get; set; }

        public string BoxType { get; set; }
        public int BoxCount { get; set; }

        public bool Edge { get; set; } = false;
        public bool Lable { get; set; } = false;
        public bool TwoColor { get; set; } = false;

        
    }
}
