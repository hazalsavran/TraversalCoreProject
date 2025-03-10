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
    public class GuideManager : IGuideService
    {
        IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void Add(Guide entity)
        {
            _guideDal.Insert(entity);
        }

        public void Delete(Guide entity)
        {
            _guideDal.Delete(entity);
        }

        public List<Guide> GetAll()
        {
           return  _guideDal.GetAll();
        }

        public Guide GetById(int id)
        {
            return _guideDal.GetByID(id);
        }

        public void Update(Guide entity)
        {
            _guideDal.Update(entity);
        }
    }
}
