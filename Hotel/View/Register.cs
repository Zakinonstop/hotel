using System;
using System.Windows.Forms;
using Hotel.Model.Repository;
using Hotel.Controller;
using Hotel.Model.Context;  // Pastikan DbContext yang benar di-import
using Hotel.Model.Entry;

namespace Hotel.View
{
    public partial class Register : Form
    {
        private UserController userController;

        public Register()
        {
            InitializeComponent();

            // Membuat objek DbContext dan UserRepository
            DbContext dbContext = new DbContext();  // Pastikan ini merujuk pada DbContext yang Anda buat
            var userRepository = new UserRepository(dbContext);

            // Membuat objek UserController
            userController = new UserController(userRepository);
        }

        // Method untuk memverifikasi login
        private bool VerifyLogin(string email, string password)
        {
            // Memanggil metode VerifyLogin dari UserController untuk memverifikasi kredensial
            return userController.VerifyLogin(email, password);
        }

        private void login_Click(object sender, EventArgs e)
        {
            // Mendapatkan email dan password dari inputan pengguna
            var email = txtEmail.Text;
            var password = txtPassword.Text;

            // Memverifikasi kredensial login
            if (VerifyLogin(email, password))
            {
                // Jika login berhasil, buka form utama dan sembunyikan form login
                Form main = new main();  // Pastikan form `main` sudah ada
                main.Show();
                this.Hide();
            }
            else
            {
                // Jika login gagal, tampilkan pesan kesalahan
                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
