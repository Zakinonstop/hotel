using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.View;
using HotelReservasi.View;

namespace Hotel.View
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        
        private void main_Load(object sender, EventArgs e)
        {
            LoadForm(new dashboard());
        }
        private void ChangeAllFonts(Control control, Font newFont)
        {
            foreach (Control child in control.Controls)
            {
               child.Font = newFont;

                //Rekursif untuk kontrol anak
                if(child.HasChildren)
                {
                    ChangeAllFonts(child, newFont);
                }
            }
        }




        private void LoadForm(Form form)
        {
            PanelContra.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            PanelContra.Controls.Add(form);
            form.BringToFront();
            form.Show();
            PanelContra.Refresh();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            LoadForm(new dashboard());
        }

        private void main_Load_1(object sender, EventArgs e)
        {

        }

        private void ContrainerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Room_Click(object sender, EventArgs e)
        {
            LoadForm(new datakamar());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Form main = new Register();
            main.Show();
            this.Hide();
        }

        private void btn_Client_Click(object sender, EventArgs e)
        {
            LoadForm(new FrTamu());
        }

        private void btn_Reservasi_Click(object sender, EventArgs e)
        {
            LoadForm(new ReservationForm());
        }
    }
}
