using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Plugin.Widgets.Discount.Models;
using Nop.Services.Configuration;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Widgets.Discount.Component
{
    [ViewComponent(Name = "WidgetsDiscount")]
    public class WidgetDiscountViewComponent : NopViewComponent
    {
        private readonly IStoreContext _storeContext;
        private readonly ISettingService _settingService;

        public WidgetDiscountViewComponent(IStoreContext storeContext,
            ISettingService settingService)
        {
            _storeContext = storeContext;
            _settingService = settingService;
        }

        public IViewComponentResult Invoke(string widgetZone, object additionalData)
        {
            var settings = _settingService.LoadSetting<DiscountSettings>(_storeContext.CurrentStore.Id);

            var model = new PublicInfoModel
            {
                DiscountString = settings.DiscountString
            };

            return View("~/Plugins/Widgets.Discount/Views/PublicInfo.cshtml", model);
        }
    }
}
