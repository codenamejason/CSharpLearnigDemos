using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Jaxcoder";
            s.PrintName();

            Console.WriteLine("Press any key to continue ..........");
            Console.ReadKey();
        }

        interface Person
        {
            void PrintName();
        }

        class Student : Person
        {
            public string Name { get; set; }
            public void PrintName()
            {
                Console.WriteLine($"Student name is { Name }");
            }
        }


    }
}
