using InventorySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class ConsumableAction : IAction<SimpleParameters>
    {
        public void Execute(SimpleParameters parameters)
        {
            parameters.Inventory.RemoveItem(parameters.Item);
        }
    }
}
