using Abp.Web.Mvc.Views;

namespace JoesComicShopv2.Web.Views
{
    public abstract class JoesComicShopv2WebViewPageBase : JoesComicShopv2WebViewPageBase<dynamic>
    {

    }

    public abstract class JoesComicShopv2WebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected JoesComicShopv2WebViewPageBase()
        {
            LocalizationSourceName = "JoesComicShopv2";
        }
    }
}