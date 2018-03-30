using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using KnockoutCrudExample.Models;

namespace KnockoutCrudExample
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ReservationRepository.Storage = new List<Reservation>();
            ReservationRepository.Storage.AddRange(new List<Reservation>() {
                 new Reservation() { ClientName="Вова", Location="Тольятти", ReservationId=1},
                new Reservation() { ClientName="Паша", Location="Самара", ReservationId=2},
                new Reservation() { ClientName="Вася", Location="Вологда", ReservationId=3},
            });
        }
    }
}
