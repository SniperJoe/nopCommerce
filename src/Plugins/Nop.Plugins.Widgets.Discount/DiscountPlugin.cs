using System.Collections.Generic;
using Nop.Core;
using Nop.Services.Cms;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;
namespace Nop.Plugins.Widgets.Discount
{
    public class DiscountPlugin : BasePlugin, IWidgetPlugin
    {
        private IWebHelper _webHelper;

        public DiscountPlugin(IWebHelper webHelper)
        {
            this._webHelper = webHelper;
        }

        public string GetWidgetViewComponentName(string widgetZone)
        {
            return "WidgetsDiscount";
        }

        public IList<string> GetWidgetZones()
        {
            return new List<string> { PublicWidgetZones.ProductDetailsBottom };
        }

        public override string GetConfigurationPageUrl()
        {
            return _webHelper.GetStoreLocation() + "Admin/WidgetsDiscount/Configure";
        }
    }
}
