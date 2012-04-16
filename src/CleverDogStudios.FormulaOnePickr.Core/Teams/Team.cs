using System;

namespace CleverDogStudios.FormulaOnePickr.Core.Teams
{
    public class Team : ITeam
    {
        public int TeamId { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string TeamBase { get; set; }

        public Team(){}

        public Team(string shortName, string fullName, string teamBase)
        {
            ShortName = shortName;
            FullName = fullName;
            TeamBase = teamBase;
        }
    }
}
