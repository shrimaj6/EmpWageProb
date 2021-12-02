﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProb
{
    class SwitchCase
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_WAGE_PER_HOUR = 20;
        public static void switchcase2()
        {
            //Variable
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();


            //Computation
            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }

            empWage = empHrs * EMP_WAGE_PER_HOUR;
            Console.WriteLine("Employee Wage : " + empWage);

        }
    }
}