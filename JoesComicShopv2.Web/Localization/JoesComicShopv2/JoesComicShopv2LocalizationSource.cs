using System.Web;
using Abp.Localization.Sources.Xml;

namespace JoesComicShopv2.Web.Localization.JoesComicShopv2
{
    public class JoesComicShopv2LocalizationSource : XmlLocalizationSource
    {
        public JoesComicShopv2LocalizationSource()
            : base("JoesComicShopv2", HttpContext.Current.Server.MapPath("/Localization/JoesComicShopv2"))
        {
        }
    }
}