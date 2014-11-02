using System.Reflection;
using Abp.Modules;

namespace JoesComicShopv2
{
    [DependsOn(typeof(JoesComicShopv2CoreModule))]
    public class JoesComicShopv2ApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
