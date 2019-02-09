using InventorySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class SimpleItem : Item<SimpleParameters>
    {
        public SimpleItem()
        {

        }

        public SimpleItem(IAction<SimpleParameters> action)
        {
            actions.Add(action);
        }
    }
}
