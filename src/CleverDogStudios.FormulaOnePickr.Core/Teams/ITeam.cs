using System;

namespace CleverDogStudios.FormulaOnePickr.Core.Teams
{
    public interface ITeam
    {
        int TeamId { get; set; }
        string ShortName { get; set; }
        string FullName { get; set; }
        string TeamBase { get; set; }
    }
}