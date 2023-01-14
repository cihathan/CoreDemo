using Business.Abstract;
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
        EfCategoryRepository efCategoryRepository;

        public CategoryManager()
        {
            efCategoryRepository= new EfCategoryRepository();
        }
        public void AddCategory(Category category)
        {
            efCategoryRepository.Insert(category);
        }

        public void DeleteCategory(Category category)
        {
            efCategoryRepository.Delete(category);
        }

        public List<Category> GetAllCategories()
        {
            return efCategoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return efCategoryRepository.GetById(id);
        }

        public void UpdateCategory(Category category)
        {
            efCategoryRepository.Update(category);
        }
    }
}
