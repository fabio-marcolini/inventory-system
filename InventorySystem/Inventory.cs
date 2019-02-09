using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace InventorySystem
{
    public class Inventory <TItem, TParameter> where TItem : Item<TParameter>
    {
        private List<TItem> items = new List<TItem>();

        public IReadOnlyList<TItem> Items { get { return new List<TItem>(items); } }

        public void AddItem(TItem item)
        {
            items.Add(item);
        }

        public void RemoveItem(TItem item)
        {
            items.Remove(item);
        }

        public TItem this[int index]
        {
            get { return items[index]; }
        }
    }
}
