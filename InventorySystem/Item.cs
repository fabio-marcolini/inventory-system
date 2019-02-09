using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace InventorySystem
{
    public class Item<TParameter>
    {
        private List<IAction<TParameter>> actions;

        public IReadOnlyCollection<IAction<TParameter>> Actions
        {
            get { return new ReadOnlyCollection<IAction<TParameter>>(actions); }
        }
    }
}
