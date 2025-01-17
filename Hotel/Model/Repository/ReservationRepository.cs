using Hotel.View;
using Hotel.Model.Entry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservasi.Model.Repository
{
    public class ReservationRepository
    {
        private List<Reservations> reservations = new List<Reservations>();

        public void AddReservation(Reservations reservation)
        {
            reservations.Add(reservation);
        }

        public List<Reservations> GetReservations()
        {
            return reservations;
        }

        public void DeleteReservation(int roomNumber)
        {
            reservations.RemoveAll(r => r.RoomNumber == roomNumber);
        }
    }
}
