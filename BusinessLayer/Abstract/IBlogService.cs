using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IBlogService
	{
        void AddBlog(Blog blog);
        void DeleteBlog(Blog blog);
        void UpdateBlog(Blog blog);
        List<Blog> GetAllBlogs();
        Blog GetById(int id);
        List<Blog> GetBlogListWithCategory();
        
    }
}
