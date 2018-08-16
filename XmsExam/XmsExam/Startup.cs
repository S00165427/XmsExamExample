using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XmsExam.Startup))]
namespace XmsExam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
