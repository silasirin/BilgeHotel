using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class CartVM
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
                _myCart[cartItem.OdaID].OdaSayisi += cartItem.OdaSayisi;
                return;
            }
            _myCart.Add(cartItem.OdaID, cartItem); //Eger eklenen urunun ID'sini icermiyorsa, urunu ekle
        }
    }
}