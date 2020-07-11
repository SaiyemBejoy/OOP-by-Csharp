using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList list = new MyLinkedList(null);
            list.traverse(list.getRoot());

            string stringData = "AA CC BB EE DD ZZ KK SS YY";

            string[] data = stringData.Split(" ");

            foreach (string s in data)
            {
                list.addItem(new Node(s));
            }

            list.traverse(list.getRoot());
            list.removeItem(new Node("KK"));
            list.traverse(list.getRoot());
        }
    }
}
