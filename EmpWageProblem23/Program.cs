using System;

namespace EmpWageProblem
{
    class Program
    {
        public const int is_part_time = 1;
        public const int is_full_time = 2;
        public const int empRate_PerHr = 20;
        public const int no_work_days = 2;
        public const int max_hrs_in_mon = 100;

        static void Main(string[] args)
        {
            CalEmpWage("ZS", empRate_PerHr, no_work_days, max_hrs_in_mon);
            CalEmpWage("Flipkart", 40, 5, 60);
        }

        public static void CalEmpWage(String compName, int EmpRate_PerHr, int no_work_days, int max_hrs_in_mon)
        {
            int EmpHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkDays = 0;
            while (totalEmpHrs <= max_hrs_in_mon && totalWorkDays < no_work_days)
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
                Console.WriteLine("Days:" + totalWorkDays + "Emp Hrs:" + EmpHrs);
            }
            int totalEmpWage = totalEmpHrs * EmpRate_PerHr;
            Console.WriteLine("Employee wage for company " + compName + " is " + totalEmpWage);
           
        }


    }

}