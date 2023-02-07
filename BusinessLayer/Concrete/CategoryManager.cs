using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }

        public void Add(Category t)
        {
            categoryDal.Insert(t);
        }

        public void Delete(Category t)
        {
            categoryDal.Delete(t);
        }

        public List<Category> GetAll()
        {
            return categoryDal.GetListAll();
        }

        public Category GetById(int id)
        {
            return categoryDal.GetById(id);
        }

        public void Update(Category t)
        {
            categoryDal.Update(t);
        }
    }
}
