using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinFormsApp1.DL
{
    public static class DataLayer
    {
        static MySqlConnection conn = new MySqlConnection(
        new MySqlConnectionStringBuilder()
        {
            Server = "127.0.0.1",
            Database = "flamefilmm",
            UserID = "root",
            Password = "same2834",
        }.ConnectionString
    );

        public static int filmekle(Filmler f)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("filmekle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", f.FilmID);
                komut.Parameters.AddWithValue("@ad", f.Ad);
                komut.Parameters.AddWithValue("@icerik", f.icerik);
                komut.Parameters.AddWithValue("@oyuncu", f.oyuncular);
                komut.Parameters.AddWithValue("@tur", f.tur);
                komut.Parameters.AddWithValue("@yil", f.cikisyili);
                komut.Parameters.AddWithValue("@yonet", f.yonetmen);

                int res =komut.ExecuteNonQuery();
                return res;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
;            }
         
            
        }

        internal static DataSet FilmGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("filmHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut = new MySqlCommand("filmBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre",filtre);
                }

                DataSet dataset = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataset);

                return dataset;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
                ;
            }

        }

        public static int musteriekle(Musteriler musteri)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("musteriekle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", musteri.MusteriID);
                komut.Parameters.AddWithValue("@mail", musteri.Mail);
                komut.Parameters.AddWithValue("@ad", musteri.Ad);
                komut.Parameters.AddWithValue("@soyad", musteri.Soyad);
                komut.Parameters.AddWithValue("@tel", musteri.Telefon);
                komut.Parameters.AddWithValue("@adr", musteri.Adres);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
                ;
            }

        }
        internal static DataSet musteriGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("musteriHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut = new MySqlCommand("musteriBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }

                DataSet dataset = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataset);

                return dataset;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
                ;
            }

        }
        public static int odemeekle(Odemeler ode)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("odemeEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", ode.OdemeID);
                komut.Parameters.AddWithValue("@filmid", ode.Filmid);
                komut.Parameters.AddWithValue("@mstrid", ode.Musteriid);
                komut.Parameters.AddWithValue("@tutar", ode.Tutar);
                komut.Parameters.AddWithValue("@aciklama", ode.Aciklama);
                komut.Parameters.AddWithValue("@odemetur", ode.OdemeTuru);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
                ;
            }

        }
        internal static DataSet odemeGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("odemeHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut = new MySqlCommand("odemeBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }

                DataSet dataset = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataset);

                return dataset;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
                ;
            }

        }


        public static int satisekle(Satislar satis)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("satisEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", satis.SatisID);
                komut.Parameters.AddWithValue("@filmid", satis.Filmid);
                komut.Parameters.AddWithValue("@mstrid", satis.Musteriid);
                komut.Parameters.AddWithValue("@fiyat", satis.SatisFiyat);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
                ;
            }

        }
        internal static DataSet satisGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("satisHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut = new MySqlCommand("satisBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }

                DataSet dataset = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataset);

                return dataset;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
                ;
            }

        }

    }
}
