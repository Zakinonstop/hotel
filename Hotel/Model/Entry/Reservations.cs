using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model.Entry
{
    public class Reservations
    {
        public int Id_reservasi {  get; set; }
        public string Name { get; set; }
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal DailyRate { get; set; }
        public decimal TotalPrice => (CheckOutDate - CheckInDate).Days * DailyRate;
    }
}
