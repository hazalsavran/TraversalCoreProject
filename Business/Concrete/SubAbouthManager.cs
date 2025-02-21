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
    public class SubAbouthManager : ISubAbouthService
    {
        ISubAbouthDal _SubAbouthDal;

        public SubAbouthManager(ISubAbouthDal subAbouthDal)
        {
            _SubAbouthDal = subAbouthDal;
        }

        public void Add(SubAbouth entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(SubAbouth entity)
        {
            throw new NotImplementedException();
        }

        public List<SubAbouth> GetAll()
        {
            return _SubAbouthDal.GetAll();
        }

        public SubAbouth GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(SubAbouth entity)
        {
            throw new NotImplementedException();
        }
    }
}
