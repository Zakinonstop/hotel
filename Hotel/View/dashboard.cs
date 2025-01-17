using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.Controller;

namespace Hotel.View
{
    public partial class dashboard : Form
    {
        private KamarController controller;
        
        public dashboard()
        {
            InitializeComponent();
            controller = new KamarController();
        }

       private void dashboard_Load(object sender, EventArgs e)
        {
            getJumlahKamar();
            lblKamarTerpakai.Text = controller.GetJumlahKamarTerpakai().ToString();
        }

        private void getJumlahKamar()
        {
            try
            {
                int jumlahkamar = controller.GetJumlahkamarTersedia();

                lblKamarTersedia.Text = jumlahkamar.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void lblKamarTersedia_Click(object sender, EventArgs e)
        {

        }

        private void lblKamarTerpakai_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_Load_1(object sender, EventArgs e)
        {

        }
    }
}
