using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.CustomFilters
{
    public class AuthFilter : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session["login"] == null) //oturum acilmamisssa
            {
                filterContext.Result = new RedirectResult("~/Home/Login"); //login sayfasinda git
            }
        }
    }
}