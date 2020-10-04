using EmpWageProblem23;
using System;

namespace EmpWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyWageCalculator c = new CompanyWageCalculator();
            c.AddToEmpList("ZS", 20, 10, 50);
            c.AddToEmpList("Flipkart", 40, 5, 60);
            c.CalcAllWages();
        }


    }

}