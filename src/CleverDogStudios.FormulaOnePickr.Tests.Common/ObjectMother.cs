using System;
using CleverDogStudios.FormulaOnePickr.Core.Drivers;
using CleverDogStudios.FormulaOnePickr.Core.Teams;

namespace CleverDogStudios.FormulaOnePickr.Tests.Common
{
    public static class ObjectMother
    {
        public static Driver Driver(
            string firstName = "Ireney", 
            string lastName = "Berezniak",
            string nationality = "Polish",
            DateTime? dateOfBirth = null,
            string placeOfBirth = "Sanok",
            Team team = null)
        {
            return new Driver(firstName, lastName, nationality, (dateOfBirth.HasValue) ? dateOfBirth.Value : new DateTime(1976,8,13), placeOfBirth, team);
        }

        public static Team Team(string shortName = "Ferrari", string fullName = "Scuderia Ferrari", string teamBase = "Maranello")
        {
            return new Team(shortName, fullName, teamBase);   
        }
    }
}
