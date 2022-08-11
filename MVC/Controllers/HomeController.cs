using BLL.Concrete;
using BLL.Repository;
using DAL.Context;
using DAL.Entity;
using MVC.CustomFilters;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    //[AuthFilter]
    public class HomeController : Controller
    {
        ProjectContext db = new ProjectContext();
        MusteriBilgisiConcrete musteriConcrete = new MusteriBilgisiConcrete();
        CalisanConcrete calisanConcrete = new CalisanConcrete();

        //Login islemleri
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginUserVM LoginUserVM)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (db.MusteriBilgileri.Any(x => x.Email == LoginUserVM.Email && x.Sifre == LoginUserVM.Sifre))
                    {
                        MusteriBilgisi user = db.MusteriBilgileri.Where(x => x.Email == LoginUserVM.Email && x.Sifre == LoginUserVM.Sifre).FirstOrDefault();

                        //Session["scart"] = user;

                        return RedirectToAction("Odalar");
                    }
                    else
                    {
                        TempData["girisHata"] = "Email veya şifre hatalı!";
                        return View(LoginUserVM);
                    }
                }
                catch
                {

                    return View();
                }
            }
            else
            {
                return View(LoginUserVM);
            }
        }

        public ActionResult Pending(UserVM userVM)
        {
            if (userVM != null)
            {
                return View(userVM);
            }
            else
            {
                return RedirectToAction("Login");
            }

        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Odalar()
        {
            TempData["odalar"] = db.Odalar.OrderBy(x => x.OdaID).ToList();

            TempData.Keep();
            return View();
        }
        public ActionResult TatilPaketi()
        {
            TempData["tatil"] = db.TatilPaketleri.OrderBy(x => x.TatilPaketiID).ToList();

            TempData.Keep();
            return View();
        }
        public ActionResult Tarih()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View(calisanConcrete.GetList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //Register islemleri
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserVM userVM)
        {
            if (ModelState.IsValid)
            {
                MusteriBilgisi appUser = new MusteriBilgisi();
                appUser.Ad = userVM.Ad;
                appUser.Soyad = userVM.Soyad;
                appUser.TCKN = userVM.TCKN;
                appUser.TelNo = userVM.TelNo;
                appUser.Email = userVM.Email;
                appUser.Sifre = userVM.Sifre;
                var result = musteriConcrete.Create(appUser);
                TempData["info"] = result;


                return RedirectToAction("Pending");

            }
            else
            {
                return View(userVM);
            }
        }

        //Cart'a ekleme islemleri
        public ActionResult AddRoomToCart(int id)
        {
            try
            {
                Oda oda = db.Odalar.Find(id);

                Cart c = null;

                if (Session["scart"] == null) //oturum acilmamissa scard isimli bir session olustur.
                {
                    c = new Cart();

                }
                else //scard isimli bir session varsa, var olan oturumu kullan
                {
                    c = Session["scart"] as Cart; //scard isimli session'i card olarak unboxing yap ve icerisine at.                   
                }

                CartItemVM ci = new CartItemVM();
                ci.OdaID = oda.OdaID;
                ci.OdaTuru = oda.OdaTuru;
                ci.OdaTuruFiyati = oda.Fiyat; //Bos gecilebilir bir degere bos gecilemez bir deger aktarilamaz. bu nedenle property'ler duzeltilir.
                c.AddRoom(ci); //oturum icerisindeki karta kart item'larini ekle.
                Session["scart"] = c;

                return RedirectToAction("Odalar");
            }
            catch (Exception)
            {
                return View();
            }
        }

        public ActionResult AddPackageToCart(int id)
        {
            try
            {
                TatilPaketi tatilPaketi = db.TatilPaketleri.Find(id);


                Cart c = null;

                //if (Session["scart"] == null) //oturum acilmamissa scard isimli bir session olustur.
                //{
                //    c = new Cart();

                //}
                //else //scard isimli bir session varsa, var olan oturumu kullan
                //{
                    c = Session["scart"] as Cart; //scard isimli session'i card olarak unboxing yap ve icerisine at.                   
                //}

                CartItemVM ci = new CartItemVM();

                ci.TatilPaketi = tatilPaketi.TatilTipi;
                ci.TatilPaketID = tatilPaketi.TatilPaketiID;
                ci.TatilPaketiFiyati = tatilPaketi.Fiyat;
                c.AddPackage(ci);
                Session["scart"] = c;

                return RedirectToAction("TatilPaketi");
            }
            catch (Exception)
            {
                return View();
            }
        }

        //public ActionResult AddDateToCart()
        //{
            
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            Cart c = null;

        //            c = new Cart();
        //            c = Session["scart"] as Cart; //scard isimli session'i card olarak unboxing yap ve icerisine at.                   


        //            CartItemVM ci = new CartItemVM();

        //            ci.KonaklamaBaslangic = rezervasyon.KonaklamaBaslangic;
        //            ci.KonaklamaBitis = rezervasyon.KonaklamaBitis;
        //            ci.GunSayisi = rezervasyon.GunSayisi;
        //            c.AddPackage(ci);
        //            Session["scart"] = c;

        //            return RedirectToAction("Tarih");

        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }
        //    else
        //    {
        //        return View(rezervasyon);
        //    }

        //}

        //Cart islemleri
        public ActionResult MyCart()
        {
            if (Session["scart"] != null)
            {
                return View();
            }
            else
            {
                TempData["error"] = "Tatil seçimi yapınız!";
                return RedirectToAction("Odalar");
            }
        }
        public ActionResult CompleteCart()
        {
            //Cart cart = Session["scart"] as Cart;
            db.SaveChanges();
            Session.Remove("scart");
            //foreach (var item in cart.myCart)
            //{
            //    Oda oda = db.Odalar.Find(item.OdaID);
            //    db.Entry(oda).State = System.Data.Entity.EntityState.Modified; //degisiklikleri sisteme modifiye et.
            //    db.SaveChanges(); //kaydet
            //    Session.Remove("scart"); //scart isimli session'i bosalt.
            //}
            return View();
        }



    }
}