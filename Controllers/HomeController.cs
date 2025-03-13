using JanuaryMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JanuaryMVC.Controllers
{

    public class groupBy
    {

        public string Key { get; set; }
        public int Total { get; set; }
    }

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

        public bool Check(int value)
        {
            if (value > 5)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        public ActionResult Index()
        {
            var a = Enumerable.Range(1, 10);

            DB_January_BatchEntities dB_January_BatchEntities = new DB_January_BatchEntities();


            // Directly Database ma filter marse
            IEnumerable<EmpAddress> empAddresses1 = dB_January_BatchEntities.EmpAddresses.ToList().Where(x => x.EmployeeAddressID > 2);


            foreach (var item in empAddresses1)
            {
                Console.WriteLine(item);

            }


            // Directly Database ma filter marse
            IQueryable<EmpAddress> empAddresses = dB_January_BatchEntities.EmpAddresses.Where(x => x.EmployeeAddressID > 2);


            foreach (var item in empAddresses)
            {
                Console.WriteLine(item);

            }


            // Take

            //var a = dB_January_BatchEntities.EmpAddresses.Take(5).ToList();

            //var b = dB_January_BatchEntities.EmpAddresses.Take(5).ToList();

            //var take5 = dB_January_BatchEntities.EmpAddresses.AsEnumerable().Take(5).TakeWhile(x => x.EmployeeID < 5).ToList();




            //var b1 = dB_January_BatchEntities.EmpAddresses.OrderBy(x => x.Address).Skip(5).ToList();

            //var take56 = dB_January_BatchEntities.EmpAddresses.OrderBy(x => x.Address).AsEnumerable().Skip(5).SkipWhile(x => x.EmployeeID < 5).ToList();


            // Pagination:

            //int pagenumber = 2; // Dynamic
            //int pageSize = 5;

            //var paginationData = dB_January_BatchEntities.EmpAddresses.OrderBy(x => x.Address).Skip((pagenumber - 1) * pageSize).Take(pageSize).ToList();


            //var result = (from empIndia in dB_January_BatchEntities.EmployeeIndias
            //              join empAdd in dB_January_BatchEntities.EmpAddresses on empIndia.ID equals empAdd.EmployeeID
            //              select new
            //              {
            //                  Name = empIndia.Name,
            //                  Address = empAdd.Address
            //              }).ToList();





            var stringList12111 = new List<string> { "Arti", "df" }; // Object

            var abc = stringList12111.Where(x => x == "ffds").DefaultIfEmpty();


            var stringList1 = new List<string> { "Arti", "df" }; // Object

            var stringListsdsd2 = new List<string>(); // Object

            string index1 = stringList1.SingleOrDefault(); // 1 record return


            string index = stringList1.Single(); // 1 record return 

            string indexsd = stringListsdsd2.Single();


            //string index = stringList1.Last(); // 1 record return 
            //string index1 = stringListsdsd2.LastOrDefault(); // 1 record return
            //string indexsd = stringListsdsd2.Last();

            //string index = stringList1.First(); // 1 record return 
            //string index1 = stringListsdsd2.FirstOrDefault(); // 1 record return
            //string indexsd = stringListsdsd2.First();

            //string index = stringList1.ElementAt(1);
            //string index1 = stringList1.ElementAtOrDefault(1);


            // Any() : any one record exist (with filter criteria) then return true
            // All() : ALL record exist (with filter criteria) then return true
            //Contain()  : 

            // LINQ : Language Integrrated Query

            var any = dB_January_BatchEntities.Products.Any(x => x.Price > 1500);

            var all = dB_January_BatchEntities.Products.All(x => x.Price > 50);


            var groupby = dB_January_BatchEntities.Products.GroupBy(x => x.ProductName).Select(x => new groupBy
            {
                Key = x.Key,
                Total = (int)x.Sum(y => y.Price)

            }).ToList();

            //foreach (var item in groupby)
            //{
            //    var count212 = item.Count();

            //}




            var contain = stringList1.Contains("Arti");


            var sum = dB_January_BatchEntities.Products.Max(x => x.Price);

            var count = dB_January_BatchEntities.Products.Count();

            if (count > 0)
            {

            }

            //Except
            var intList1 = new List<int> { 1, 2, 3, 4, 5, 6 }; // Object
            var intList2 = new List<int> { 1, 3, 5, 8, 9, 10 }; // Object



            var stringList2 = new List<string> { "Reena", "Arti" }; // Object

            //var gexcept1234 = stringList1.Except(stringList2, StringComparer.OrdinalIgnoreCase).ToList();

            //var gexcept12345 = stringList1.Intersect(stringList2, StringComparer.OrdinalIgnoreCase).ToList();

            //var gexcept123455 = stringList1.Union(stringList2).ToList(); // 

            //var gexcept1234555 = stringList1.Concat(stringList2).ToList(); // 

            //var gexcept1234555 = stringList1.OrderBy(x => x).ToList(); // 
            stringList1.Reverse();

            //List<int> intListnull = new List<int>();

            //List<int> intListnull = new List<int>();






            var gexcept = intList1.Except(intList2).ToList();
            var gexcept123 = intList2.Except(intList1).ToList();





            //var getCustomerList = dB_January_BatchEntities.Customers.ToList();
            //// Select * from [dbo].[Customers]

            ////Query Syntex
            //var getQCustomerName = (from emp in dB_January_BatchEntities.Customers
            //                        select new Customer()
            //                        {
            //                            Name = emp.Name,
            //                            Age = emp.Age
            //                        }).ToList();

            //// Method Syntex
            //var getCustomerName = dB_January_BatchEntities.Customers.
            //    Select(x => new Customer()
            //    {
            //        Name = x.Name + "Jigar fd j",
            //        Age = x.Age
            //    }).ToList();

            //IEnumerable<char> abc = dB_January_BatchEntities.Customers.SelectMany(x => x.Name);

            //foreach (var item in abc)
            //{
            //    Console.WriteLine(item);
            //}


            var getQCustomerName = from emp in dB_January_BatchEntities.Customers where emp.CustomerID > 5 select emp;

            var getCustomerName = dB_January_BatchEntities.Customers.Where(x => Check(x.CustomerID)).ToList();

            var getCustomerName1 = dB_January_BatchEntities.Customers.Select(x => x.City).Distinct().ToList();

            var getCustomerName112 = dB_January_BatchEntities.Customers.OrderBy(x => x.Name).ToList();

            var getCustomerName1122 = dB_January_BatchEntities.Customers.OrderByDescending(x => x.Name).ThenByDescending(x => x.City).ToList();


            var intList = new List<int> { 1, 3, 5, 8, 7, 8, 9, 5, 6 }; // Object
            var dis = intList.Distinct();





            //List<int> ints = new List<int>();
            //ints.Add(1);

            // LINQ TO OBJECT
            // LINQ To ADO.NET DATASET
            // LINQ To EF
            // LINQ To SQL
            // LINQ To XML

            //Query : Method Syntex
            //Query : Query Syntex

            //1. Projection Operator : Select, SelectMany
            //2. Filtering Operator : WHere
            //3. Partition Operator : Take, TakeWhile, Skip , SkipWhile 
            //4. Orderting Operator : Orderby, Orderbydesc, thenby, thenbydesc
            //5. Grouping opetator : Group by
            //6. Join Operator : Joins
            //6. Set opetator : Distinct, union, intersect, Except
            //7. Conversation : .ToList(), array
            //8. Element operator : First, FirstoRdefault, Last, LastorDefault, Single, SingleOrDefailt, ElementAT, ElementAtDefault
            //9. Qualifier : Any, All, Contains
            // 10. Aggrigation : Count, SUM, AVG......
            // Generation : Emp, Repeat, RaNGE









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

        public ActionResult Logout()
        {
            Session.Abandon();
            Session.Clear();

            ViewBag.Message = "Your contact page.";

            return RedirectToAction("Index", "User");
        }
    }
}