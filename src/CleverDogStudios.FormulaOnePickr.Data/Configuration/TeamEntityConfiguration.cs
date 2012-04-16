using System.Data.Entity.ModelConfiguration;
using CleverDogStudios.FormulaOnePickr.Core.Teams;

namespace CleverDogStudios.FormulaOnePickr.Data.Configuration
{
    public class TeamEntityConfiguration : EntityTypeConfiguration<Team>
    {
        public TeamEntityConfiguration()
        {
            Property(p => p.FullName).IsRequired().HasMaxLength(64);
            Property(p => p.ShortName).IsRequired().HasMaxLength(16);
            Property(p => p.TeamBase).IsRequired().HasMaxLength(32);
        }
    }
}
