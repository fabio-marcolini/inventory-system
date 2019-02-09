using System;
using InventorySystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class InventoryTests
    {
        [TestMethod]
        public void AddItem()
        {
            var inventory = new Inventory<SimpleItem, SimpleParameters>();
            SimpleItem item = new SimpleItem();
            inventory.AddItem(item);
            Assert.AreEqual(1, inventory.Items.Count);
            Assert.AreEqual(item, inventory.Items[0]);
        }

        [TestMethod]
        public void RemoveItem()
        {
            var inventory = new Inventory<SimpleItem, SimpleParameters>();
            inventory.AddItem(new SimpleItem());
            inventory.AddItem(new SimpleItem());
            inventory.AddItem(new SimpleItem());
            inventory.AddItem(new SimpleItem());

            Assert.AreEqual(4, inventory.Items.Count);

            foreach (var item in inventory.Items)
            {
                inventory.RemoveItem(item);
            }

            Assert.AreEqual(0, inventory.Items.Count);
        }

        [TestMethod]
        public void ConsumableItem()
        {
            var inventory = new Inventory<SimpleItem, SimpleParameters>();
            var item = new SimpleItem(new ConsumableAction());

            inventory.AddItem(item);

            Assert.AreEqual(1, inventory.Items.Count);

            item = inventory[0];
            var action = item[0];
            var parameters = new SimpleParameters();
            parameters.Inventory = inventory;
            parameters.Item = item;
            action.Execute(parameters);

            Assert.AreEqual(0, inventory.Items.Count);
        }

        [TestMethod]
        public void TestProperties()
        {
            SimpleItem item = new SimpleItem();
            string propName = "myProperty";
            Assert.IsFalse(item.HasProperty(propName));

            item["myProperty"] = 1;
            Assert.IsTrue(item.HasProperty(propName));

            var test = item.GetProperty<int>(propName);
            Assert.AreEqual(1, test);

            item.RemoveProperty(propName);
            Assert.IsFalse(item.HasProperty(propName));
        }
    }
}
