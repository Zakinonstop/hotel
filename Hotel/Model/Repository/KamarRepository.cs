using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Model.Entry;
using Hotel.Model.Context;
using System.Data.SQLite;
using System.Linq.Expressions;

namespace Hotel.Model.Repository
{
    public class KamarRepository
    {
        private SQLiteConnection _conn;

        public KamarRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public List<KamarEntity> ReadAll()
        {
            List<KamarEntity> list = new List<KamarEntity>();

            try
            {
                string sql = @"SELECT Id, Type, No_Kamar, Status, Harga FROM Kamar ORDER BY Type;";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            KamarEntity kamar = new KamarEntity();
                            kamar.Id = Convert.ToInt32(dtr["Id"]);
                            kamar.Type = dtr["Type"].ToString();
                            kamar.No_Kamar = dtr["No_Kamar"].ToString();
                            kamar.Status = dtr["Status"].ToString();
                            kamar.Harga = dtr["Harga"].ToString();

                            list.Add(kamar);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll erorr: {0}", ex.Message);
            }

            return list;
        }

        public int getkamarTersedia()
        {
            int result = 0;

            string sql = "SELECT COUNT (*) FROM Kamar";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                }
                
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.Print("eror Jumlah Buku : {0}", ex.Message);
            }

            return result;
        }

        public int getKamarTerpakai()
        {
            int result = 0;

            string sql = "SELECT COUNT (*) FROM Kamar where Kamar.Status = 'Terpakai'";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("eror Jumlah Buku : {0}", ex.Message);
            }

            return result;
        }

        public List<KamarEntity> ReadByType(string type)
        {
            List<KamarEntity> list = new List<KamarEntity> ();

            try
            {
                string sql = @"select Id, Type, No_Kamar, Status, Harga
                                from Kamar
                                where Type like @Type
                                order by Id";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@Type", string.Format("%{0}%", type));

                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while(dtr.Read())
                        {
                            KamarEntity kamar = new KamarEntity();
                            //kamar.Id = Convert.ToInt32(dtr["Id"]);
                            kamar.Type = dtr["Type"].ToString();
                            kamar.No_Kamar = dtr["No_Kamar"].ToString();
                            kamar.Status = dtr["Status"].ToString();
                            kamar.Harga = dtr["Harga"].ToString();

                            list.Add(kamar);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadBytype Eror: {0}", ex.Message);
            }
            return list;
        }



        public int Create(KamarEntity kamar)
        {
            int result = 0;

            string sql = @"INSERT INTO Kamar (Type, No_Kamar, Status, Harga)
                            VALUES (@Type, @No_Kamar, @Status, @Harga)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Type", kamar.Type);
                cmd.Parameters.AddWithValue("@No_Kamar", kamar.No_Kamar);
                cmd.Parameters.AddWithValue("@Status", kamar.Status);
                cmd.Parameters.AddWithValue("@Harga", kamar.Harga);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create erorr : {0}", ex.Message);
                }
            }

            return result;
                           
        }

        public int Update(KamarEntity kamar)
        {
            int result = 0;

            string sql = @"UPDATE Kamar 
                           SET Type = @Type, No_Kamar = @No_Kamar, Status = @Status, Harga = @Harga
                            WHERE Id = @Id";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Type", kamar.Type);
                cmd.Parameters.AddWithValue("@No_Kamar", kamar.No_Kamar);
                cmd.Parameters.AddWithValue("@Status", kamar.Status);
                cmd.Parameters.AddWithValue("@Harga", kamar.Harga);
                cmd.Parameters.AddWithValue("@Id", kamar.Id);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update erorr : {0}", ex.Message);
                }
            }

            return result;

        }

        public int Delete(KamarEntity kamar)
        {
            int result = 0;

            string sql = @"delete from Kamar
                            where Id = @Id";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Id", kamar.Id);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete erorr : {0}", ex.Message);
                }
            }

            return result;

        }

        public void UpdateKamarStatus(int Id, string Status)
        {

            string sql = @"UPDATE Kamar 
                            SET Status = @Status
                            WHERE Id = @Id";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@Id", Id);

                try
                {
                   cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("UpdateKamarStatus erorr : {0}", ex.Message);
                }
            }

            

        }
    }
}
