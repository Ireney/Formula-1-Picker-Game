using System.Data.Entity.ModelConfiguration;
using CleverDogStudios.FormulaOnePickr.Core.Drivers;

namespace CleverDogStudios.FormulaOnePickr.Data.Configuration
{
    public class DriverEntityConfiguration : EntityTypeConfiguration<Driver>
    {
        public DriverEntityConfiguration()
        {
            Property(p => p.FirstName).IsRequired().HasMaxLength(32);
            Property(p => p.LastName).IsRequired().HasMaxLength(32);
            Property(p => p.Nationality).IsRequired().HasMaxLength(32);
            Property(p => p.PlaceOfBirth).IsRequired().HasMaxLength(32);
        }
    }
}
