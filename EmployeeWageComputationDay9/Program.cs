﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationDay9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int IS_PRESENT = 1;
            Console.WriteLine("Welcome to EmployeeWageCompute");
            Random random = new Random();
            int randomInput = random.Next(0, 2); //0 or 1
            if (IS_PRESENT == randomInput)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }

            Console.ReadLine();

        }
    }
}
