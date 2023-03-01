using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class MessageController : Controller
	{
		Message2Manager message2Manager=new Message2Manager(new EfMessage2Repository());
		public IActionResult Inbox()
		{
			int id = 2;
			var values = message2Manager.GetMessageInboxListByWriter(id);
			return View(values);
		}
		public IActionResult MessageDetails(int id)
		{
			var value = message2Manager.GetById(id);
			return View(value);
		}
	}
}
