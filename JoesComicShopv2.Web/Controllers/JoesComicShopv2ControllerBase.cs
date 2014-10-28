using Abp.Web.Mvc.Controllers;

namespace JoesComicShopv2.Web.Controllers
{
    public abstract class JoesComicShopv2ControllerBase : AbpController
    {
        protected JoesComicShopv2ControllerBase()
        {
            LocalizationSourceName = "JoesComicShopv2";
        }
    }
}