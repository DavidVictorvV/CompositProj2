using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositProj2
{
    class ItemComposit:Item
    {
        private List<Item> _items = new List<Item>();
        public ItemComposit(string name) : base(name)
        {

        }
        public void AddToGroup(Item item)
        {
            _items.Add(item);
        }
        public void RemoveFromGroup(Item item)
        {
            _items.Remove(item);
        }
        public override void ReadItem(string space)
        {
            Console.WriteLine($"{space}<{_itemName}>");
            foreach (var item in _items)
            {
                item.ReadItem(space + space);
            }
            Console.WriteLine($"{space}</{_itemName}>");
        }
    }
}
