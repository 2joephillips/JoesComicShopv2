using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using JoesComicShopv2.EntityFramework;

namespace JoesComicShopv2
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(JoesComicShopv2CoreModule))]
    public class JoesComicShopv2DataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<JoesComicShopv2DbContext>(null);
        }
    }
}
