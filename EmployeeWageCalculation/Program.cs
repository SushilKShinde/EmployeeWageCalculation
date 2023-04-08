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
            Console.WriteLine("Welcome to Employee wage calculation  program");
            Console.ReadLine();
            //UC2
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HR = 50;
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empAttendance = random.Next(0, 2);
            if (empAttendance == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;
            }
            else 
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Employee wage is: {0}", empWage);
            Console.ReadLine();
        }
    }
}
