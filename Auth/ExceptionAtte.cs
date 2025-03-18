using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JanuaryMVC.Auth
{
    public class ExceptionAtte : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            // Database
            // Textfile
            //    throw new NotImplementedException();
        }
    }
}