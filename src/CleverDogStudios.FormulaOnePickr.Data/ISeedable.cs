using System.Data.Entity;

namespace CleverDogStudios.FormulaOnePickr.Data
{
    public interface ISeedable<T> where T : DbContext
    {
        void Seed(T context);
    }
}
