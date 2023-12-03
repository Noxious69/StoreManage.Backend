using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Infrastructore.UI
{
    public class ListRequestDto
    {
        public int page { get; set; } = 0;
        public int PageSize { get; set; } = 10;
        public string Sort { get; set; } = "date";
        public string SortType { get; set; } = "DES";
        public string Filter { get; set; } = "Filter";

    }
}
