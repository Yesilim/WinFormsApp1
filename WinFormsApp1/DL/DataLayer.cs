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
            Database = "tekstil",
            UserID = "root",
            Password = "adanakebab2002",
        }.ConnectionString
    );

        public static int ürünekle(Ürünler ü)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("sq_urunekle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@adi", ü.Adi);
                komut.Parameters.AddWithValue("@UrunKodu", ü.UrunKodu);
                komut.Parameters.AddWithValue("@DugmeSayisi", ü.DüğmeSayisi);
                komut.Parameters.AddWithValue("@stok", ü.stok);
                komut.Parameters.AddWithValue("@YapildigiYer", ü.YapildiğiYer);

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

        internal static DataSet ÜrünGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("sq_UrunlerHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut = new MySqlCommand("sq_UrunlerBul", conn);
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

        public static int dükkanekle(Dükkan dükkan)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("sp_dukkanekle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Müdür", dükkan.Müdür);
                komut.Parameters.AddWithValue("@PaketAdi", dükkan.PaketAdi);
                komut.Parameters.AddWithValue("@Adres", dükkan.Adres);
                komut.Parameters.AddWithValue("@İşçiSayisi", dükkan.İşçiSayisi);
                komut.Parameters.AddWithValue("@TelefonNumarasi", dükkan.TelefonNumarasi);

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
        internal static DataSet dükkanGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("sq_DukkanHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut = new MySqlCommand("sq_DukkanBul", conn);
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
        public static int denetmenekle(Denetmen denetmen)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("sq_denetmenekle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Pozisyon", denetmen.Pozisyon);
                komut.Parameters.AddWithValue("@Ad", denetmen.Ad);
                komut.Parameters.AddWithValue("@Soyad", denetmen.Soyad);
                komut.Parameters.AddWithValue("@Maaş", denetmen.Maaş);
                komut.Parameters.AddWithValue("@İşeGirişTarihi", denetmen.İşeGirişTarihi);

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
        internal static DataSet denetmenGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("sq_DenetmenHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut = new MySqlCommand("sq_DenetmenBul", conn);
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

        public static int ulaşımekle(Ulaşım ulaşım)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("sq_ulaşımekle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@UlaşımTürü", ulaşım.UlaşımTürü);
                komut.Parameters.AddWithValue("@KalkışŞehri", ulaşım.KalkışŞehri);
                komut.Parameters.AddWithValue("@Şoföradı", ulaşım.Şoföradı);
                komut.Parameters.AddWithValue("@VarışŞehri", ulaşım.VarışŞehri);
                komut.Parameters.AddWithValue("@Araçnumarası", ulaşım.Araçnumarası);

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
        internal static DataSet ulaşımGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("sq_ulaşımHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut = new MySqlCommand("sq_ulaşımBul", conn);
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

        public static int çalışanekle(Çalışan çalışan)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("sq_calisanekle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Pozisyon", çalışan.Pozisyon);
                komut.Parameters.AddWithValue("@Ad", çalışan.Ad);
                komut.Parameters.AddWithValue("@Soyad", çalışan.Soyad);
                komut.Parameters.AddWithValue("@TCNumarası", çalışan.TCNumarası);
                komut.Parameters.AddWithValue("@Yaş", çalışan.Yaş);
                komut.Parameters.AddWithValue("@Maaş", çalışan.Maaş);
                komut.Parameters.AddWithValue("@TelefonNo", çalışan.TelefonNo);
                komut.Parameters.AddWithValue("@VardiyalıMı", çalışan.VardiyalıMı);

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
        internal static DataSet calısanGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("sq_calisanHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut = new MySqlCommand("sq_calisanBul", conn);
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
