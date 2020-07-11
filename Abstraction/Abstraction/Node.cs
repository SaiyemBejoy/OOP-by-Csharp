using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class Node : ListItem
    {
        public Node(Object value) : base(value)
        {

        }


        public override ListItem next()
        {
            return this.rightLink;
        }

        public override ListItem previous()
        {
            return this.leftLink;
        }

        public override ListItem setNext(ListItem item)
        {
            this.rightLink = item;
            return this.rightLink;
        }

        public override ListItem setPrevious(ListItem item)
        {
            this.leftLink = item;
            return this.leftLink;
        }
        public override int compareTo(ListItem item)
        {
           if(item != null)
            {
                return ((string)base.getValue()).CompareTo((string) item.getValue());
            }
            else
            {
                return -1;
            }
        }
    }
}
