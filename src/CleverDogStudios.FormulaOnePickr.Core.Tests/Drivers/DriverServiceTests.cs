using System.Collections.Generic;
using CleverDogStudios.FormulaOnePickr.Core.Drivers;
using CleverDogStudios.FormulaOnePickr.Core.Repositories;
using CleverDogStudios.FormulaOnePickr.Tests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleverDogStudios.FormulaOnePickr.Core.Tests.Drivers
{
    [TestClass]
    public class DriverServiceTests : FactFixture<DriverService>
    {
        [TestMethod]
        public void ShouldGetAllDrivers_OnGetAllDriversAsJson()
        {
            //arrange
            var list = new List<IDriver> { 
                ObjectMother.Driver(team: ObjectMother.Team()), 
                ObjectMother.Driver(team: ObjectMother.Team()),
                ObjectMother.Driver(team: ObjectMother.Team())
            };
    
            ArrangeConstructorDependencies();

            AutoMock<IDriverRepository>().Setup(m => m.GetAll()).Returns(list);

            //act
            var result = SystemUnderTest.GetAllDriversAsJson();

            //assert
            Assert.AreEqual("[{\"firstName\":\"Ireney\",\"lastName\":\"Berezniak\",\"teamName\":\"Scuderia Ferrari\",\"nationality\":\"Polish\",\"placeOfBirth\":\"Sanok\"},{\"firstName\":\"Ireney\",\"lastName\":\"Berezniak\",\"teamName\":\"Scuderia Ferrari\",\"nationality\":\"Polish\",\"placeOfBirth\":\"Sanok\"},{\"firstName\":\"Ireney\",\"lastName\":\"Berezniak\",\"teamName\":\"Scuderia Ferrari\",\"nationality\":\"Polish\",\"placeOfBirth\":\"Sanok\"}]", 
                result);
        }
    }
}
