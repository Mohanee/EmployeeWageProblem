﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageProblem23
{
    interface EmpWageInterface
    {
        void AddToEmpList(string compName, int wagePerHr, int workingDays, int maxHoursMonthly);
        void CalEmpWage(Employee e);
        void CalcAllWages();
        void PrintAllWages();
    }
}
