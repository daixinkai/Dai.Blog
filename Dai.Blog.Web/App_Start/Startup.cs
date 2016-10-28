using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dai.Blog.Web.Startup))]
namespace Dai.Blog.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DaiBlogAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/account/login"),
            });

            app.UseExternalSignInCookie(DaiBlogAuthenticationTypes.ExternalCookie);

        }
    }
}
