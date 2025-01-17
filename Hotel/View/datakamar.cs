using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.Controller;
using Hotel.Model.Entry;
using Hotel.View;

namespace Hotel.View
{
    public partial class datakamar : Form
    {
        private List<KamarEntity> listOfKamar = new List<KamarEntity>();
        private KamarController controller;

        public datakamar()
        {
            InitializeComponent();
            controller = new KamarController();
            InisialisasiListView();
            Loadkamar();
        }

        private void datakamar_Load(object sender, EventArgs e)
        {
            // Logic ketika form pertama kali dimuat
        }

        public void InisialisasiListView()
        {
            lvlKamar.View = System.Windows.Forms.View.Details;
            lvlKamar.FullRowSelect = true;
            lvlKamar.GridLines = true;

            lvlKamar.Columns.Add("No.", 50, HorizontalAlignment.Center);
            lvlKamar.Columns.Add("Type", 120, HorizontalAlignment.Center);
            lvlKamar.Columns.Add("No Kamar", 150, HorizontalAlignment.Center);
            lvlKamar.Columns.Add("Status", 120, HorizontalAlignment.Center);
            lvlKamar.Columns.Add("Harga", 200, HorizontalAlignment.Center);
        }

        public void Loadkamar()
        {
            // Kosongkan ListView terlebih dahulu
            lvlKamar.Items.Clear();

            // Panggil metode ReadAll dan tampung datanya ke dalam koleksi
            listOfKamar = controller.ReadAll();

            // Ekstrak objek kamar dari koleksi dan tampilkan di ListView
            foreach (var kamar in listOfKamar)
            {
                var noUrut = lvlKamar.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(kamar.Type);
                item.SubItems.Add(kamar.No_Kamar);
                item.SubItems.Add(kamar.Status);
                item.SubItems.Add(kamar.Harga);

                // Jika kamar statusnya "Terpakai", beri warna latar belakang berbeda
                if (kamar.Status == "Terpakai")
                {
                    item.BackColor = Color.AliceBlue;
                }

                // Tampilkan data kamar ke ListView
                lvlKamar.Items.Add(item);
            }
        }

        private void LoadDataKamarByStatus()
        {
            lvlKamar.Items.Clear();

            // Ambil input pencarian dan ubah menjadi lowercase untuk menghindari case-sensitivity
            string searchText = txtDataKamar.Text.ToLower();

            // Panggil metode ReadByType dan sesuaikan agar tidak case-sensitive
            listOfKamar = controller.ReadByType(searchText);

            if (listOfKamar.Count == 0)
            {
                MessageBox.Show("Kamar tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Loadkamar();
                txtDataKamar.Text = "";
                return;
            }

            foreach (var kamar in listOfKamar)
            {
                var noUrut = lvlKamar.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(kamar.Type);
                item.SubItems.Add(kamar.No_Kamar);
                item.SubItems.Add(kamar.Status);
                item.SubItems.Add(kamar.Harga);

                if (kamar.Status == "Terpakai")
                {
                    item.BackColor = Color.AliceBlue;
                }

                lvlKamar.Items.Add(item);
            }
        }


        private void OnCreateEventHandler(KamarEntity kamar)
        {
            listOfKamar.Add(kamar);
            int noUrut = lvlKamar.Items.Count + 1;

            // Tampilkan data kamar yang baru ke ListView
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(kamar.Type);
            item.SubItems.Add(kamar.No_Kamar);
            item.SubItems.Add(kamar.Status);
            item.SubItems.Add(kamar.Harga);

            // Membuat warna subitem pada kolom status
            if (kamar.Status == "Terpakai")
            {
                item.BackColor = Color.AliceBlue;
            }

            // Tambahkan item kamar baru ke ListView
            lvlKamar.Items.Add(item);
        }

        private void OnUpdateEventHandler(KamarEntity kamar)
        {
            // Ambil index data kamar yang akan diupdate
            int index = lvlKamar.SelectedIndices[0];

            // Update data di listOfKamar
            listOfKamar[index] = kamar;

            // Update informasi kamar di ListView
            ListViewItem itemRow = lvlKamar.Items[index];
            itemRow.SubItems[1].Text = kamar.Type;
            itemRow.SubItems[2].Text = kamar.No_Kamar;
            itemRow.SubItems[3].Text = kamar.Status;
            itemRow.SubItems[4].Text = kamar.Harga;
        }

        private void btnTamabahkamar_Click(object sender, EventArgs e)
        {
            FrmDatakamar frmDatakamar = new FrmDatakamar();
            frmDatakamar.OnCreate += OnCreateEventHandler;
            frmDatakamar.ShowDialog();
        }

        private void btnCariKamar_Click(object sender, EventArgs e)
        {
            LoadDataKamarByStatus();
        }

        private void btnEditKamar_Click(object sender, EventArgs e)
        {
            if (lvlKamar.SelectedItems.Count > 0)
            {
                // Ambil objek kamar yang mau diedit dari selection
                KamarEntity kamar = listOfKamar[lvlKamar.SelectedIndices[0]];

                // Buat objek form entry data kamar
                FrmDatakamar frmDatakamar = new FrmDatakamar("Edit Data Kamar", kamar, controller);

                // Mendaftarkan method event handler
                frmDatakamar.OnUpdate += OnUpdateEventHandler;

                // Tampilkan form entry kamar
                frmDatakamar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data kamar belum dipilih", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnChekin_Click(object sender, EventArgs e)
        {
            if (lvlKamar.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data kamar ingin dihapus?", "Konfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // Ambil objek kamar yang akan dihapus
                    KamarEntity kamar = listOfKamar[lvlKamar.SelectedIndices[0]];

                    // Panggil operasi CRUD untuk menghapus
                    var result = controller.Delete(kamar);

                    if (result > 0)
                    {
                        Loadkamar();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data kamar", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Data kamar belum dipilih", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
