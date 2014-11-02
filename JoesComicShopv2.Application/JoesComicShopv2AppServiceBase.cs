using Abp.Application.Services;

namespace JoesComicShopv2
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class JoesComicShopv2AppServiceBase : ApplicationService
    {
        protected JoesComicShopv2AppServiceBase()
        {
            LocalizationSourceName = JoesComicShopv2Consts.LocalizationSourceName;
        }
    }
}