using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace JoesComicShopv2
{
    [DependsOn(typeof(AbpWebApiModule), typeof(JoesComicShopv2ApplicationModule))]
    public class JoesComicShopv2WebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(JoesComicShopv2ApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
