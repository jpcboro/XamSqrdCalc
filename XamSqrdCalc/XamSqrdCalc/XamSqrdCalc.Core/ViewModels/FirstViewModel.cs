using MvvmCross.Core.ViewModels;

namespace XamSqrdCalc.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        string hello = "Test SqrdCalc";
        public string Hello
        {
            get { return hello; }
            set { SetProperty(ref hello, value); }
        }
    }
}
