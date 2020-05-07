using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Interfaces
{
    interface ICalculateStrategy
    {
        double Calculate(double a, double b);
    }
}
