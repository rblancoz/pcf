using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PersonalCashFlow.Configuration;

namespace PersonalCashFlow.Web.Host.Startup
{
    [DependsOn(
       typeof(PersonalCashFlowWebCoreModule))]
    public class PersonalCashFlowWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PersonalCashFlowWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PersonalCashFlowWebHostModule).GetAssembly());
        }
    }
}
