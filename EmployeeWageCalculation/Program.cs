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
        public const int MAX_WORK_DAYS_IN_MONTH = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage calculation  program");
            Console.ReadLine();
            //UC5
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            for (int day = 0; day <= MAX_WORK_DAYS_IN_MONTH; day++)
            {
                Random random = new Random();
                int empAttendance = random.Next(0, 3);
                switch (empAttendance)
                {
                    case IS_FULL_TIME:
                        Console.WriteLine("Employee is full time.");
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        Console.WriteLine("Employee is part time.");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is absent.");
                        empHrs = 0;
                        break;

                }
                empWage = empHrs * EMP_RATE_PER_HR;
                totalEmpWage += empWage;
                Console.WriteLine("Day: "+day + " Employee wage: " +empWage);
            }
            Console.WriteLine("Total emp wage is {0}: ",  totalEmpWage);
            Console.ReadLine();
        }
    }
}
