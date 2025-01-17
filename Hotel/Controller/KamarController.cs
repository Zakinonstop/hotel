using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.Model.Context;
using Hotel.Model.Entry;
using Hotel.Model.Repository;

namespace Hotel.Controller
{
    public class KamarController
    {
        private KamarRepository _repository;

        public KamarController()
        {
            _repository = new KamarRepository(new DbContext());
        }

        public List<KamarEntity> ReadAll()
        {
            List<KamarEntity> list = new List<KamarEntity>();

            using (DbContext context = new DbContext())
            {
                _repository = new KamarRepository(context);
                list = _repository.ReadAll();
            }

            return list;
        }

        public List<KamarEntity> ReadByType(string type)
        {
            List<KamarEntity> list = new List<KamarEntity>();

            using (DbContext context = new DbContext())
            {
                _repository = new KamarRepository(context);

                list = _repository.ReadAll().Where(k => k.Type.ToLower().Contains(type)).ToList();
            }

            return list;
        }

        public int Create(KamarEntity kamar, string Type, string Status)
        {
            int result = 0;

            // Validasi No kamar
            if (string.IsNullOrEmpty(kamar.No_Kamar))
            {
                MessageBox.Show("No Kamar Harus Diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // Validasi Harga
            if (string.IsNullOrEmpty(kamar.Harga))
            {
                MessageBox.Show("Harga Harus Diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // Validasi Type (comboBox)
            if (string.IsNullOrEmpty(Type))
            {
                MessageBox.Show("Tipe Kamar Harus Diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            kamar.Type = Type;

            // Validasi Status (comboBox)
            if (string.IsNullOrEmpty(Status))
            {
                MessageBox.Show("Status Kamar Harus Diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            kamar.Status = Status;

            // Operasi penyimpanan ke database
            try
            {
                using (DbContext context = new DbContext())
                {
                    _repository = new KamarRepository(context);
                    result = _repository.Create(kamar);
                }

                if (result > 0)
                {
                    MessageBox.Show("Data kamar berhasil ditambahkan !!!", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data kamar gagal ditambahkan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        public int Update(KamarEntity kamar)
        {
            int result = 0;

            // Validasi No kamar
            if (string.IsNullOrEmpty(kamar.No_Kamar))
            {
                MessageBox.Show("No Kamar Harus Diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // Validasi Harga
            if (string.IsNullOrEmpty(kamar.Harga))
            {
                MessageBox.Show("Harga Harus Diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // Validasi Type (comboBox)
            if (string.IsNullOrEmpty(kamar.Type))
            {
                MessageBox.Show("Tipe Harus Diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // Validasi Status (comboBox)
            if (string.IsNullOrEmpty(kamar.Status))
            {
                MessageBox.Show("Status Kamar Harus Diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new KamarRepository(context);
                result = _repository.Update(kamar);
            }

            if (result > 0)
            {
                MessageBox.Show("Data kamar berhasil diUpdate !!!", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data kamar gagal diUpdate !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public int Delete(KamarEntity kamar)
        {
            int result = 0;

            if (kamar == null)
            {
                MessageBox.Show("Kamar Tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new KamarRepository(context);
                result = _repository.Delete(kamar); // Panggil method Delete pada repository untuk menghapus data kamar
            }

            if (result > 0)
            {
                MessageBox.Show("Kamar berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Gagal menghapus kamar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public int GetJumlahkamarTersedia()
        {
            return _repository.getkamarTersedia();
        }

        public int GetJumlahKamarTerpakai()
        {
            return _repository.getKamarTerpakai();
        }
    }
}
