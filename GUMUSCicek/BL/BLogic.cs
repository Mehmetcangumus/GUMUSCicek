using GUMUSCicek.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUMUSCicek.BL
{
     public static class BLogic
    {
        public static bool MusteriEkle(Musteri m)
        {
            try
            {
                int res = DataLayer.MusteriEkle(m);

                return (res > 0);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
        }

        internal static DataSet MusteriGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.MusteriGetir(filtre);
                return ds;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return null;
            }
        }

        

        internal static bool MusteriGüncelle(Musteri m)
        {
            try
            {
                int res = DataLayer.MusteriGüncelle(m);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool SatışEkle(Satis satis)
        {
            try
            {
                int res = DataLayer.SatışEkle(satis);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool MusteriSil(string id)
        {
            try
            {
                int res = DataLayer.MusteriSil(id);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
        }

        internal static DataSet SatisDetay()
        {
            try
            {
                DataSet ds = DataLayer.SatisDetay();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return null;
            }
        }

        internal static bool CicekEkle(Cicek cicek)
        {
            try
            {
                int res = DataLayer.CicekEkle(cicek);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool SatışGüncelle(Satis satis)
        {
            try
            {
                int res = DataLayer.SatışGüncelle(satis);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
        }

        internal static DataSet CicekGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.CicekGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return null;
            }
        }

        internal static bool SatışSil(string id)
        {
            try
            {
                int res = DataLayer.SatışSil(id);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool cıcekGuncelle(Cicek c)
        {
            try
            {
                int res = DataLayer.cıcekGuncelle(c);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool ÖdemeEkle(Ödeme ödeme)
        {
            try
            {
                int res = DataLayer.ÖdemeEkle(ödeme);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
        }

        internal static DataSet ÖdemeDetay()
        {
            try
            {
                DataSet ds = DataLayer.ÖdemeDetay();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return null;
            }
        }

        internal static bool CıcekSil(string id)
        {
            try
            {
                int res = DataLayer.CıcekSil(id);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool ÖdemeGüncelle(Ödeme ödeme)
        {
            try
            {
                int res = DataLayer.ÖdemeGüncelle(ödeme);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool ÖdemeSil(string id)
        {
            try
            {
                int res = DataLayer.ÖdemeSil(id);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
        }
    }
}
