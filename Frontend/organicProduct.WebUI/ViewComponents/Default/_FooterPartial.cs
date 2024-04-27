using Microsoft.AspNetCore.Mvc;

namespace organicProduct.WebUI.ViewComponents.Default
{
    public class _FooterPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
