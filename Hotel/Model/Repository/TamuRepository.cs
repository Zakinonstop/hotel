using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Model.Entry;
using Hotel.Model.Context;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Hotel.Model.Repository
{
    public class TamuRepository
    {
        private SQLiteConnection _conn;

        public TamuRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Tamu tamu)
        {
            int result = 0;

            //deklaras perintah SQL
            string sql = @"INSERT INTO Tamu (Nama, KTP, Alamat, No_Hp, Email, Id) 
                        VALUES 
                        (@Nama, @KTP, @Alamat, @No_Hp, @Id)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                //tambahkan parameter
                cmd.Parameters.AddWithValue("@Nama", tamu.Nama);
                cmd.Parameters.AddWithValue("@KTP", tamu.KTP);
                cmd.Parameters.AddWithValue("@Alamat", tamu.Alamat);
                cmd.Parameters.AddWithValue("@No_Hp", tamu.No_Hp);
                cmd.Parameters.AddWithValue("@Email", tamu.Email);
                cmd.Parameters.AddWithValue("@Id", tamu.Id);

                try
                {
                    //jalankan perintah INSERT dan tampung
                    result = cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create eror: {0}", ex.Message);
                }
            }

            return result;
        }

        public List<Tamu> ReadAll()
        {
            List<Tamu> list = new List<Tamu>();
            string sql = @"SELECT Nama, KTP, Alamat, No_Hp, Email
                        FROM Tamu ORDER BY Nama";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Tamu tamu = new Tamu
                            {
                                Nama = dtr["Nama"].ToString(),
                                KTP = dtr["KTP"].ToString(),
                                Alamat = dtr["Alamat"].ToString(),
                                No_Hp = dtr["No_Hp"].ToString(),
                                Email = dtr["Email"].ToString()
                            };
                            list.Add(tamu);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll erorr : {0}", ex.Message);
            }
            return list;
        }

        public List<Tamu> ReadByNamaTamu(string nama)
        {
            List<Tamu> list = new List<Tamu>();

            string sql = @"SELECT Nama, KTP, Alamat, No_Hp, Email
                            FROM Tamu WHERE Nama LIKE @Nama ORDER BY Nama";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@Nama", $"%{nama}%");

                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Tamu tamu = new Tamu
                            {
                                Nama = dtr["Nama"].ToString(),
                                KTP = dtr["KTP"].ToString(),
                                Alamat = dtr["Alamat"].ToString(),
                                No_Hp = dtr["No_Hp"].ToString(),
                                Email = dtr["Email"].ToString(),
                            };
                            list.Add(tamu);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNamaTamu erorr: {0}", ex.Message);
            }

            return list;
        }
        
        
    }
}
