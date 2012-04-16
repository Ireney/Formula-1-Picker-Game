﻿using System.Data.Entity;

namespace CleverDogStudios.FormulaOnePickr.Data.Initializers
{
    public class RecreateDatabaseAndSeedIfModelChangesInitializer<T> : DropCreateDatabaseAlways<T> where T : DbContext, ISeedable<T>
    {
        protected override void Seed(T context)
        {
            context.Seed(context);
            base.Seed(context);
        }
    }
}
