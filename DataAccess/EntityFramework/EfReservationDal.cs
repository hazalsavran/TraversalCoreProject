﻿using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repository;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.EntityFramework
{
    public class EfReservationDal : Repository<Reservation>, IReservationDal
    {
        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onaylandı" && x.AppUserId == id).ToList();
            }
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Geçmiş Rezervasyon" && x.AppUserId == id).ToList();
            }
        }

        public List<Reservation> GetListWithReservationByWaitAprroval(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onay Bekliyor" && x.AppUserId == id).ToList();
            }
        }
    }
}
