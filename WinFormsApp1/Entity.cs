using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
   public class Ürünler
    {

        public Guid UrunKodu { get; set; }
        public string Adi { get; set; }
        public string DüğmeSayisi { get; set; }
        public string stok { get; set; }
        public string YapildiğiYer { get; set; }

    }
    public class Dükkan
    {
        public Guid Müdür { get; set; }
        public string PaketAdi { get; set; }
        public string Adres { get; set; }
        public string İşçiSayisi { get; set; }
        public string TelefonNumarasi { get; set; }

    }
    public class Denetmen
    {
        public Guid Pozisyon { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Maaş { get; set; }
        public string İşeGirişTarihi { get; set; }


    }
    public class Çalışan
    {
        public Guid Pozisyon { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCNumarası { get; set; }
        public string Yaş { get; set; }
        public string Maaş { get; set; }
        public string TelefonNo { get; set; }
        public string VardiyalıMı { get; set; }

    }
    public class Ulaşım
    {
        public string UlaşımTürü { get; set; }
        public string KalkışŞehri { get; set; }
        public string Şoföradı { get; set; }
        public string VarışŞehri { get; set; }
        public Guid Araçnumarası { get; set; }

    }
}
