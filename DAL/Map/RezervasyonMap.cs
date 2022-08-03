using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Map
{
    public class RezervasyonMap : EntityTypeConfiguration<RezervasyonBilgisi>
    {
        public RezervasyonMap()
        {
            ToTable("dbo.RezervasyonBilgileri");
            HasKey(x => x.RezervasyonID);
            Property(x => x.RezervasyonID).IsRequired();
            Property(x => x.KonaklamaBaslangic).IsRequired();
            Property(x => x.KonaklamaBitis).IsRequired();
            Property(x => x.TatilPaketiID).IsRequired();
            Property(x => x.OdaID).IsRequired();
        }
    }
}
