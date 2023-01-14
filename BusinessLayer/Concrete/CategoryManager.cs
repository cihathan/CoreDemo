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

        public void AddCategory(Category category)
        {
            this.categoryDal.Insert(category);
        }

        public void DeleteCategory(Category category)
        {
            this.categoryDal.Delete(category);
        }

        public List<Category> GetAllCategories()
        {
            return this.categoryDal.GetAll();
        }

        public Category GetById(int id)
        {
            return this.categoryDal.GetById(id);
        }

        public void UpdateCategory(Category category)
        {
            this.categoryDal.Update(category);
        }
    }
}
