using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Dai.Blog.Web.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public async Task<ActionResult> Login()
        {
            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, "pokemon"));
            claims.Add(new Claim(ClaimTypes.Role, "Users"));
            var identity = new ClaimsIdentity(claims, DaiBlogAuthenticationTypes.ApplicationCookie);
            //HttpContext.GetOwinContext().Authentication.SignIn(new AuthenticationProperties { IsPersistent = true }, identity);
            HttpContext.GetOwinContext().Authentication.SignIn(identity);
            return Content("123");
        }
    }
}