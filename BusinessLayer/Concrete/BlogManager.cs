using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

		public List<Blog> GetLast3Blog()
		{
			return blogDal.GetListAll().TakeLast(3).ToList();
		}

        public List<Blog> GetBlogListWithCategory()
        {
            return blogDal.GetListWithCategory();
        }
		public List<Blog> Test(int id)
		{
			return blogDal.GetListWithCategoryByWriter(id);
		}

		public List<Blog> GetBlogById(int id)
		{
			return blogDal.GetAll(x => x.BlogId == id);
		}

		public List<Blog> GetBlogListWithWriter(int id)
		{
			return blogDal.GetAll(x=>x.WriterId==id);
        }

		public object GetLast3Blog(object blog1, object blog2)
		{
			return blogDal.GetListAll().TakeLast(3).ToList();
		}

		public void Add(Blog t)
		{
			blogDal.Insert(t);
		}

		public void Delete(Blog t)
		{
			throw new NotImplementedException();
		}

		public void Update(Blog t)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetAll()
		{
			return blogDal.GetListAll();
		}

		public Blog GetById(int id)
		{
            throw new NotImplementedException();
        }
	}
}
