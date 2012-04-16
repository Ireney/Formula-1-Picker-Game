using CleverDogStudios.FormulaOnePickr.Core.Drivers;
using CleverDogStudios.FormulaOnePickr.Tests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleverDogStudios.FormulaOnePickr.WebService.Tests
{
    [TestClass]
    public class FormulaOnePickrServiceTest : FactFixture<FormulaOnePickrService>
    {
        [TestMethod]
        public void ShouldGetAllDriversAsJson_OnGetDrivers()
        {
            //arrange
            ArrangeConstructorDependencies();

            //act
            SystemUnderTest.GetDrivers();

            //assert
            AutoMock<IDriverService>().Verify(m => m.GetAllDriversAsJson());
        }
    }
}
