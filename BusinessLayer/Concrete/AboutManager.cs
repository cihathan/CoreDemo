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
    public class AboutManager : IAboutService
    {
        IAboutDal aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            this.aboutDal = aboutDal;
        }

        public void Add(About t)
        {
            throw new NotImplementedException();
        }

        public void Delete(About t)
        {
            throw new NotImplementedException();
        }

        public List<About> GetAll()
        {
            return aboutDal.GetListAll();
        }

        public About GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(About t)
        {
            throw new NotImplementedException();
        }
    }
}
