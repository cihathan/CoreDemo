using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class NewsLetterController : Controller
	{
		NewsLetterManager newsLetterManager = new NewsLetterManager(new EfNewsLetterRepository());

		[HttpGet]
		public PartialViewResult SubscribeMail()
		{
			return PartialView();
		}
		[HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter newsLetter)
        {
			newsLetter.MailStatus = true;
			newsLetterManager.AddNewsLetter(newsLetter);
			Response.Redirect("/Blog/Index/");
            return PartialView();
        }

    }
}
