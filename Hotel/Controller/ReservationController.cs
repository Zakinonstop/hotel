using Hotel.View;
using Hotel.Model.Entry;
using Hotel.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservasi.Model.Repository;

namespace HotelReservasi.Controller
{
    public class ReservationController
    {
        private readonly ReservationRepository repository;

        public ReservationController()
        {
            repository = new ReservationRepository();
        }

        public void AddReservation(Reservations reservation)
        {
            repository.AddReservation(reservation);
        }

        public List<Reservations> GetReservations()
        {
            return repository.GetReservations();
        }

        public void DeleteReservation(int roomNumber)
        {
            repository.DeleteReservation(roomNumber);
        }
    }
}
