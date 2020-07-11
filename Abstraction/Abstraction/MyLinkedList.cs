using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class MyLinkedList : INodeList
    {
        private ListItem _root = null;

        public MyLinkedList(ListItem root)
        {
            _root = root;
        }

        public ListItem getRoot()
        {
            return _root;
        }
        public bool addItem(ListItem item)
        {
            if(_root == null)
            {
                _root = item;
                return true;
            }

            ListItem currentItem = _root;
            while(currentItem != null)
            {
                int comparison = (currentItem.compareTo(item));
                if(comparison < 0)
                {
                    if(currentItem.next() != null)
                    {
                        currentItem = currentItem.next();
                    }
                    else
                    {
                        currentItem.setNext(item).setPrevious(currentItem);
                        return true;
                    }
                }
                else if(comparison > 0)
                {
                    if(currentItem.previous() != null)
                    {
                        currentItem.previous().setNext(item).setPrevious(currentItem.previous());
                        item.setNext(currentItem).setPrevious(item);
                    }
                    else
                    {
                        item.setNext(_root).setPrevious(item);
                        _root = item;
                    }
                    return true;
                }
                else
                {
                    Console.WriteLine(item.getValue() + " is already present, not added");
                    return false;
                }
            }
            return false;
        }
        public bool removeItem(ListItem item)
        {
            if(item != null)
            {
                Console.WriteLine("Deleting item " + item.getValue());
            }

            ListItem currentItme = _root;
            while(currentItme != null)
            {
                int comparison = currentItme.compareTo(item);
                if(comparison == 0)
                {
                    if(currentItme == _root)
                    {
                        _root = currentItme.next();
                    }
                    else
                    {
                        currentItme.previous().setNext(currentItme.next());
                        if (currentItme.next() != null){
                            currentItme.next().setPrevious(currentItme.previous());  
                        }
                    }
                    return true;
                }
                else if (comparison<0)
                {
                    currentItme = currentItme.next();
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public void traverse(ListItem root)
        {
            if(root == null)
            {
                Console.WriteLine("The list is empty");
            }
            else
            {
                while(root != null)
                {
                    Console.WriteLine(root.getValue());
                    root = root.next();
                }
            }
        }
    }
}
