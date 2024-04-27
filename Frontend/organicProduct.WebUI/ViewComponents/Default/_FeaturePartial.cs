using Microsoft.AspNetCore.Mvc;

namespace organicProduct.WebUI.ViewComponents.Default
{
    public class _FeaturePartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
