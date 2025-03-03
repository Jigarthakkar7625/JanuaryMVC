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
        public ActionResult Index()
        {

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


            //Register register = new Register();
            //register.UserName = "Jigar";

            // Save



            register = new Register();
            return RedirectToAction("Index", "Register");
        }

        // GET: Register/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Register/Create
        public ActionResult Create()
        {
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
