using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;

namespace Dai.Blog.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs args)
        {
            //var claims = new List<Claim>();
            //claims.Add(new Claim(ClaimTypes.Name, "pokemon"));
            //claims.Add(new Claim(ClaimTypes.Role, "Users"));

            //var identity = new ClaimsIdentity(claims, "MyClaimLogin");

            //ClaimsPrincipal principal = new ClaimsPrincipal(identity);

            //((HttpApplication)sender).Context.User = principal;

            ////FormsAuthentication.SetAuthCookie("pokemon", false);
        }
    }
}
