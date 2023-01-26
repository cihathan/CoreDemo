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
	public class ContactManager : IContactService
	{
		IContactDal contactDal;

		public ContactManager(IContactDal contactDal)
		{
			this.contactDal = contactDal;
		}

		public void AddContact(Contact contact)
		{
			contactDal.Insert(contact);
		}
	}
}
