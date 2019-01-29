using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Szkola.Startup1))]

namespace Szkola
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            // Aby uzyskać więcej informacji o sposobie konfigurowania aplikacji, odwiedź stronę https://go.microsoft.com/fwlink/?LinkID=316888
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Login")
            });
        }
    }
}
