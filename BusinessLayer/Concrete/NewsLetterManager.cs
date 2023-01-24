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
	public class NewsLetterManager : INewsLetterService
	{
		INewsLetterDal newsLetterDal;

		public NewsLetterManager(INewsLetterDal newsLetterDal)
		{
			this.newsLetterDal = newsLetterDal;
		}

		public void AddNewsLetter(NewsLetter newsLetter)
		{
			newsLetterDal.Insert(newsLetter);
		}
	}
}
