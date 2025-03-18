using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace JanuaryMVC.Auth
{
    public class AuthenticationAtttr : ActionFilterAttribute, IAuthenticationFilter
    {
        //public void OnAuthorization(AuthorizationContext filterContext)
        //{
        //    // Database >> User and Password >> 
        //    if (filterContext.HttpContext.Session["UserId"] == null)
        //    {
        //        // Database ma check karo cho
        //        filterContext.Result = new RedirectResult("Register/Index");
        //    }

        //    //throw new NotImplementedException();
        //}
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            throw new NotImplementedException();
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            throw new NotImplementedException();
        }
    }
}