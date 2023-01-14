using DataAccess.Abstract;
using DataAccess.Repositories;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    // Entity Framework Blog Repository
    public class EfBlogRepository:GenericRepository<Blog>, IBlogDal
    {
    }
}
