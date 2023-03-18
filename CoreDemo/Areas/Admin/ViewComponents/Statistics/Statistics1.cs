using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistics
{
    public class Statistics1 : ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.blogsValue = blogManager.GetAll().Count;
            ViewBag.contactsValue = context.Contacts.Count();
            ViewBag.commentsValue = context.Comments.Count();
            return View();
        }
    }
}
