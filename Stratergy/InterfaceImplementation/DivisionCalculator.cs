using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.InterfaceImplementation
{
    public class DivisionCalculator : ICalculateStrategy
    {
        public double Calculate(double a, double b)
        {
            return (b == 0) ? 0 : a / b;
        }
    }
}
