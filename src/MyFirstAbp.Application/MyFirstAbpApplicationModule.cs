using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MyFirstAbp
{
    [DependsOn(
        typeof(MyFirstAbpCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyFirstAbpApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyFirstAbpApplicationModule).GetAssembly());
        }
    }
}