using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Cart
    {
        Dictionary<int, CartItemVM> _myCart = new Dictionary<int, CartItemVM>();

        public List<CartItemVM> myCart
        {
            get
            {
                return _myCart.Values.ToList();
            }
        }

        public void AddRoom(CartItemVM cartItem)
        {
            if (_myCart.ContainsKey(cartItem.OdaID)) //Eger eklenen urunun ID'sini iceriyorsa, adeti artir.
            {
                _myCart[cartItem.OdaID].GunSayisi = cartItem.GunSayisi;
                return;
            }
            _myCart.Add(cartItem.OdaID, cartItem); //odayi ekle
        }

        public void AddPackage(CartItemVM cartItem)
        {
            _myCart.Add(cartItem.TatilPaketID, cartItem); //Tatil paketini ekle
        }

        public void AddDate(CartItemVM cartItem)
        {
            _myCart.Add(cartItem.KonaklamaBaslangic.Day, cartItem); //Baslangic ekle
            _myCart.Add(cartItem.KonaklamaBitis.Day, cartItem); //Bitis ekle
        }
    }
}