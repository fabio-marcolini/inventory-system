using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace InventorySystem
{
    public class Item<TParameter>
    {
        protected List<IAction<TParameter>> actions = new List<IAction<TParameter>>();

        public IReadOnlyList<IAction<TParameter>> Actions
        {
            get { return actions; }
        }

        private Dictionary<string, object> Properties = new Dictionary<string, object>();

        public IAction<TParameter> this[int index]
        {
            get { return actions[index]; }
        }

        public object this[string property]
        {
            get { return Properties[property]; }
            set { Properties[property] = value; }
        }

        public T GetProperty<T>(string property)
        {
            return (T)this[property];
        }

        public bool HasProperty(string property)
        {
            return Properties.ContainsKey(property);
        }

        public bool RemoveProperty(string property)
        {
            return Properties.Remove(property);
        }
    }
}
