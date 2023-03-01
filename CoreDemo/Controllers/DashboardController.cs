using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.Controllers
{
    public class DashboardController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());

        public IActionResult Index()
        {
            Context context = new Context();
            ViewBag.value1 = context.Blogs.Count();
            ViewBag.value2 = context.Blogs.Where(x => x.WriterId == 1).Count();
            ViewBag.value3 = context.Categories.Count();
            return View();
        }
    }
}
