using System;
using MvvmCross.Core.ViewModels;
using XamSqrdCalc.Core.Services;

namespace XamSqrdCalc.Core.ViewModels
{
    public class SqrdCalcViewModel : MvxViewModel
    {
        private readonly ISquareRootCal _calc;

        private string result;

        public string Result
        {
            get => result;
            set
            {
                SetProperty(ref result, value);
            }
        }

        private double number;

        public string Number
        {
            get { return Convert.ToString(number); }
            set { SetProperty(ref number, Convert.ToDouble(value)); }
        }

        public SqrdCalcViewModel(ISquareRootCal calc)
        {
            _calc = calc;
        }
    }
}