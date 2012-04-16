using CleverDogStudios.FormulaOnePickr.Core.Drivers;

namespace CleverDogStudios.FormulaOnePickr.WebService
{
    public class FormulaOnePickrService : IFormulaOnePickrService
    {
        private readonly IDriverService _driverService;

        public FormulaOnePickrService(IDriverService driverService)
        {
            _driverService = driverService;
        }

        public string GetDrivers()
        {
            return _driverService.GetAllDriversAsJson();
        }
    }
}
