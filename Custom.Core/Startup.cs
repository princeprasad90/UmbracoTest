using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Web;

[assembly: OwinStartup("MyStartup", typeof(Custom.Core.Startup))]
namespace Custom.Core
{
    public partial class Startup: UmbracoDefaultOwinStartup
    {
        public override void Configuration(IAppBuilder app)
        {
             base.Configuration(app);
        }
    }
}
