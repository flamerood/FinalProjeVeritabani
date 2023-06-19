using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1;
using WinFormsApp1.DL;

namespace WinFormsApp1.BL
{
    public static class BLogic
    {
        public static bool filmekle(Filmler f)
        {
            try
            {
                int res = DataLayer.filmekle(f);
                return (res > 1);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        internal static DataSet FilmGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.FilmGetir(filtre);
                return ds;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        public static bool musteriekle(Musteriler musteri)
        {
            try
            {
                int res = DataLayer.musteriekle(musteri);
                return (res > 1);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        internal static DataSet musteriGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.musteriGetir(filtre);
                return ds;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }


        public static bool odemeekle(Odemeler ode)
        {
            try
            {
                int res = DataLayer.odemeekle(ode);
                return (res > 1);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        internal static DataSet odemeGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.odemeGetir(filtre);
                return ds;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public static bool satisekle(Satislar satis)
        {
            try
            {
                int res = DataLayer.satisekle(satis);
                return (res > 1);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        internal static DataSet satisGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.satisGetir(filtre);
                return ds;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }


        internal static DataSet satisekle(string text)
        {
            throw new NotImplementedException();
        }
    }
}

