using CleverDogStudios.FormulaOnePickr.Core.Drivers;
using CleverDogStudios.FormulaOnePickr.Core.Teams;
using Moq;

namespace CleverDogStudios.FormulaOnePickr.Tests.Common
{
    public static class MockObjectMother
    {
        public static Mock<IDriver> MockDriver(string firstName = "Ireney", string lastName = "Berezniak", Team team = null)
        {
            var mock = new Mock<IDriver>();
            mock.SetupGet(m => m.FirstName).Returns(firstName);
            mock.SetupGet(m => m.LastName).Returns(lastName);
            mock.Setup(m => m.Team).Returns(team);
            return mock;
        }

        public static Mock<ITeam> MockTeam(string fullName = "Ferrari")
        {
            var mock = new Mock<ITeam>();
            mock.SetupGet(m => m.FullName).Returns(fullName);
            return mock;
        }
    }
}
