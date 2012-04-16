using System;
using CleverDogStudios.FormulaOnePickr.Core.Teams;

namespace CleverDogStudios.FormulaOnePickr.Core.Drivers
{
    public interface IDriver
    {
        int DriverId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Nationality { get; set; }
        DateTime DateOfBirth { get; set; }
        string PlaceOfBirth { get; set; }
        Team Team { get; set; }
    }
}