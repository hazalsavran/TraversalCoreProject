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
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void Add(Announcement entity)
        {
            _announcementDal.Insert(entity);
        }

        public void Delete(Announcement entity)
        {
           _announcementDal.Delete(entity);
        }

        public List<Announcement> GetAll()
        {
           return _announcementDal.GetAll();
        }

        public Announcement GetById(int id)
        {
           return _announcementDal.GetByID(id);
        }

        public void Update(Announcement entity)
        {
            _announcementDal.Update(entity);
        }
    }
}
