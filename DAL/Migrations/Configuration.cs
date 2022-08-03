namespace DAL.Migrations
{
    using DAL.Entity;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Context.ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DAL.Context.ProjectContext context)
        {
            //Calisan Ekleme
            List<Calisan> calisanlar = new List<Calisan>()
            {
                new Calisan{CalisanID=1,CalisanAd="Selahattin",CalisanSoyad="Alkomut",Email="satis.yonetim@bilgehotel.com",Sifre="12345",Gorev="Satış Yöneticisi",Ucret=27000,GorevTuru=Enums.GorevTuru.Yonetim},
                new Calisan{CalisanID=2,CalisanAd="Levent",CalisanSoyad="SişarpSoy",Email="ik.yonetim@bilgehotel.com",Sifre="12345",Gorev="IK Yöneticisi",Ucret=27000,GorevTuru=Enums.GorevTuru.Yonetim},
                new Calisan{CalisanID=3,CalisanAd="Gülay",CalisanSoyad="Aydınlık",Email="info@bilgehotel.com",Sifre="12345",Gorev="Resepsiyon Görevlisi",CalismaSaati=9,Ucret=150,GorevTuru=Enums.GorevTuru.Calisan},
                new Calisan{CalisanID=4,CalisanAd="Selahattin",CalisanSoyad="Karadibag",Email="bilisim@bilgehotel.com",Sifre="12345",Gorev="IT Sorumlusu",CalismaSaati=9,Ucret=150,GorevTuru=Enums.GorevTuru.Calisan }

            };
            
            if (!context.Calisanlar.Any()) //herhangi bir calisan yoksa
            {
                foreach (var calisan in calisanlar)
                {
                    context.Calisanlar.Add(calisan);
                    context.SaveChanges();
                }
            }

            //Musteri Bilgisi Ekleme
            List<MusteriBilgisi> musteriler = new List<MusteriBilgisi>()
            {

                new MusteriBilgisi{MusteriID=1,TCKN="24583790359",Ad="Ali",Soyad="Atasever",TelNo="05365968545",Email="aliatasever@gmail.com",Sifre="123456"},
                new MusteriBilgisi{MusteriID=1,TCKN="59687428069",Ad="Sevda",Soyad="Kalkan",TelNo="05365968545",Email="skalkan@gmail.com",Sifre="12345678"},
                new MusteriBilgisi{MusteriID=1,TCKN="47100596589",Ad="Hayri",Soyad="Balcı",TelNo="05365968545",Email="hayribalsever55@gmail.com",Sifre="1234567"}

            };

            if (!context.MusteriBilgileri.Any())
            {
                foreach (var musteri in musteriler)
                {
                    context.MusteriBilgileri.Add(musteri);
                    context.SaveChanges();
                }
            }

            //Oda Bilgisi Ekleme
            List<Oda> odalar = new List<Oda>()
            {
                new Oda { OdaID = 1, OdaTuru = "Bir Kişilik", OdaDurumu = Enums.OdaDurumu.Musait,OdaSayisi=20, Fiyat=300 },
                new Oda { OdaID = 2, OdaTuru = "İki Kişilik", OdaDurumu = Enums.OdaDurumu.Musait,OdaSayisi=30, Fiyat=450 },
                new Oda { OdaID = 3, OdaTuru = "Üç Kişilik", OdaDurumu = Enums.OdaDurumu.Musait,OdaSayisi=20, Fiyat=600 },
                new Oda { OdaID = 4, OdaTuru = "Dört Kişilik", OdaDurumu = Enums.OdaDurumu.Musait,OdaSayisi=6, Fiyat=800 },
                new Oda { OdaID = 5, OdaTuru = "Kral Dairesi", OdaDurumu = Enums.OdaDurumu.Musait,OdaSayisi=1, Fiyat=1000 },

            };

            if (!context.Odalar.Any())
            {
                foreach (var oda in odalar)
                {
                    context.Odalar.Add(oda);
                    context.SaveChanges();
                }
            }

            //Tatil Paketi Ekleme
            List<TatilPaketi> tatilPaketleri = new List<TatilPaketi>()
            {
                new TatilPaketi { TatilPaketiID = 1, TatilTipi = "Her Şey Dahil", Fiyat=300 },
                new TatilPaketi { TatilPaketiID = 2, TatilTipi = "Ultra Her Şey Dahil", Fiyat=400 }

            };

            if (!context.TatilPaketleri.Any())
            {
                foreach (var tatilPaketi in tatilPaketleri)
                {
                    context.TatilPaketleri.Add(tatilPaketi);
                    context.SaveChanges();
                }
            }

            //Rezervasyon Bilgileri Ekleme
            DateTime tarih1 = new DateTime(2022, 07, 15);
            DateTime tarih2 = new DateTime(2022, 07, 21);
            DateTime tarih3 = new DateTime(2022, 07, 24);

            List<RezervasyonBilgisi> rezervasyonBilgileri = new List<RezervasyonBilgisi>()
            {
                new RezervasyonBilgisi { RezervasyonID = 1, MusteriID = 1, TatilPaketiID=1,OdaID=1,KonaklamaBaslangic=tarih1,KonaklamaBitis=tarih2,GunSayisi=tarih2.Day-tarih1.Day },
                new RezervasyonBilgisi { RezervasyonID = 2, MusteriID = 2, KonaklamaBaslangic=tarih1,KonaklamaBitis=tarih3,GunSayisi=tarih3.Day-tarih1.Day, TatilPaketiID=2,OdaID=2 },
                new RezervasyonBilgisi { RezervasyonID = 3, MusteriID = 3,KonaklamaBaslangic=tarih2,KonaklamaBitis=tarih3,GunSayisi=tarih3.Day-tarih2.Day,TatilPaketiID=2,OdaID=3}

            };

            if (!context.RezervasyonBilgileri.Any())
            {
                foreach (var rezervasyonBilgisi in rezervasyonBilgileri)
                {
                    context.RezervasyonBilgileri.Add(rezervasyonBilgisi);
                    context.SaveChanges();
                }
            }
        }
    }
}
