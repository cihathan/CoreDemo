using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface ICommentService
	{
		void AddComment(Comment comment);
		
		List<Comment> GetAllComments(int id);

        List<Comment> GetCommentWithBlog();

    }
}
