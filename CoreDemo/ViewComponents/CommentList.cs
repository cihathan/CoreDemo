using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents
{
	public class CommentList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>
			{
				new UserComment
				{
					Id= 1,
					UserName="Han"
				},
				new UserComment
				{
					Id= 2,
					UserName="Berkcan"
				},
				new UserComment
				{
					Id= 3,
					UserName="Devrim"
				}
			};
			return View(commentvalues);
		}
	}
}
