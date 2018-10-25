using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PersonalCashFlow.Configuration;
using PersonalCashFlow.EntityFrameworkCore;
using PersonalCashFlow.Migrator.DependencyInjection;

namespace PersonalCashFlow.Migrator
{
    [DependsOn(typeof(PersonalCashFlowEntityFrameworkModule))]
    public class PersonalCashFlowMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public PersonalCashFlowMigratorModule(PersonalCashFlowEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(PersonalCashFlowMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                PersonalCashFlowConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PersonalCashFlowMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
