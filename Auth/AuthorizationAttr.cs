using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JanuaryMVC.Auth
{
    public class AuthorizationAttr : ActionFilterAttribute, IAuthorizationFilter
    {

        private string _role;
        public AuthorizationAttr(string roles)
        {
            _role = roles;

        }

        public void OnAuthorization(AuthorizationContext filterContext)
        {

            var getRoles = Convert.ToString(filterContext.HttpContext.Session["Roles"]);

            var checRoles = _role.Contains(getRoles);
            if (!checRoles)
            {
                filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(new { Controller = "AccessDenied", Action = "Index" }));
            }

            //throw new NotImplementedException();
        }
    }
}