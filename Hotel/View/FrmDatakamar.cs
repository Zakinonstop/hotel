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
using Hotel.Model.Entry;
public delegate void CreateUpadteEventHandler(KamarEntity kamar);

namespace Hotel.View
{
    public partial class FrmDatakamar : Form
    {
        public event CreateUpadteEventHandler OnCreate;
        //Deklarasi event ketika terjadi proses update data
        public event CreateUpadteEventHandler OnUpdate;

        //Deklarasi objek controller
        private KamarController controller;

        //Deklarasi field untuk mentimpan status entry
        private bool isNewData = true;

        //Deklarasi untuk menyimpan objek buku
        private KamarEntity kamar;
        public FrmDatakamar()
        {
            InitializeComponent();
            controller = new KamarController();
        }

        public FrmDatakamar(string type, KamarController controller)
            : this()
        {
            this.Text = type;
            this.controller = controller;

        }

        public FrmDatakamar(string type, KamarEntity no_kamar, KamarController controller)
            : this()
        {
            this.Text = type;
            this.controller = controller;
            isNewData = false;
            kamar = no_kamar;

            //tampilkan data lama pada form
            cbTypeKamar.SelectedItem = kamar.Type;
            txtNoKamar.Text = kamar.No_Kamar;
            cbStatus.SelectedItem = kamar.Status;
            txtHargakamar.Text = kamar.Harga;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpanDatakamar_Click(object sender, EventArgs e)
        {
            if (isNewData) kamar = new KamarEntity();

            string Status = cbStatus.SelectedItem?.ToString();

            string Type = cbTypeKamar.SelectedItem?.ToString();

            //set nilai properti
            kamar.Type = Type;
            kamar.No_Kamar = txtNoKamar.Text;
            kamar.Status = Status;
            kamar.Harga = txtHargakamar.Text;

            int result = 0;

            if (isNewData)// Tamabah data baru
            {
                result = controller.Create(kamar, Type, Status);

                if (result > 0)
                {
                    OnCreate?.Invoke(kamar);

                    cbTypeKamar.SelectedItem = -1;
                    txtNoKamar.Clear();
                    cbStatus.SelectedItem = -1;
                    txtHargakamar.Clear();
                }
                this.Close();

            }
            else //edit data
            {
                result = controller.Update(kamar);

                if(result > 0)
                {
                    OnUpdate?.Invoke(kamar); //panggil event onUpdate
                    this.Close();
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
