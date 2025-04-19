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
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void Add(Destination entity)
        {
           _destinationDal.Insert(entity);
        }

        public void Delete(Destination entity)
        {
            _destinationDal.Delete(entity);
        }

        public List<Destination> GetAll()
        {
            return _destinationDal.GetAll();
        }
        public List<Destination> GetList()
        {
            return _destinationDal.GetList();
        }
        public Destination GetById(int id)
        {
            return _destinationDal.GetByID(id);
        }

        public void Update(Destination entity)
        {
            _destinationDal.Update(entity);
        }

        public Destination TGetDestinationWithGuide(int id)
        {
            return _destinationDal.GetDestinationWithGuide(id);
        }

        public List<Destination> TGetLast4Destinations()
        {
            return _destinationDal.GetLast4Destinations();
        }
    }
}
