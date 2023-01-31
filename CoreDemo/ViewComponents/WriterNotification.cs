using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class WriterNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
