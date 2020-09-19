using System;
namespace XamSqrdCalc.Core.Services
{
    public class SquareRootCalc : ISquareRootCal
    {
        public double Calculate(double number) => Math.Sqrt(number);
    }
}
