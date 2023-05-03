using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCalculation
{
    internal class EmpWageBuilder
    {
        //UC9 Employee wage builder for each company
        //instance variables
        public string company;
        public int empRatePerHr, maxWorkDaysInMonth, maxWorkHrsInMonth;
        
        //Constructor to initialize instance variables
        public EmpWageBuilder(string company, int empRatePerHr, int maxWorkDaysInMonth, int maxWorkHrsInMonth)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.maxWorkDaysInMonth = maxWorkDaysInMonth;
            this.maxWorkHrsInMonth = maxWorkHrsInMonth;
        }


        public int CalculateEmpWage()
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
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;        
            }
            empWage = totalEmpHrs * empRatePerHr;
            Console.WriteLine("Total employee wage for {0} is {1} ", company,empWage);
            return empWage;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage calculation  program");
            
            for (int i = 0; i < 3; i++) // takes input for three companies
            {
                Console.WriteLine("Enter the company Name: ");
                string companyName = Console.ReadLine();
                Console.WriteLine("Enter employee rate per hr");
                int empRatePerHr = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter maximum work days in month");
                int maxWorkDayInMonth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter maximum work hrs in month");
                int maxWorkHrInMonth = Convert.ToInt32(Console.ReadLine());
                //object of class to acces the instance variables
                //no need to create saperate three objects because it always create new object for each rotation
                EmpWageBuilder company = new EmpWageBuilder(companyName, empRatePerHr, maxWorkDayInMonth, maxWorkHrInMonth);
                company.CalculateEmpWage(); //calling method using object 
                Console.ReadLine();
                
            }

        }
    }
}
