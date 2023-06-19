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
        public static bool ürünekle(Ürünler ü)
        {
            try
            {
                int res = DataLayer.ürünekle(ü);
                return (res > 1);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        internal static DataSet ÜrünGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.ÜrünGetir(filtre);
                return ds;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        public static bool dükkanekle(Dükkan dükkan)
        {
            try
            {
                int res = DataLayer.dükkanekle(dükkan);
                return (res > 1);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        internal static DataSet dükkanGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.dükkanGetir(filtre);
                return ds;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }


        public static bool denetmenekle(Denetmen denetmen)
        {
            try
            {
                int res = DataLayer.denetmenekle(denetmen);
                return (res > 1);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        internal static DataSet denetmengetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.denetmenGetir(filtre);
                return ds;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public static bool calisanekle(Çalışan ç)
        {
            try
            {
                int res = DataLayer.çalışanekle(ç);
                return (res > 1);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        internal static DataSet calisangetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.calısanGetir(filtre);
                return ds;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public static bool ulaşımekle(Ulaşım ula)
        {
            try
            {
                int res = DataLayer.ulaşımekle(ula);
                return (res > 1);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        internal static DataSet ulasımGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.ulaşımGetir(filtre);
                return ds;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        internal static DataSet ulaşımekle(string text)
        {
            throw new NotImplementedException();
        }

        internal static DataSet calisanekle(string text)
        {
            throw new NotImplementedException();
        }
    }
}

