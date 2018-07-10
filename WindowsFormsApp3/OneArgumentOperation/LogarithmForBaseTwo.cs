﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.OneArgumentOperation
{
    public class LogarithmForBaseTwoCalculator : IOneArgumentCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Log(argument, 2);
        }
    }
}
