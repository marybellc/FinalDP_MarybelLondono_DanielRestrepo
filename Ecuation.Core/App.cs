using Ecuation.Core.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace Ecuation.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<EcuationViewModel>();

        }
    }
}
