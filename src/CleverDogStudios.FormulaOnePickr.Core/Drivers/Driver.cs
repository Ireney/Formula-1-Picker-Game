using System;
using CleverDogStudios.FormulaOnePickr.Core.Teams;

namespace CleverDogStudios.FormulaOnePickr.Core.Drivers
{
    public class Driver : IDriver
    {
        public int DriverId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public int TeamId { get; set; }

        public Team Team { get; set; }

        public Driver() {}

        public Driver(string firstName, string lastName, string nationality, DateTime dateOfBirth, string placeOfBirth, Team team)
        {
            FirstName = firstName;
            LastName = lastName;
            Nationality = nationality;
            DateOfBirth = dateOfBirth;
            PlaceOfBirth = placeOfBirth;
            Team = team;
        }
    }
}
