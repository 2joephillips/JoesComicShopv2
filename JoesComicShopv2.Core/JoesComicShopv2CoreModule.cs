using System.Reflection;
using Abp.Modules;

namespace JoesComicShopv2
{
    public class JoesComicShopv2CoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
