using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to check whether Employee is present or not program");
            Console.ReadLine();

            int IS_PRESENT = 1;
            Random random = new Random();
            int empAttendance = random.Next(0, 2);
            Console.WriteLine("Value of random no: {0}",empAttendance);
            Console.ReadLine();

            if (empAttendance == 0)
            {
                Console.WriteLine("Employee is absent");
            }
            else
            {
                Console.WriteLine("Employee is present");
            }
            Console.ReadLine();
        }
    }
}
