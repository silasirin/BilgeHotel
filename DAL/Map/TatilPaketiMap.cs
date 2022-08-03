using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Map
{
    public class TatilPaketiMap: EntityTypeConfiguration<TatilPaketi>
    {
        public TatilPaketiMap()
        {
            ToTable("dbo.TatilPaketleri");
            Property(x=>x.TatilPaketiID).IsRequired();
            Property(x=>x.Fiyat).IsRequired();
        }
    }
}
