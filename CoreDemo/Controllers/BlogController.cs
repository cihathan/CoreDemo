using System.Linq;
using Business.Concrete;
using Business.ValidationRules;
using DataAccess.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values = blogManager.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.Id = id;
            var values = blogManager.GetBlogById(id);
            return View(values);
        }
        public ActionResult BlogListByWriter()
        {
            var values = blogManager.Test(1);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddBlog()
        {           
            List<SelectListItem> categoryValues = (from x in categoryManager.GetAll() select new SelectListItem { Text = x.CategoryName, Value = x.CategoryId.ToString() }).ToList();
            ViewBag.categoryValue = categoryValues;
            return View();
        }
        [HttpPost]
        public IActionResult AddBlog(Blog blog)
        {
            BlogValidator validator = new BlogValidator();
            ValidationResult results = validator.Validate(blog);
            if (results.IsValid)
            {
                blog.BlogStatus = true;
                blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                blog.Writer.WriterId = 1;
                blogManager.Add(blog);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }        
        }
        public IActionResult DeleteBlog(int id)
        {
            var blogValue = blogManager.GetById(id);
            blogManager.Delete(blogValue);
            return RedirectToAction("BlogListByWriter");
        }
        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var blogValue = blogManager.GetById(id);
            List<SelectListItem> categoryValues = (from x in categoryManager.GetAll() select new SelectListItem { Text = x.CategoryName, Value = x.CategoryId.ToString() }).ToList();
            ViewBag.categoryValue = categoryValues;
            return View(blogValue);
        }
        [HttpPost]
        public IActionResult EditBlog(Blog blog)
        {
            blog.WriterId = 1;      
           
            blog.BlogStatus = true;
            blogManager.Update(blog);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
