using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Category
{
	public class CategoryListDashboard : ViewComponent
	{
		CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
		public IViewComponentResult Invoke()
		{
			var values = categoryManager.GetAll();
			return View(values);
		}
	}
}
