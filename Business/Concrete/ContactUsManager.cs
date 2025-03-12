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
    public class ContactUsManager : IContactUsService
    {
        IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void Add(ContactUs entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ContactUs entity)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> GetAll()
        {
           return _contactUsDal.GetAll();
        }

        public ContactUs GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> TGetListContactUsByFalse()
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> TGetListContactUsByTrue()
        {
            throw new NotImplementedException();
        }

        public void Update(ContactUs entity)
        {
            throw new NotImplementedException();
        }
    }
}
