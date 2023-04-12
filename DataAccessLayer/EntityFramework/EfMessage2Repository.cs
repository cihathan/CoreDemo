using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repositories;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfMessage2Repository : GenericRepository<Message2>, IMessage2Dal
    {
        public List<Message2> GetMessageInboxListByWriter(int id)
        {
            using (var context = new Context())
            {
                return context.Messages2.Include(x => x.SenderWriter).Where(x => x.SenderId == id).ToList();
            }
        }

        public List<Message2> GetMessageSendboxListByWriter(int id)
        {
            using (var context = new Context())
            {
                return context.Messages2.Include(x=>x.ReceiverWriter).Where(x=>x.SenderId==id).ToList();
            }
        }
    }
}
