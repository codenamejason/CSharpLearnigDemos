using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company Name = " +
                CompanyInfo.GetCompanyName());

            Console.WriteLine("Press any key to continue ..........");
            Console.ReadKey();
        }

        static class CompanyInfo
        {
            public static string GetCompanyName()
            {
                return "Romero Agency";
            }
        }
    }
}
