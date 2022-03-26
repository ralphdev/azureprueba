using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using cursoazuredevops.Configuration;

namespace cursoazuredevops.Web.Host.Startup
{
    [DependsOn(
       typeof(cursoazuredevopsWebCoreModule))]
    public class cursoazuredevopsWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public cursoazuredevopsWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(cursoazuredevopsWebHostModule).GetAssembly());
        }
    }
}
