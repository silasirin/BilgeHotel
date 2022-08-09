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
            OdaSayisi = 1;
            GunSayisi = TatilBitis.Day-TatilBaslangic.Day;
        }

        //bir alisveris sepetinin ....si olur
        public int OdaID { get; set; }
        public string OdaTuru { get; set; }
        public int OdaSayisi { get; set; }
        public decimal? OdaTuruFiyati { get; set; }
        public int TatilPaketID { get; set; }
        public string TatilPaketi { get; set; }
        public decimal? TatilPaketiFiyati { get; set; }
        public DateTime TatilBaslangic { get; set; }
        public DateTime TatilBitis { get; set; }
        public int GunSayisi { get; set; }
        public decimal? Fiyat { get; set; } //veritabanindan gelen fiyat bos gecilebilir oldugundan dolayi buradaki fiyat ve toplamFiyat alanlarini da bos gecilebilir olmali.

        //toplam fiyat kendi adet ve fiyat bilgileriyle calisacaktir. Dısaridan bir ayarlamaya yapilmayacak. Readonly olacak. Bu nedenle set'i siliyoruz.
        public decimal? ToplamFiyat
        {
            get
            {
                return GunSayisi*(OdaTuruFiyati+TatilPaketiFiyati);
            }
        }
    }
}