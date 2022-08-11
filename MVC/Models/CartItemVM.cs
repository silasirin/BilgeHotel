using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class CartItemVM
    {
        //CardItem'dan instance alindigi anda urun adedini otomatik 1'den baslat.
        public CartItemVM()
        {
            RezervasyonTarihi=DateTime.Now;
            OdaSayisi = 1;
            GunSayisi = KonaklamaBitis.Day-KonaklamaBaslangic.Day;
        }

        //bir alisveris sepetinin ....si olur
        public int OdaID { get; set; }
        public string OdaTuru { get; set; }
        public int OdaSayisi { get; set; }
        public decimal? OdaTuruFiyati { get; set; }
        public int TatilPaketID { get; set; }
        public string TatilPaketi { get; set; }
        public decimal? TatilPaketiFiyati { get; set; }
        public DateTime KonaklamaBaslangic { get; set; }
        public DateTime KonaklamaBitis { get; set; }
        public DateTime RezervasyonTarihi { get; set; }
        public int GunSayisi { get; set; }
        public decimal? Fiyat { get; set; } //veritabanindan gelen fiyat bos gecilebilir oldugundan dolayi buradaki fiyat ve toplamFiyat alanlarini da bos gecilebilir olmali.

        //toplam fiyat kendi adet ve fiyat bilgileriyle calisacaktir. Dısaridan bir ayarlamaya yapilmayacak. Readonly olacak. Bu nedenle set'i siliyoruz.
        public decimal? ToplamFiyat
        {
            get
            {
                //Rezervasyon Tarihi Konaklamadan bir aydan once yapildiysa ve Her Sey Dahil Paket secildiyse:
                if (KonaklamaBaslangic.Day-30 > RezervasyonTarihi.Day && KonaklamaBaslangic.Day - 90 < RezervasyonTarihi.Day && TatilPaketi=="Her Şey Dahil")
                {
                    return (OdaTuruFiyati + TatilPaketiFiyati)*GunSayisi*0.84m;
                }

                //Rezervasyon Tarihi Konaklamadan bir aydan once yapildiysa ve Ultra Her Sey Dahil Paket secildiyse:
                else if (KonaklamaBaslangic.Day - 30 > RezervasyonTarihi.Day  && KonaklamaBaslangic.Day - 90 < RezervasyonTarihi.Day && TatilPaketi == "Ultra Her Şey Dahil")
                {
                    return (OdaTuruFiyati + TatilPaketiFiyati) * GunSayisi * 0.82m;
                }

                //Rezervasyon Tarihi Konaklamadan uc aydan once yapildiysa:
                else if (KonaklamaBaslangic.Day - 90 > RezervasyonTarihi.Day)
                {
                    return (OdaTuruFiyati + TatilPaketiFiyati) * GunSayisi * 0.77m;
                }

                else
                {
                    return (OdaTuruFiyati + TatilPaketiFiyati)*GunSayisi;
                }
            }
        }
    }
}