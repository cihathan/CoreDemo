using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreDemo.Controllers
{
	public class ContactController : Controller
	{
		ContactManager contactManager = new ContactManager(new EfContactRepository());

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
			contact.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			contact.ContactStatus = true;
			contactManager.AddContact(contact);
			return RedirectToAction("Index", "Blog");
        }
    }
}
