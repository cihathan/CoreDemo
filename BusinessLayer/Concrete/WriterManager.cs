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
    public class WriterManager : IWriterService
    {
        IWriterDal writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            this.writerDal = writerDal;
        }

        public void Add(Writer t)
        {
            writerDal.Insert(t);
        }
  
        public void Delete(Writer t)
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Writer GetById(int id)
        {
            return writerDal.GetById(id);
        }

        public List<Writer> GetWriterById(int id)
        {
            return writerDal.GetAll(x=>x.WriterId == id);
        }

        public void Update(Writer t)
        {
            writerDal.Update(t);
        }
    }
}
