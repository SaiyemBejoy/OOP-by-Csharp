using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    interface INodeList
    {
        ListItem getRoot();
        bool addItem(ListItem item);
        bool removeItem(ListItem item);
        void traverse(ListItem root);
    }
}
