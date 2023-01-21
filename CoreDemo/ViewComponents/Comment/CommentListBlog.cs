using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Comment
{
	public class CommentListBlog:ViewComponent
	{
		CommentManager commentManager = new CommentManager(new EfCommentRepository());
		public IViewComponentResult Invoke(int id)
		{
			var values = commentManager.GetAllComments(id);
			return View(values);
		}
	}
}
