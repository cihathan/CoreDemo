using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager (new EfBlogRepository());
        public IActionResult Index()
        {
            var values = blogManager.GetAllBlogs();
            return View(values);
        }
    }
}
