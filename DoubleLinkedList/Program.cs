using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList dll = new DoubleLinkedList();
            int n = Convert.ToInt32(Console.ReadLine());
            var temp = Console.ReadLine().Split();
            foreach (var t in temp)
                dll.PushBack(Convert.ToInt32(t));
            Console.WriteLine(dll.Print());

            int st = 1;
            int numDec = 0;
            dll.SetIteratorTail();
            while(dll.Iterator != null)
            {
                numDec += st * dll.GetIteratorValue();
                Console.WriteLine(dll.GetIteratorValue());
                st *= 2;
                dll.PreviousIterator();
            }
            Console.WriteLine(numDec);
        }
    }
}
