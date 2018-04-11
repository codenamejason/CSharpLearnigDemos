using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Jaxcoder";
            s.PrintName();


        }

        abstract class Person
        {
            public int Age { get; set; } = 42;
            public abstract void PrintName();
        }

        class Student: Person
        {
            public string Name { get; set; }
            public override void PrintName()
            {
                Console.WriteLine($"Student name is { Name } and is { Age }.");
                Console.WriteLine("Press any key to continue .........");
                Console.ReadKey();
            }
        }


    }
}
