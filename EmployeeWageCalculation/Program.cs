using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCalculation
{
    internal class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 50;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage calculation  program");
            Console.ReadLine();
            //UC4
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empAttendance = random.Next(0, 3);
            switch (empAttendance) 
            {
                case IS_FULL_TIME:
                    Console.WriteLine("Employee is part time.");
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    Console.WriteLine("Employee is absent");
                    empWage = 4;
                    break;
                default:
                    Console.WriteLine("Employee is absent.");
                    empHrs = 0;
                    break;
            
            }

            empWage = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Employee wage is: {0}", empWage);
            Console.ReadLine();
        }
    }
}
