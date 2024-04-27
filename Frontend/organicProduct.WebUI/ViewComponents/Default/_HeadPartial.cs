using Microsoft.AspNetCore.Mvc;
namespace organicProduct.WebUI.ViewComponents.Default
{
    public class _HeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }

    }
}
