using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First String:");
            string firstString = Console.ReadLine();

            Console.WriteLine("Enter Second String:");
            string secondString = Console.ReadLine();

            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Concatenate Strings");
            Console.WriteLine("2) Lengths of String");
            Console.WriteLine("3) Substring");
            Console.WriteLine("4) Replace");
            Console.WriteLine("5) Upper Case");
            Console.WriteLine("6) Lower Case");
            Console.WriteLine("7) Trim");
            Console.WriteLine("8) Split");

            switch (Console.ReadLine())
            {


                case "1":
                    Console.WriteLine(firstString + " " + secondString);
                    break;
                case "2":
                    Console.WriteLine(firstString.Length + secondString.Length);
                    break;
                case "3":
                    Console.WriteLine(firstString.Substring(5));
                    Console.WriteLine(secondString.Substring(4));
                    break;
                case "4":
                    Console.WriteLine(firstString.Replace("Hello", "This is C Sharp"));
                    Console.WriteLine(secondString.Replace("World", "This is string operations example"));
                    break;
                case "5":
                    Console.WriteLine(firstString.ToUpper() + " " + secondString.ToUpper());
                    break;
                case "6":
                    Console.WriteLine(firstString.ToLower() + " " + secondString.ToLower());
                    break;
                case "7":
                    Console.WriteLine(firstString.Trim() + " " + secondString.Trim());
                    break;
                case "8":
                    string[] s2 = firstString.Split(' ');
                    foreach (string s3 in s2)
                    {
                        Console.WriteLine(s3);
                    }
                    Console.WriteLine("--Second String--");
                    string[] s4 = secondString.Split(' ');
                    foreach (string s5 in s4)
                    {
                        Console.WriteLine(s5);
                    }
                    break;
                default:
                    Console.Write("Incorrect option\n");
                    break;


            }

        }
    }
}
