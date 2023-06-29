using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationDay9
{
    internal class Program
    {
        public static int IS_PART_TIME { get; private set; }

        static void Main(string[] args)
        {
            //Constants
            int IS_PART_TME = 1;
            int FULL_TIME = 2;
            int EMP_RATE_PER_HR = 20;
            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else if (empCheck == FULL_TIME)
            {
                empHrs = 8;
            }

            else
            {
                empHrs = 0;
            }
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee Wage per day:{0}", empWage);
            Console.ReadLine();

        }
    }
}
