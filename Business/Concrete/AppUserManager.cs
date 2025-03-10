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
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void Add(AppUser entity)
        {
            _appUserDal.Insert(entity);
        }

        public void Delete(AppUser entity)
        {
            _appUserDal.Delete(entity);
        }

        public List<AppUser> GetAll()
        {
            return _appUserDal.GetAll();
        }

        public AppUser GetById(int id)
        {
           return  _appUserDal.GetByID(id);
        }

        public void Update(AppUser entity)
        {
            _appUserDal.Update(entity);
        }
    }
}
