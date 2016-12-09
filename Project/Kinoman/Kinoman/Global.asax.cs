using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using Kinoman.Models;

namespace Kinoman
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
           // DataBase.SetInitializer(new MigrateDatabaseToLatestVersion<AplicationDbContext, Migrations.Configuration>());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
