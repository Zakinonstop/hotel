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

    public class TamuController
    {
        private TamuRepository _repository;

        public List<Tamu> ReadByNamaTamu(string nama)
        {
            List<Tamu> list = new List<Tamu>();

            using (DbContext context = new DbContext()) 
            {
                _repository = new TamuRepository(context);
                list = _repository.ReadByNamaTamu(nama);

            }

            return list;
        }

        public List<Tamu> ReadAll()
        {
            List<Tamu> list = new List<Tamu>();

            using (DbContext context = new DbContext())
            {
                _repository = new TamuRepository(context);
                list = _repository.ReadAll();
            }

            return list;
        }

        public int Create(Tamu tamu)
        {
            int result = 0;

            //validasi nama tamu
           if (tamu.KTP.Length != 15)
            {
                MessageBox.Show("KTP harus terdiri dari 15 digit", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

           if (string.IsNullOrEmpty(tamu.Nama))
            {
                MessageBox.Show("Nama harus terdiri dari 15 digit", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

           if (string.IsNullOrEmpty(tamu.Alamat))
            {
                MessageBox.Show("Alamat harus terdiri dari 15 digit", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

           using (DbContext context = new DbContext())
            {
                _repository = new TamuRepository(context);
                result = _repository.Create(tamu);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Tamu Berhasil DiSimpan !!!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            else
            {
                MessageBox.Show("Data tamu gagal disimpan !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

        }

    }
}
