using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Implement_List();
            Implement_Stack();
            Implement_Queue();
            Console.ReadKey();
        }

        private static void Implement_List()
        {
            Console.WriteLine("\nImplementing List in DS");
            List<string> list = new List<string>();
            //Adding object to the list
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Sailesh");
            list.Add("Ajay");
            list.Add("Ravi");
            //Iterate list elements
            foreach(var element in list)
            {
                Console.WriteLine(element);
            }
        }
        private static void Implement_Stack()
        {
            Console.WriteLine("\nImplementing Stack in DS");
            Stack<string> stack = new Stack<string>();
            stack.Push("Ayush");
            stack.Push("Garvit");
            stack.Push("Amit");
            stack.Push("Ashish");
            stack.Push("Garima");
            string pop = stack.Pop();
            //Iterate stack elements
            foreach(var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(("popped element: "+pop));
        }
        private static void Implement_Queue()
        {
            Console.WriteLine("\nImplementing Queue in DS");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Sailesh singh At First Head");
            queue.Enqueue("Suraj kumar");
            queue.Enqueue("Arun Patil");
            queue.Enqueue("Sunder kumar");
            Console.WriteLine("Head: "+queue.Peek());
            //Iterating through queue elements
            foreach (var element in queue)
            {
                Console.WriteLine("Queue element First in First out " + element);
            }
            string dequeuedElement = queue.Dequeue();
            Console.WriteLine("Dequeued Element Should be Sailesh Singh "+dequeuedElement);
            Console.WriteLine("\nIterarating the queue elements after dequeue one Element: ");
            //Iteratring queue elements using Enumerator
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

    }
}
