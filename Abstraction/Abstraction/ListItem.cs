using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    abstract class ListItem
    {
        protected ListItem rightLink = null;
        protected ListItem leftLink = null;

        private Object value;


        protected ListItem(object value)
        {
            this.value = value;
        }

        public abstract ListItem next();
        public abstract ListItem setNext(ListItem item);
        public abstract ListItem previous();
        public abstract ListItem setPrevious(ListItem item);

        public abstract int compareTo(ListItem item);

        public void setValue(Object value)
        {
            this.value = value;
        }
        public Object getValue()
        {
            return this.value;
        }

    }
}
