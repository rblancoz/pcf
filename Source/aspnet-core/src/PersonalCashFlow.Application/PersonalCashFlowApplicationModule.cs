using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PersonalCashFlow.Authorization;

namespace PersonalCashFlow
{
    [DependsOn(
        typeof(PersonalCashFlowCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PersonalCashFlowApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PersonalCashFlowAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PersonalCashFlowApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
