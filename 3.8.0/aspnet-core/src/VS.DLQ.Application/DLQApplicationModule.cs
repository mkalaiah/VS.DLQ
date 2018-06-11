using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using VS.DLQ.Authorization;

namespace VS.DLQ
{
    [DependsOn(
        typeof(DLQCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DLQApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DLQAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DLQApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
