using DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{ 
    public class Calisan: BaseEntity
    {
        public int CalisanID { get; set; }
        public string CalisanAd { get; set; }
        public string CalisanSoyad { get; set; }
        public string Gorev { get; set; }
        public GorevTuru GorevTuru { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }

        private decimal? _maas;
        public decimal? Maas {get
            {
                if (Gorev.Contains("Yönetici") || Gorev.Contains("Şef"))
                {
                    _maas = Ucret;
                }
                else
                {
                    _maas = Ucret * CalismaSaati;
                }
                return _maas;
            }

            set { _maas = value; }
        }        
        public int? CalismaSaati { get; set; }
        public decimal? Ucret { get; set; }
        public Vardiya? Vardiya { get; set; }
    }
}
