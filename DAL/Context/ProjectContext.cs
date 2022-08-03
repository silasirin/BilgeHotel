using DAL.Entity;
using DAL.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class ProjectContext: DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "server=localhost\\SQLEXPRESS;database=BilgeHotelDB;Trusted_Connection=true";
        }
        public DbSet<Calisan> Calisanlar { get; set; }
        public DbSet<MusteriBilgisi> MusteriBilgileri { get; set; }
        public DbSet<Oda> Odalar { get; set; }
        public DbSet<RezervasyonBilgisi> RezervasyonBilgileri { get; set; }
        public DbSet<TatilPaketi> TatilPaketleri { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CalisanMap());//class'taki constructor'in calismasi icin new yazarak instance alinir.
            modelBuilder.Configurations.Add(new MusteriMap());
            modelBuilder.Configurations.Add(new OdaMap());
            modelBuilder.Configurations.Add(new RezervasyonMap());
            modelBuilder.Configurations.Add(new TatilPaketiMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
