using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Routing;
using CleverDogStudios.FormulaOnePickr.Data.DataContexts;
using CleverDogStudios.FormulaOnePickr.Data.Initializers;

namespace CleverDogStudios.FormulaOnePickr.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            
            //init database
//            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ProductContext>());
            //Database.SetInitializer(new AlwaysRecreateAndSeedDatabaseInitializer<ProductContext>());
//            Database.SetInitializer(new AlwaysRecreateAndSeedDatabaseInitializer<FormulaOnePickrContext>()); 
            Database.SetInitializer(new RecreateDatabaseAndSeedIfModelChangesInitializer<FormulaOnePickrContext>());

            RegisterGlobalFilters(GlobalFilters.Filters); 
            RegisterRoutes(RouteTable.Routes);
        }
    }
}