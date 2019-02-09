using InventorySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class SimpleParameters
    {
        public SimpleItem Item { get; set; }
        public Inventory<SimpleItem, SimpleParameters> Inventory { get; set; }
    }
}
