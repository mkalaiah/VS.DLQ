using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using VS.DLQ.Configuration;

namespace VS.DLQ.Web.Host.Startup
{
    [DependsOn(
       typeof(DLQWebCoreModule))]
    public class DLQWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DLQWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DLQWebHostModule).GetAssembly());
        }
    }
}
