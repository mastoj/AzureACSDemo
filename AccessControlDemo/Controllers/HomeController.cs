using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace AccessControlDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var ci = Thread.CurrentPrincipal.Identity as System.Security.Claims.ClaimsIdentity;
            var claims = Enumerable.Empty<Claim>();
            if (ci != null && ci.Claims != null)
            {
                claims = ci.Claims.AsEnumerable();
            }
            return View(claims);
        }

    }
}
