using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dai.Blog.Web.Startup))]
namespace Dai.Blog.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
          
        }
    }
}
