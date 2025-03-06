using JanuaryMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JanuaryMVC.Controllers
{
    public class RegisterController : Controller
    {

        // GET: Register

        // Login >> Useerid >> Store >> Session

        public ActionResult Index()
        {
            HttpCookie httpCookie = new HttpCookie("UserId", "fhsfjksdhfksdhfjkfhjkhsf");
            httpCookie.Expires = DateTime.Now.AddDays(10);
            Response.Cookies.Add(httpCookie);


            //Client : 
            // Server
            Session["userid"] = 10;


            DB_January_BatchEntities dB_January_BatchEntities = new DB_January_BatchEntities();
            var getCustomerList = dB_January_BatchEntities.Customers.ToList();


            Register register = new Register();
            register.UserName = "Jigar";

            List<UserModel> userModel = new List<UserModel>
            {
                new UserModel(){UserId = 1, UserName = "Jigar" },
                new UserModel(){UserId = 2, UserName = "Jigar1" },
                new UserModel(){UserId = 3, UserName = "Jigar2" }
            };


            ViewBag.UserList = getCustomerList;

            return View(register);
        }

        [HttpPost]
        public ActionResult Save(Register register)
        {

            var getCoo = Request.Cookies["UserId"]?.Value;
            //50
            //    4mb
            DB_January_BatchEntities dB_January_BatchEntities = new DB_January_BatchEntities();
            var getCheckUser = dB_January_BatchEntities.Customers.Where(x => x.username == register.email && x.password == register.Password).firstorDefault();


            if (getCheckUser != null) {
                Session["userid"] = getCheckUser.USerId;
                Session["emailid"] = getCheckUser.emailid;
            }

            var getSeessionData = Session["userid"].ToString();

            

            var customerId = 9;

            //var getCustomer = dB_January_BatchEntities.Customers.Where(x => x.CustomerID == customerId).FirstOrDefault();

            //getCustomer.City = "Canada";
            //getCustomer.Age = "50";
            //getCustomer.Name = "Palak";

            //dB_January_BatchEntities.SaveChanges();

            var getCustomerForDelete = dB_January_BatchEntities.Customers.Where(x => x.CustomerID == customerId).FirstOrDefault();

            dB_January_BatchEntities.Customers.Remove(getCustomerForDelete);

            dB_January_BatchEntities.SaveChanges();



            //Customer customer = new Customer();
            //customer.CustomerID = 9;
            //customer.Name = "Hello Brother";
            //customer.City = "Ahmedabad";
            //customer.Age = "18";
            //dB_January_BatchEntities.Customers.Add(customer); //Insert

            //dB_January_BatchEntities.SaveChanges(); // Database ma save thase 


            //var getCustomerList = dB_January_BatchEntities.Customers.ToList();


            //Register register = new Register();
            //register.UserName = "Jigar";

            // Save


            //domain?id=12&name=fsdsf

            register = new Register();
            return RedirectToAction("Create", "Register", new { myData = "123", name="dsdfs" });
        }

        // GET: Register/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        // GET: Register/Create
        public ActionResult Create()
        {
            var getNameFromQS = Request.QueryString["name"];
            var getNameFromQS1 = Request.QueryString["myData"];
            return View();
        }

        // POST: Register/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Register/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Register/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Register/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Register/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
