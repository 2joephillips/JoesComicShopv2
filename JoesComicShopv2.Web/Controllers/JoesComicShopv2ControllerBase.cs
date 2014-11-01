using Abp.Web.Mvc.Controllers;

namespace JoesComicShopv2.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class JoesComicShopv2ControllerBase : AbpController
    {
        protected JoesComicShopv2ControllerBase()
        {
            LocalizationSourceName = JoesComicShopv2Consts.LocalizationSourceName;
        }
    }
}