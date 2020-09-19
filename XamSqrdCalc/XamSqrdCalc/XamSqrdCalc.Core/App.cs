using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using XamSqrdCalc.Core.Services;

namespace XamSqrdCalc.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            
            Mvx.ConstructAndRegisterSingleton<ISquareRootCal, SquareRootCalc>();

            // RegisterNavigationServiceAppStart<ViewModels.FirstViewModel>();
            RegisterNavigationServiceAppStart<ViewModels.SqrdCalcViewModel>();
        }
    }
}
