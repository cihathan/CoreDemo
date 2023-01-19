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
	public class CommentManager : ICommentService
	{
		ICommentDal commentDal;

		public CommentManager(ICommentDal commentDal)
		{
			this.commentDal = commentDal;
		}

		public void AddComment(Comment comment)
		{
			throw new NotImplementedException();
		}

		public List<Comment> GetAllComments(int id)
		{
			return commentDal.GetAll(x => x.BlogId == id);
		}
	}
}
