using DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Oda: BaseEntity
    {
        public int OdaID { get; set; }
        public string OdaTuru { get; set; }
        public OdaDurumu OdaDurumu { get; set; }
        public int OdaSayisi { get; set; }
        public decimal Fiyat { get; set; }
        public List<RezervasyonBilgisi> RezervasyonBilgileri { get; set; }
    }
}
