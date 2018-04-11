using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAndAbstractionDemo
{
    class Program
    {
        public class Employee
        {
            public virtual void CalculateWeeklySalary(int hours, int wage)
            {
                var salary = 40 * wage;
                Console.WriteLine("\nThis EMPLOYEE worked {0} hours and "
                    + "paid for 40 hours (no overtime) at ${1}" + "/hr = ${2} \n", hours, wage, salary);
                Console.WriteLine("-------------------------------------------------------------------------------------------");



            }
        }

        public class Contractor : Employee
        {
            public override void CalculateWeeklySalary(int hours, int wage)
            {
                var salary = hours * wage;
                Console.WriteLine("\nThis CONTRACTOR worked {0} hours and "
                    + "paid for {0} hours (w/overtime) at $ {1}"
                    + "/hr = ${2}", hours, wage, salary);

                Test(); // the private method can only be accessed inside this class.
            }

            // Encapulated by Contractor Class. Will not be accessable by any other classes.
            private void Test() 
            {
                Console.WriteLine("Only the CONTRACTOR can access me!");
            }
        }


        static void Main(string[] args)
        {
            const int hours = 50, wage = 70;
            Employee emp = new Employee();
            emp.CalculateWeeklySalary(hours, wage); // Polymorphism

            Contractor cont = new Contractor();
            cont.CalculateWeeklySalary(hours, wage); // Polymorphism


            Console.WriteLine("Press any key to continue ..........");
            Console.ReadKey();
        }




    }
}
