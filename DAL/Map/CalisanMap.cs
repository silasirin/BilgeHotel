using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Map
{
    public class CalisanMap: EntityTypeConfiguration<Calisan>
    {
        public CalisanMap()
        {
            ToTable("dbo.Calisanlar");
            Property(x => x.CalisanID).IsRequired();
            Property(x => x.CalisanAd).HasMaxLength(40).IsRequired(); //bos gecilemez ve max 40 karakter
            Property(x => x.CalisanSoyad).HasMaxLength(25).IsRequired();
            Property(x => x.Email).HasMaxLength(50).IsRequired();
            Property(x => x.Sifre).IsRequired();
            Property(x => x.Ucret).IsOptional();
            Property(x => x.CalismaSaati).IsOptional();
            Property(x => x.Maas).IsOptional();
            Property(x => x.Vardiya).IsOptional();
        }
    }
}
