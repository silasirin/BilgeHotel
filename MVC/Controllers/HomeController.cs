using BLL.Concrete;
using BLL.Repository;
using DAL.Context;
using DAL.Entity;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    
    public class HomeController : Controller
    {
        ProjectContext db = new ProjectContext();
        MusteriBilgisiConcrete musteriConcrete = new MusteriBilgisiConcrete();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
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

        //Cart'a ekleme islemleri
        public ActionResult AddToCart(int id)
        {
            try
            {
                TatilPaketi tatilPaketi = new TatilPaketi();
                Oda oda = db.Odalar.Find(id);

                CartVM c = null;

                if (Session["scart"] == null) //oturum acilmamissa scart isimli bir session olustur.
                {
                    c = new CartVM();

                }
                else //scart isimli bir session varsa, var olan oturumu kullan
                {
                    c = Session["scart"] as CartVM; //scart isimli session'i cartVM olarak unboxing yap ve icerisine at.                   
                }


                CartItemVM ci = new CartItemVM();
                
                ci.OdaID = oda.OdaID;
                ci.OdaTuru = oda.OdaTuru;
                ci.OdaTuruFiyati = oda.Fiyat;
                ci.TatilPaketi = tatilPaketi.TatilTipi;
                ci.TatilPaketiFiyati = tatilPaketi.Fiyat;
                c.AddRoom(ci);
                Session["scard"] = c;

                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                TempData["error"] = $"{id} karşılık gelen bir oda bulunamadı!";
                return View();
            }
        }

        //Cart islemleri
        public ActionResult MyCart()
        {
            if (Session["scart"] != null)
            {
                return View();
            }
            else
            {
                TempData["error"] = "Oda seçimi yapınız!";
                return RedirectToAction("Index");
            }
        }

        public ActionResult CompleteCart()
        {
            CartVM cart = Session["scart"] as CartVM;
            foreach (var item in cart.myCart)
            {
                Oda oda = db.Odalar.Find(item.OdaID);
                oda.OdaSayisi -= Convert.ToInt16(item.OdaSayisi); //stogu adet kadar dusur
                db.Entry(oda).State = System.Data.Entity.EntityState.Modified; //degisiklikleri sisteme modifiye et.
                db.SaveChanges(); //kaydet
                Session.Remove("scart"); //scard isimli session'i bosalt.
            }
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserVM userVM)
        {
            if (ModelState.IsValid)
            {
                MusteriBilgisi appUser = new MusteriBilgisi();
                appUser.Email = userVM.Email;
                appUser.Sifre = userVM.Sifre;
                var result = musteriConcrete.Create(appUser);
                TempData["info"] = result;


                return RedirectToAction("Index");

            }
            else
            {
                return View(userVM);
            }
        }

        //Login islemleri
        [HttpPost]
        public ActionResult Login(UserVM userVM)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (db.MusteriBilgileri.Any(x => x.Email == userVM.Email && x.Sifre == userVM.Sifre))
                    {
                        MusteriBilgisi user = db.MusteriBilgileri.Where(x => x.Email == userVM.Email && x.Sifre == userVM.Sifre).FirstOrDefault();

                        Session["scart"] = user;
                        return RedirectToAction("MyCart");
                    }
                    else
                    {
                        TempData["error"] = "Kullanici adi ve sifre hatali!";
                        return View(userVM);
                    }
                }
                catch (Exception)
                {
                    return View();
                }
            }
            else
            {
                return View(userVM);
            }
        }

    }
}