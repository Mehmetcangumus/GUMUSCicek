using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUMUSCicek.DL
{
    public  class DataLayer
    {
        static MySqlConnection con = new MySqlConnection
       ( 
           new MySqlConnectionStringBuilder()
           {
               Server = "127.0.0.1",
               Database ="gümüş_çiçek",
               UserID = "root",
               //Password="20015221040"
              
           }.ConnectionString
       );
        public static int MusteriEkle(Musteri m)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("MusteriEkle", con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.ID);
                komut.Parameters.AddWithValue("@ad", m.Ad);
                komut.Parameters.AddWithValue("@soy", m.Soyad);
                komut.Parameters.AddWithValue("@tel", m.Telefon);
                komut.Parameters.AddWithValue("@mail", m.Mail);
                komut.Parameters.AddWithValue("@adr", m.Adres);

                int res= komut.ExecuteNonQuery();
                return res;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
            
        }

        internal static int SatışEkle(Satis satis)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("SatışEkle", con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@sid", satis.ID);
                komut.Parameters.AddWithValue("@mid", satis.Musteriid);
                komut.Parameters.AddWithValue("@cid", satis.Cicekid);
                komut.Parameters.AddWithValue("@tarih", satis.Tarih);
                komut.Parameters.AddWithValue("@fiyat", satis.Fiyat);
              

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }

        }

        internal static DataSet SatisDetay()
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand  komut = new MySqlCommand("SatisDetay", con);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                
                
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        }

        internal static int SatışGüncelle(Satis s)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("SatışGuncelle", con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@sid", s.ID);
                komut.Parameters.AddWithValue("@mid", s.Musteriid);
                komut.Parameters.AddWithValue("@cid", s.Cicekid);
                komut.Parameters.AddWithValue("@tarih", s.Tarih);
                komut.Parameters.AddWithValue("@fiyat", s.Fiyat);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        }

        internal static int ÖdemeEkle(Ödeme ödeme)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("OdemeEkle", con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@oid", ödeme.ID);
                komut.Parameters.AddWithValue("@mid", ödeme.Musteriid);              
                komut.Parameters.AddWithValue("@tarih", ödeme.Tarih);
                komut.Parameters.AddWithValue("@tutar", ödeme.Tutar);
                komut.Parameters.AddWithValue("@tur", ödeme.Tur);
                komut.Parameters.AddWithValue("@aciklama", ödeme.Aciklama);


                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }

        
    }

        internal static int ÖdemeGüncelle(Ödeme ödeme)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("OdemeGuncelle", con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@oid", ödeme.ID);
                komut.Parameters.AddWithValue("@mid", ödeme.Musteriid);
                komut.Parameters.AddWithValue("@tarih", ödeme.Tarih);
                komut.Parameters.AddWithValue("@tutar", ödeme.Tutar);
                komut.Parameters.AddWithValue("@tur", ödeme.Tur);
                komut.Parameters.AddWithValue("@aciklama", ödeme.Aciklama);


                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        }

        internal static int ÖdemeSil(string id)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("OdemeSil", con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@oid",id);


                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        }

        internal static DataSet ÖdemeDetay()
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("OdemeDetay", con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;



                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        }

        internal static int SatışSil(string id)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("SatisSil", con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);


                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        }

        internal static int MusteriSil(string id)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("MusteriSil", con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);
                

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        
    }

        internal static DataSet CicekGetir(string filtre)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))

                {
                    komut = new MySqlCommand("CicekHepsi", con);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                }
                else
                {
                    komut = new MySqlCommand("cicekBul", con);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        }

        internal static int CıcekSil(string id)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("cicekSil", con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);


                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        }

        internal static int cıcekGuncelle(Cicek c)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("cıcekGuncelle", con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", c.ID);
                komut.Parameters.AddWithValue("@ad", c.Ad);
                komut.Parameters.AddWithValue("@kategori", c.Kategori);
                komut.Parameters.AddWithValue("@fiyat", c.Fiyat);
                komut.Parameters.AddWithValue("@stok", c.Stok);
                komut.Parameters.AddWithValue("@detay", c.Detay);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        }

        internal static int CicekEkle(Cicek cicek)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("CicekEkle",con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id",cicek.ID);
                komut.Parameters.AddWithValue("@ad",cicek.Ad);
                komut.Parameters.AddWithValue("@kategori",cicek.Kategori);
                komut.Parameters.AddWithValue("@fiyat",cicek.Fiyat);
                komut.Parameters.AddWithValue("@stok",cicek.Stok);
                komut.Parameters.AddWithValue("@detay",cicek.Detay);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }

        
    }

        internal static int MusteriGüncelle(Musteri m)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("MusteriGuncelle", con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.ID);
                komut.Parameters.AddWithValue("@ad", m.Ad);
                komut.Parameters.AddWithValue("@soy", m.Soyad);
                komut.Parameters.AddWithValue("@tel", m.Telefon);
                komut.Parameters.AddWithValue("@mail", m.Mail);
                komut.Parameters.AddWithValue("@adr", m.Adres);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        }

       

        internal static DataSet MusteriGetir(string filtre)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))

                {
                    komut = new MySqlCommand("MusterilerHepsi", con);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    
                }
                else
                {
                    komut = new MySqlCommand("MusteriBul", con);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        }
    }
}
