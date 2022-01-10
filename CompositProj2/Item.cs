using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositProj2
{
    internal abstract class Item
    {
        protected string _itemName;
        protected Item(string name)
        {
            _itemName = name;
        }
        public abstract void ReadItem(string space);
    }
}
