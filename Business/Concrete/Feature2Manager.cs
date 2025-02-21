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
    public class Feature2Manager : IFeature2Service
    {
        IFeature2Dal _featureDal;

        public Feature2Manager(IFeature2Dal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Add(Feature2 entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Feature2 entity)
        {
            throw new NotImplementedException();
        }

        public List<Feature2> GetAll()
        {
            return _featureDal.GetAll();
        }

        public Feature2 GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Feature2 entity)
        {
            throw new NotImplementedException();
        }
    }
}
