using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			this.blogDal = blogDal;
		}

		public void AddBlog(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void DeleteBlog(Blog blog)
		{
			throw new NotImplementedException();
		}
		
		public List<Blog> GetAllBlogs()
		{
			return blogDal.GetAll();
		}

		public Blog GetById(int id)
		{
			throw new NotImplementedException();
		}

		public void UpdateBlog(Blog blog)
		{
			throw new NotImplementedException();
		}
	}
}
