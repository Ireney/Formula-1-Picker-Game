using System;
using System.Data.Entity;
using CleverDogStudios.FormulaOnePickr.Core.Drivers;
using CleverDogStudios.FormulaOnePickr.Core.Teams;
using CleverDogStudios.FormulaOnePickr.Data.Configuration;

namespace CleverDogStudios.FormulaOnePickr.Data.DataContexts
{
    public class FormulaOnePickrContext : DbContext, ISeedable<FormulaOnePickrContext>
    {
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Team> Teams { get; set; }
        
        public FormulaOnePickrContext() : base("FormulaOnePickr")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DriverEntityConfiguration());
        }

        public void Seed(FormulaOnePickrContext context)
        {
            var mcLaren = new Team("McLaren", "Vodafone McLaren Mercedes", "Woking, UK");
            var redBull = new Team("Red Bull Racing", "Red Bull Racing", "Milton Keynes, UK");
            var ferrari = new Team("Ferrari", "Scuderia Ferrari", "Maranello, Italy");
            var sauber = new Team("Sauber", "Sauber F1 Team", "Hinwil, Switzerland");
            var lotus = new Team("Lotus", "Lotus F1 Team", "Enstone, UK");
            var forceIndia = new Team("Force India", "Sahara Force India F1 Team", "Silverstone, UK");
            var williams = new Team("Williams", "Williams F1 Team", "Grove, UK");
            var toroRosso = new Team("Toro Rosso", "Scuderia Toro Rosso", "Faenza, Italy");
            var mercedes = new Team("Mercedes", "Mercedes AMG Petronas F1 Team", "Brackley, UK");
            var marussia = new Team("Marussia", "Marussia F1 Team", "Banbury, UK");
            var caterham = new Team("Caterham", "Caterham F1 Team", "Hingham, UK");
            var hrt = new Team("HRT", "HRT F1 Team", "Madrid, Spain");

            context.Teams.Add(mcLaren);
            context.Teams.Add(redBull);
            context.Teams.Add(ferrari);
            context.Teams.Add(sauber);
            context.Teams.Add(lotus);
            context.Teams.Add(forceIndia);
            context.Teams.Add(williams);
            context.Teams.Add(toroRosso);
            context.Teams.Add(mercedes);
            context.Teams.Add(marussia);
            context.Teams.Add(caterham);
            context.Teams.Add(hrt);
            
            var hamilton = new Driver("Lewis", "Hamilton", "British", new DateTime(1985, 1, 7), "Stevenage", mcLaren);
            var button = new Driver("Jenson", "Button", "British", new DateTime(1980, 1, 19), "Frome, Somerset", mcLaren);
            var alonso = new Driver("Fernando", "Alonso", "Spanish", new DateTime(1981, 7, 29), "Oviedo", ferrari);
            var massa = new Driver("Felipe", "Massa", "Brazilian", new DateTime(1981, 4, 25), "Sao Paulo", ferrari);
            var vettel = new Driver("Sebastian", "Vettel", "German", new DateTime(1987, 7, 3), "Heppenheim", redBull);
            var webber = new Driver("Mark", "Webber", "Australian", new DateTime(1976, 8, 27), "Queanbeyan, New South Wales", redBull);
            var perez = new Driver("Sergio", "Perez", "Mexican", new DateTime(1990, 1, 26), "Guadalajara", sauber);
            var kobayashi = new Driver("Kamui", "Kobayashi", "Japanese", new DateTime(1986, 9, 13), "Hyogo", sauber);
            var raikkonen = new Driver("Kimi", "Räikkönen", "Finnish", new DateTime(1979, 10, 17), "Espoo", lotus);
            var grosjean = new Driver("Romain", "Grosjean", "French", new DateTime(1986, 4, 17), "Geneva, Switzerland", lotus);
            var diResta = new Driver("Paul", "di Resta", "British", new DateTime(1986, 4, 16), "Uphall, Scotland", forceIndia);
            var hulkenberg = new Driver("Nico", "Hulkenberg", "German", new DateTime(1987, 8, 19), "Emmerich", forceIndia);
            var senna = new Driver("Bruno", "Senna", "Brazilian", new DateTime(1983, 10, 15), "Sao Paulo", williams);
            var maldonado = new Driver("Pastor", "Maldonado", "Venezuelan", new DateTime(1985, 3, 9), "Maracay", williams);
            var vergne = new Driver("Jean-Eric", "Vergne", "French", new DateTime(1990, 4, 25), "Pontoise", toroRosso);
            var ricciardo = new Driver("Daniel", "Ricciardo", "French", new DateTime(1989, 7, 1), "Perth", toroRosso);
            var schumacher = new Driver("Michael", "Schumacher", "German", new DateTime(1969, 1, 3), "Hürth-Hermülheim", mercedes);
            var rosberg = new Driver("Nico", "Rosberg", "German", new DateTime(1985, 6, 27), "Wiesbaden", mercedes);
            var glock = new Driver("Timo", "Glock", "German", new DateTime(1982, 3, 18), "Lindenfels", marussia);
            var pic = new Driver("Charles", "Pic", "French", new DateTime(1990, 2, 15), "Montelimar", marussia);
            var petrov = new Driver("Vitaly", "Petrov", "Russian", new DateTime(1984, 9, 8), "Vyborg", caterham);
            var kovalainen = new Driver("Heikki", "Kovalainen", "Finnish", new DateTime(1981, 10, 19), "Suomussalmi", caterham);
            var deLaRosa = new Driver("Pedro", "de la Rosa", "Spanish", new DateTime(1971, 2, 24), "Barcelona", hrt);
            var karthikeyan = new Driver("Narain", "Karthikeyan", "Indian", new DateTime(1977, 1, 14), "Chennai", hrt);

            context.Drivers.Add(hamilton);
            context.Drivers.Add(button);
            context.Drivers.Add(alonso);
            context.Drivers.Add(massa);
            context.Drivers.Add(vettel);
            context.Drivers.Add(webber);
            context.Drivers.Add(perez);
            context.Drivers.Add(kobayashi);
            context.Drivers.Add(raikkonen);
            context.Drivers.Add(grosjean);
            context.Drivers.Add(diResta);
            context.Drivers.Add(hulkenberg);
            context.Drivers.Add(senna);
            context.Drivers.Add(maldonado);
            context.Drivers.Add(vergne);
            context.Drivers.Add(ricciardo);
            context.Drivers.Add(schumacher);
            context.Drivers.Add(rosberg);
            context.Drivers.Add(glock);
            context.Drivers.Add(pic);
            context.Drivers.Add(petrov);
            context.Drivers.Add(kovalainen);
            context.Drivers.Add(deLaRosa);
            context.Drivers.Add(karthikeyan);

            context.SaveChanges();
        }
    }
}
