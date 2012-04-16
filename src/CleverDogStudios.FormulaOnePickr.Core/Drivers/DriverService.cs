using System.Linq;
using System.Web.Script.Serialization;
using CleverDogStudios.FormulaOnePickr.Core.Repositories;

namespace CleverDogStudios.FormulaOnePickr.Core.Drivers
{
    public class DriverService : IDriverService
    {
        private readonly IDriverRepository _driverRepository;

        public DriverService(IDriverRepository driverRepository)
        {
            _driverRepository = driverRepository;
        }

        public string GetAllDriversAsJson()
        {
            var drivers = from driver in _driverRepository.GetAll()
                               orderby driver.Team.FullName, driver.LastName
                               select new
                               {
                                   firstName = driver.FirstName,
                                   lastName = driver.LastName,
                                   teamName = driver.Team.FullName,
                                   nationality = driver.Nationality,
                                   placeOfBirth = driver.PlaceOfBirth
                               };

            return new JavaScriptSerializer().Serialize(drivers);
        }
    }
}
