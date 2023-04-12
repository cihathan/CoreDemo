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
	public class Message2Manager : IMessage2Service
	{
		IMessage2Dal message2Dal;

		public Message2Manager(IMessage2Dal message2Dal)
		{
			this.message2Dal = message2Dal;
		}

		public void Add(Message2 t)
		{
			message2Dal.Insert(t);
		}

		public void Delete(Message2 t)
		{
			throw new NotImplementedException();
		}

		public List<Message2> GetAll()
		{
			return message2Dal.GetListAll();
		}

		public Message2 GetById(int id)
		{
			return message2Dal.GetById(id);
		}

		public List<Message2> GetMessageInboxListByWriter(int id)
		{
			return message2Dal.GetMessageInboxListByWriter(id);
		}

        public List<Message2> GetMessageSendboxListByWriter(int id)
        {
			return message2Dal.GetMessageSendboxListByWriter(id);
        }

        public void Update(Message2 t)
		{
			throw new NotImplementedException();
		}
	}
}
