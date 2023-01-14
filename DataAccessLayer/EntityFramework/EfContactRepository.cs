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
    // Entity Framework Contact Repository
    public class EfContactRepository:GenericRepository<Contact>, IContactDal
    {
    }
}
