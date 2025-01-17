using Hotel.View;
using Hotel.Controller;
using Hotel.Model.Entry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using HotelReservasi.Controller;


namespace HotelReservasi.View
{
    public partial class ReservationForm : Form
    {
        private ReservationController controller;

        public ReservationForm()
        {
            InitializeComponent();
            controller = new ReservationController();
        }

        private void DisplayReservations()
        {
            var reservations = controller.GetReservations();
            dvgReservation.DataSource = null;
            dvgReservation.DataSource = reservations;
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            var reservation = new Reservations
            {
                Name = txtNameR.Text,
                RoomNumber = int.Parse(txtRoomNR.Text),
                RoomType = txtRoomTR.Text,
                CheckInDate = DateCheckIn.Value,
                CheckOutDate = DateCheckOut.Value,
                DailyRate = decimal.Parse(txtHarga.Text)
            };

            controller.AddReservation(reservation);
            MessageBox.Show("Reservation added successfully!");
            DisplayReservations();
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            int roomNumber = int.Parse(Text);
            controller.DeleteReservation(roomNumber);
            MessageBox.Show("Reservation deleted successfully!");
            DisplayReservations();
        }
    }
}
