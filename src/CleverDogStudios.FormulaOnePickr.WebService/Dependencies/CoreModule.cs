using CleverDogStudios.FormulaOnePickr.Core.Drivers;
using Ninject.Modules;

namespace CleverDogStudios.FormulaOnePickr.WebService.Dependencies
{
    public class CoreModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDriverService>().To<DriverService>().InTransientScope();
        }
    }
}