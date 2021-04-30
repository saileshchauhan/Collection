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
    }
}
