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
            Implement_Set();
            Implement_Dictionary();
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
        private static void Implement_Set()
        {
            Console.WriteLine("\nImplementing Set in DS");
            var set = new HashSet<string>();
            set.Add("Sailesh");
            set.Add("Vijay");
            set.Add("Vinay");
            set.Add("Vinod");
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine("HashSet Values "+enumerator.Current);
            }
        }
        private static void Implement_Dictionary()
        {
            Console.WriteLine("\n Implementing Dictionary");
            IDictionary<int, string> keyValuePairs = new Dictionary<int,string>();
            keyValuePairs.Add(1,"Sailesh");
            keyValuePairs.Add(2, "Suraj");
            keyValuePairs.Add(3, "Swapnil");
            keyValuePairs.Add(4, "Sapna");
            Console.WriteLine("Access value at key=2 "+keyValuePairs[2]);
            Console.WriteLine("\nIterating through dictionary ");
            foreach (var element in keyValuePairs)
            {
                Console.WriteLine("Keys = "+element.Key+"Values = "+element.Value);
            }
        }

    }
}
