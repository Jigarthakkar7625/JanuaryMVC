using JanuaryMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JanuaryMVC.Controllers
{
    public class HomeController : Controller
    {

        //Viewbag >> C > V
        //ViewDaTA >>  C > V
        //TempData >> C > C

        // Return type ??
        // View result return View();
        // PartialView() // 
        // JsonResult()
        // ContentResult()
        // REdirectResult()
        // RedirectToRouteResult()
        // File Result()
        // Empty Result()


        //




        //public EmptyResult Index()
        //{

        //    return new EmptyResult();
        //    // return Redirect("https://www.amazon.in/");
        //}

        public ActionResult Index()
        {
            if (Session["userid"] != null)
            {
                var getSeessionData = Session["userid"].ToString();
            }
            

            //CRUD:
            //Create
            //    READ, Update, Delete
            return View();
            // return Redirect("https://www.amazon.in/");
        }

        // JSON : Javascript Object Notation

        //    var json =
        //{
        //    "EmployeeId": "Jigar",
        //    "EmployeeName": "Thakkar"
        //}
        public JsonResult GetData()
        {
            var EmployeesList = new List<EmployeeModel>
            {
                new EmployeeModel{ EmployeeId=1,EmployeeName="MyName" },
                new EmployeeModel{ EmployeeId=2,EmployeeName="MyName1" }
            };

            return Json(EmployeesList, JsonRequestBehavior.AllowGet);
        }

        public ContentResult ContentResultData()
        {
            return Content("fhdksfdsfsdfsfhfdskfh");
        }

        public PartialViewResult MyPartialView()
        {
            UserModel userModel = new UserModel();
            userModel.UserId = 10;
            return PartialView("_MyPartialView", userModel);
        }



        public ActionResult Customer()
        {
            UserModel userModel = new UserModel();
            userModel.UserId = 10;

            userModel.EmployeesList = new List<EmployeeModel>
            {
                new EmployeeModel{ EmployeeId=1,EmployeeName="MyName" },
                new EmployeeModel{ EmployeeId=2,EmployeeName="MyName1" }
            };

            ViewBag.EmployeesList = userModel.EmployeesList;
            //ViewBag.MyName = "Jigar";
            //ViewBag.MyUserId = 12;
            //ViewBag.IsActive = true;

            ViewData["Employee"] = userModel.EmployeesList; //Key, value

            //Viewbag
            //ViewData
            //TempData

            return View(userModel);
        }

        [HttpPost]
        public ActionResult Customer(FormCollection frm)
        {

            TempData["MyData"] = "Jigar";

            UserModel userModel = new UserModel();
            return RedirectToAction("Index", "User");

        }

        public FileResult DownloadFile()
        {
            string filePath = System.Web.Hosting.HostingEnvironment.MapPath("~/Files/Darshan_Data_Engineer.pdf");
            
            byte[] data = System.IO.File.ReadAllBytes(filePath);
            return File(data, "application/pdf", "Arti.pdf");
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
    }
}