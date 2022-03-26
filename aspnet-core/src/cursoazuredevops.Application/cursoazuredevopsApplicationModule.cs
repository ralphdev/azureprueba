using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using cursoazuredevops.Authorization;

namespace cursoazuredevops
{
    [DependsOn(
        typeof(cursoazuredevopsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class cursoazuredevopsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<cursoazuredevopsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(cursoazuredevopsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
