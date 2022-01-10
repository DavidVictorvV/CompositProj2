using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositProj2
{
    class ItemLeaf:Item
    {
        private string _text;
        public ItemLeaf(string name,string text) : base(name)
        {
            _text = text;
        }
        public override void ReadItem(string space)
        {
            Console.WriteLine($"{space}<{_itemName}> {_text} </{_itemName}>");
        }
    }
}
