using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class RezervasyonBilgisi: BaseEntity
    {
        ProjectContext db = new ProjectContext();
        public RezervasyonBilgisi()
        {
            RezervasyonTarihi = DateTime.Now;
            // = (TatilPaketi.Fiyat + Oda.Fiyat) * Convert.ToDecimal(GunSayisi); --CALISMIYOR
        }
        public int RezervasyonID { get; set; }
        public MusteriBilgisi Musteri { get; set; }
        public int MusteriID { get; set; }
        public DateTime RezervasyonTarihi { get; set; }
        public DateTime KonaklamaBaslangic { get; set; }
        public DateTime KonaklamaBitis { get; set; }
        public int GunSayisi { get; set; }
        public TatilPaketi TatilPaketi { get; set; }
        public int TatilPaketiID { get; set; }

        public Oda Oda { get; set; }
        public int OdaID { get; set; }

        private decimal _toplamFiyat;
        public decimal ToplamFiyat
        {
            get
            {
                //database'den instance alinip, secili oda ve tatil paketlerininin fiyatininin gelebilmesi icin:
                Oda seciliOda = db.Odalar.FirstOrDefault(x => x.OdaID == OdaID);
                TatilPaketi seciliPaket = db.TatilPaketleri.FirstOrDefault(x => x.TatilPaketiID == TatilPaketiID);

                _toplamFiyat = (seciliOda.Fiyat + seciliPaket.Fiyat);// * GunSayisi;

                return _toplamFiyat;

            }

            set { _toplamFiyat = value; }
        }

    }
}
