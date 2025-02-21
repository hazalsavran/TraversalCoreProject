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
    public class AbouthManager : IAbouthService
    {
        IAbouthDal _abouthDal;

        public AbouthManager(IAbouthDal abouthDal)
        {
            _abouthDal = abouthDal;
        }

        public void Add(Abouth entity)
        {
            _abouthDal.Insert(entity);
        }

        public void Delete(Abouth entity)
        {
            _abouthDal.Delete(entity);
        }

        public List<Abouth> GetAll()
        {
           return _abouthDal.GetAll();
        }

        public Abouth GetById(int id)
        {
           throw new NotImplementedException();
        }

        public void Update(Abouth entity)
        {
            _abouthDal.Update(entity);
        }
    }
}
