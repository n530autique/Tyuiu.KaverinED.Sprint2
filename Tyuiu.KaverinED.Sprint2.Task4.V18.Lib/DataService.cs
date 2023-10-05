﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KaverinED.Sprint2.Task4.V18.Lib
{
    public class DataService : ISprint2Task4V18
    {
        public double Calculate(double x, double y)
        {
            return x * 3 < y - 2 ? Math.Pow(6 + (x - 1) / (y*y*y), x) : (x + 10 * y - (1 / x));
        }
    }
}
