using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using cursoazuredevops.Configuration;
using cursoazuredevops.EntityFrameworkCore;
using cursoazuredevops.Migrator.DependencyInjection;

namespace cursoazuredevops.Migrator
{
    [DependsOn(typeof(cursoazuredevopsEntityFrameworkModule))]
    public class cursoazuredevopsMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public cursoazuredevopsMigratorModule(cursoazuredevopsEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(cursoazuredevopsMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                cursoazuredevopsConsts.ConnectionStringName
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
            IocManager.RegisterAssemblyByConvention(typeof(cursoazuredevopsMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
