using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCalculation
{
    internal class Program
    {
        //UC8 Employee wage for multiple comapanies
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage calculation  program");
            Console.ReadLine();
            for(int i=0; i<3;i++) // takes input for three companies
            {
                Console.WriteLine("Enter the company Name: ");
                string companyName = Console.ReadLine();
                Console.WriteLine("Enter employee rate per hr");
                int empRatePerHr = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter maximum work days in month");
                int maxWorkDayInMonth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter maximum work hrs in month");
                int maxWorkHrInMonth = Convert.ToInt32(Console.ReadLine());
                CalculateEmpWage(companyName, empRatePerHr, maxWorkDayInMonth, maxWorkHrInMonth);
            }

        }
        public static int CalculateEmpWage(string company, int empRatePerHr, int maxWorkDaysInMonth, int maxWorkHrsInMonth)
        {        
            int empHrs = 0;
            int empWage = 0;
            int totalEmpHrs = 0;
            int totalWorkDays = 0;
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;

            while (totalEmpHrs <= maxWorkHrsInMonth && totalWorkDays < maxWorkDaysInMonth)
            {
                totalWorkDays++;
                Random random = new Random();
                int empAttendance = random.Next(0, 3);
                switch (empAttendance)
                {
                    case IS_FULL_TIME:
                       //Console.WriteLine("Employee is full time.");
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        //Console.WriteLine("Employee is part time.");
                        empHrs = 4;
                        break;
                    default:
                        //Console.WriteLine("Employee is absent.");
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;        
            }
            empWage = totalEmpHrs * empRatePerHr;
            Console.WriteLine("Total employee wage for {0} is {1} ", company,empWage);
            return empWage;
        }
    }
}
