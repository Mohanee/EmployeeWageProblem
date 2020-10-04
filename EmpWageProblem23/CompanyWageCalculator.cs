using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageProblem23
{
    class CompanyWageCalculator : EmpWageInterface
    {

        public const int is_part_time = 1;
        public const int is_full_time = 2;
        public const int no_work_days = 2;

        public Employee[] empArray;
        int no_companies = 0;

        public CompanyWageCalculator()
        {
            this.empArray = new Employee[5];
        }

        public void AddToEmpArray(string compName, int wagePerHr, int workingDays, int maxHoursMonthly)
        {
            this.empArray[no_companies] = new Employee(compName, wagePerHr, workingDays, maxHoursMonthly);
            no_companies++;
        }

        public void CalEmpWage(Employee e)
        {
            int EmpHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkDays = 0;
            while (totalEmpHrs <= e.max_WorkHrs_Monthly && totalWorkDays < no_work_days)
            {
                totalWorkDays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);

                switch (empcheck)
                {
                    case is_part_time:
                        EmpHrs = 4;
                        break;
                    case is_full_time:
                        EmpHrs = 8;
                        break;
                    default:
                        break;
                }
                totalEmpHrs += EmpHrs;
                Console.WriteLine("Day:" + totalWorkDays + "\tEmp Hrs:" + EmpHrs);
            }
            int totalEmpWage = totalEmpHrs * e.empRate_PerHr;
            Console.WriteLine("Employee wage for company " + e.companyName + " is " + totalEmpWage);
        }

        public void CalcAllWages()
        {
            for (int i = 0; i < no_companies; i++)
            {
                CalEmpWage(empArray[i]);
            }
        }
    }
}
