using CleverDogStudios.FormulaOnePickr.Core.Repositories;
using CleverDogStudios.FormulaOnePickr.Data.Drivers;
using Ninject.Modules;

namespace CleverDogStudios.FormulaOnePickr.WebService.Dependencies
{
    public class DataModule : NinjectModule 
    {
        public override void Load()
        {
            Bind<IDriverRepository>().To<DriverRepository>().InTransientScope();
        }
    }
}