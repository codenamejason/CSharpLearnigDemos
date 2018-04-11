using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program
    {
        private class ExampleClass { }

        static void Main(string[] args)
        {
            // Declare a list of type int
            List<int> intList = new List<int>();

            // Declare a list of type string
            List<string> stringList = new List<string>();

            //Declare a list of type ExampleClass
            List<ExampleClass> exampleClassList = new List<ExampleClass>();

            intList.Add(42);
            stringList.Add("Jaxcoder");

            Console.WriteLine("Your name is " + stringList[0] + " and you are " + intList[0]);

            Console.WriteLine("Press any key to continue ..........");
            Console.ReadKey();
        }


    }
}
