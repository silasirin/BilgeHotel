using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class MusteriBilgisi: BaseEntity
    {
        //Burasi AppUser
        public int MusteriID { get; set; }
        public string TCKN { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }

        public List<RezervasyonBilgisi> Rezervasyonlar { get; set; }
    }
}
