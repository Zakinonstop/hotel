using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.Controller;
using Hotel.Model.Entry;
using Hotel.Model.Repository;

namespace Hotel.View
{
    public delegate void TamuEventHandler(Tamu tamu);
    public partial class FrTamu : Form
    {
        private List<Tamu> listOfTamu= new List<Tamu>();
        
        private TamuController tamuController;

        private bool isNewData = true;

        private Tamu tamu;

        public event TamuEventHandler OnCreate;

        
        
        public FrTamu()
        {
            InitializeComponent();

            tamuController = new TamuController();

            InisialisasiListView();
            LoadDataTamu();


        }

        public void InisialisasiListView()
        {
            lvlDataTamu.View = System.Windows.Forms.View.Details;
            lvlDataTamu.FullRowSelect = true;
            lvlDataTamu.GridLines = true;

            //Menambahkan kolom ke dalam ListView
            lvlDataTamu.Columns.Add("No.", 35, HorizontalAlignment.Center);
            //lvlDataTamu.Columns.Add("ID Kamar", 20, HorizontalAlignment.Center);
            lvlDataTamu.Columns.Add("Nama", 120, HorizontalAlignment.Center);
            lvlDataTamu.Columns.Add("KTP", 150, HorizontalAlignment.Center);
            lvlDataTamu.Columns.Add("Alamat", 150, HorizontalAlignment.Center);
            lvlDataTamu.Columns.Add("No_Hp", 120, HorizontalAlignment.Center);
            lvlDataTamu.Columns.Add("Email", 120, HorizontalAlignment.Center);

        }

        public void LoadDataTamu()
        {
            //kosongkan ListView
            lvlDataTamu.Items.Clear();

            //panggil method ReadAll
            listOfTamu = tamuController.ReadAll();

            foreach ( var tamu in listOfTamu )
            {
                var noUrut = lvlDataTamu.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(tamu.Nama);
                item.SubItems.Add(tamu.KTP);
                item.SubItems.Add(tamu.Alamat);
                item.SubItems.Add(tamu.No_Hp);
                item.SubItems.Add(tamu.Email);

                //Tampilkan data Tamu ke listview
                lvlDataTamu.Items.Add(item);


            }
        }

        private void OnCreateEventHandler(Tamu tamu)
        {
            listOfTamu.Add(tamu);

            int noUrut = lvlDataTamu.Items.Count + 1;

            //tampilan data tamu ke listview
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(tamu.Nama);
            item.SubItems.Add(tamu.KTP);
            item.SubItems.Add(tamu.Alamat);
            item.SubItems.Add(tamu.No_Hp);
            item.SubItems.Add(tamu.Email);

            lvlDataTamu.Items.Add(item);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrTamu_Load(object sender, EventArgs e)
        {

        }

        private void btnSimpanDataTamu_Click(object sender, EventArgs e)
        {

            if (isNewData) tamu = new Tamu();

            // set nilai property objek layanan yang diambil dari TextBox
            tamu.KTP = txtKTP.Text;
            tamu.Nama = txtNamaTamu.Text;
            tamu.Alamat = txtAlamat.Text;
            tamu.No_Hp = txtNo_Hp.Text;
            tamu.Email = txtEmail.Text;

            int result = 0;

            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = tamuController.Create(tamu);
                if (result > 0) // tambah data berhasil
                {
                    OnCreate?.Invoke(tamu); // panggil event OnCreate
                                            // reset form input, untuk persiapan input data berikutnya
                    txtKTP.Clear();
                    txtNamaTamu.Clear();
                    txtAlamat.Clear();
                    txtNo_Hp.Clear();
                    txtEmail.Focus();
                }

            }
        }
    }
}
