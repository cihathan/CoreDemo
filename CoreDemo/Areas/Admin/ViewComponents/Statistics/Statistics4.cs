using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistics
{
    public class Statistics4 : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.adminValue = context.Admins.Where(x=>x.AdminId==1).Select(x=>x.Name).FirstOrDefault();
            ViewBag.adminImage = context.Admins.Where(x => x.AdminId==1).Select(x=>x.ImageUrl).FirstOrDefault();
            ViewBag.adminDescription = context.Admins.Where(x => x.AdminId == 1).Select(x => x.ShortDescription).FirstOrDefault();
            return View();
        }
    }
}
