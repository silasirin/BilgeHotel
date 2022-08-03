using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Map
{
    public class MusteriMap : EntityTypeConfiguration<MusteriBilgisi>
    {
        public MusteriMap()
        {
            ToTable("dbo.Musteriler");
            HasKey(x => x.MusteriID);
            Property(x => x.MusteriID).IsRequired();
            Property(x => x.TCKN).HasMaxLength(11).IsRequired(); 
            Property(x => x.Ad).HasMaxLength(25).IsRequired();
            Property(x => x.Soyad).HasMaxLength(25).IsRequired();
            Property(x => x.Email).HasMaxLength(50).IsRequired();
            Property(x => x.Sifre).IsRequired();
            Property(x => x.TelNo).HasMaxLength(20).IsRequired();
        }
    }
}
