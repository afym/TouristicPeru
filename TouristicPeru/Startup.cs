using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TouristicPeru.Startup))]
namespace TouristicPeru
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
