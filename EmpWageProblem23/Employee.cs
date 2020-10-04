using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageProblem23
{
    class Employee
    {
        public string companyName;
        public List<int> DailyWage;
        public int empRate_PerHr, working_Hrs, max_WorkHrs_Monthly, totalEmployeeWage;
        public Employee(String companyName, int empRate_PerHr, int working_Hrs, int max_WorkHrs_Monthly)
        {
            this.companyName = companyName;
            this.empRate_PerHr = empRate_PerHr;
            this.working_Hrs = working_Hrs;
            this.max_WorkHrs_Monthly = max_WorkHrs_Monthly;
            this.DailyWage = new List<int>();
        }
        }
    }
