using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class CartTatilVM
    {
        Dictionary<int, CartItemVM> _myCart = new Dictionary<int, CartItemVM>();

        public List<CartItemVM> myCart
        {
            get
            {
                return _myCart.Values.ToList();
            }
        }
        public void AddPackage(CartItemVM cartItem)
        {
            if (_myCart.ContainsKey(cartItem.TatilPaketID)) //Eger eklenen urunun ID'sini iceriyorsa, adeti artir.
            {
                _myCart[cartItem.TatilPaketID].GunSayisi = cartItem.GunSayisi;
                return;
            }
            _myCart.Add(cartItem.TatilPaketID, cartItem); //Eger eklenen urunun ID'sini icermiyorsa, urunu ekle
        }
    }
}