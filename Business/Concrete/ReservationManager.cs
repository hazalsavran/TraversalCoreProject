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
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            return _reservationDal.GetListWithReservationByAccepted(id);
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            return _reservationDal.GetListWithReservationByPrevious(id);
        }

        public List<Reservation> GetListWithReservationByWaitAprroval(int id)
        {
            return _reservationDal.GetListWithReservationByWaitAprroval(id);
        }

        public void Add(Reservation t)
        {
            _reservationDal.Insert(t);
        }

        public void Delete(Reservation t)
        {
            throw new NotImplementedException();
        }

        public Reservation GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Reservation t)
        {
            throw new NotImplementedException();
        }
    }
}
