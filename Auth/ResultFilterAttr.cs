using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JanuaryMVC.Auth
{
    public class ResultFilterAttr : FilterAttribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            //throw new NotImplementedException();
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {

            filterContext.Controller.ViewBag.UserName = "Vivek";

            //throw new NotImplementedException();
        }

        // VIEW() > OnResultExecuting> HTML > OnResultExecuted
    }
}