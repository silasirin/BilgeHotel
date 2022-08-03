using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Map
{
    public class OdaMap : EntityTypeConfiguration<Oda>
    {
        public OdaMap()
        {
            ToTable("dbo.Odalar");
            Property(x => x.OdaID).IsRequired();
            Property(x => x.Fiyat).IsRequired();
            Property(x => x.OdaDurumu).IsRequired();
        }
    }
}
