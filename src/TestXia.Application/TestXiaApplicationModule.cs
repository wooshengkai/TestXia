using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TestXia.Authorization;

namespace TestXia
{
    [DependsOn(
        typeof(TestXiaCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TestXiaApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TestXiaAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TestXiaApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
