using System;
using System.Data.Entity;
using System.Web;
using CleverDogStudios.FormulaOnePickr.Data.DataContexts;
using CleverDogStudios.FormulaOnePickr.Data.Initializers;
using CleverDogStudios.FormulaOnePickr.WebService.Dependencies;
using Ninject;
using Ninject.Web.Common;

namespace CleverDogStudios.FormulaOnePickr.WebService
{
    public class Global : NinjectHttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Database.SetInitializer(new RecreateDatabaseAndSeedIfModelChangesInitializer<FormulaOnePickrContext>());
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            EnableCrossDmainAjaxCall();
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

        private void EnableCrossDmainAjaxCall()
        {
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");

            if (HttpContext.Current.Request.HttpMethod != "OPTIONS") return;

            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "GET, POST");
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "Content-Type, Accept");
            HttpContext.Current.Response.AddHeader("Access-Control-Max-Age", "1728000");
            HttpContext.Current.Response.End();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>
        /// The created kernel.
        /// </returns>
        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Load(new CoreModule());
            kernel.Load(new DataModule());
            return kernel;
        }
    }
}