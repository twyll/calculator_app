﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class DivisionCalculator : ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue / secondValue;
        }
    }
}