using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] MyArray = new string[5] { "Zebra", "Ant", "Owl", "Lion", "Dog" };

            foreach (string s in MyArray)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("--for loop--");
            for (int i = 0; i < MyArray.Length; i++)
            {
                string s = MyArray[i];
                Console.WriteLine(s);
            }



            Console.WriteLine("-------Array after sorting---------");
            Array.Sort(MyArray);
            foreach (string s in MyArray)
            {
                Console.WriteLine(s);
            }



            string[] animals = new string[] { "Zebra", "Kiwi", "Amazona Parrot", "Tiger" };
            Console.WriteLine("-------Animals Array after sorting---------");
            Array.Sort(animals);
            foreach (string s in animals)
            {
                Console.WriteLine(s);
            }
            string[] places = new string[] { "Africa", "New Zealand", "Jamaica", "India" };
            Console.WriteLine("-------Places Array after sorting---------");
            Array.Sort(places);
            foreach (string s in places)
            {
                Console.WriteLine(s);
            }

        }
    }
    }
