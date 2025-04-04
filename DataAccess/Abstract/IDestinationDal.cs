﻿using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IDestinationDal : IRepository<Destination>
    {
        public Destination GetDestinationWithGuide(int id);
        public List<Destination> GetLast4Destinations();
    }
}
