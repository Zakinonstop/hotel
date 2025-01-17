using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Hotel.Model.Entry;
using Hotel.Model.Context;

namespace Hotel.Model.Repository
{
    public class UserRepository
    {
        private Context.DbContext _dbContext;  // Hanya menggunakan DbContext dari SQLite

        // Konstruktor untuk UserRepository
        public UserRepository(Context.DbContext dbContext)
        {
            _dbContext = dbContext; // Menginisialisasi DbContext yang benar
        }

        // Membaca pengguna berdasarkan email dari database
        public List<User> ReadByEmail(string email)
        {
            var users = new List<User>();

            // Menggunakan objek SQLiteCommand untuk menjalankan query terhadap SQLite database
            using (var command = new SQLiteCommand("SELECT * FROM User WHERE Email = @Email", _dbContext.Conn))
            {
                command.Parameters.AddWithValue("@Email", email);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User
                        {
                            Email = reader["Email"].ToString(),
                            Password = reader["Password"].ToString()
                        });
                    }
                }
            }

            return users;  // Mengembalikan list pengguna
        }
    }
}
