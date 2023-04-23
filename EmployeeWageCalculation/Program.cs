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
        public const int MAX_WORKING_HRS_IN_MONTH = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage calculation  program");
            Console.ReadLine();
            Console.WriteLine("Total employee wage is:"+CalculateEmpWage());
        }
        //UC7
        public static int CalculateEmpWage()
        {
           
            int empHrs = 0;
            int empWage = 0;
            int totalEmpHrs = 0;
            int totalWorkDays = 0;

            while (totalEmpHrs <= MAX_WORKING_HRS_IN_MONTH && totalWorkDays < MAX_WORK_DAYS_IN_MONTH)
            {
                totalWorkDays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day: " + totalWorkDays + "Emp hrs: " + empHrs);
                Console.WriteLine("Emp work days: " + totalWorkDays);
            }
            empWage = totalEmpHrs * EMP_RATE_PER_HR;
            // Console.WriteLine("Total emp wage is {0}: ", empWage);
            //Console.WriteLine("Total Emp hrs: " + totalEmpHrs);
            //Console.ReadLine();
            return empWage;
        }
    }
}
