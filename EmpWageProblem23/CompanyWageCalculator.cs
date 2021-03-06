﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmpWageProblem23
{
    class CompanyWageCalculator : EmpWageInterface
    {

        public const int is_part_time = 1;
        public const int is_full_time = 2;
        public const int no_work_days = 4;

        public ArrayList empList;
        public Dictionary<string, int> CompanyWiseTotalWage = new Dictionary<string, int>();
        int no_companies = 0;

        public CompanyWageCalculator()
        {
            this.empList = new ArrayList();
        }

        public void AddToEmpList(string compName, int wagePerHr, int workingDays, int maxHoursMonthly)
        {
            empList.Add((new Employee(compName, wagePerHr, workingDays, maxHoursMonthly)));
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
                int dailyWage = EmpHrs * e.empRate_PerHr;
                e.DailyWage.Add(dailyWage);
                Console.WriteLine("Day:" + totalWorkDays + "\tEmp Hrs:" + EmpHrs + "\tDaily Wage:" + dailyWage);
            }
            int totalEmpWage = totalEmpHrs * e.empRate_PerHr;
            CompanyWiseTotalWage.Add(e.companyName, totalEmpWage);
            Console.WriteLine("Employee wage for company " + e.companyName + " is " + totalEmpWage);
        }

        public void CalcAllWages()
        {
            for (int i = 0; i < no_companies; i++)
            {
                CalEmpWage((Employee)empList[i]);
                Console.WriteLine("\n");
            }
        }
        public void PrintAllWages() 
        {
            foreach(KeyValuePair<string, int> kvp in CompanyWiseTotalWage)
            {
                Console.WriteLine("Company Name :{0} \t Total Wage : {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
