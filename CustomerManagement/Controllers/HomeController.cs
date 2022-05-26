﻿using _DataCustomerManagement.Interfases;
using _DataCustomerManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CustomerManagement.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ICustomerActions customerAction;

        public HomeController(ICustomerActions _customerActions)
        {
            customerAction = _customerActions;
        }

        [Authorize]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        [HttpGet]
        public JsonResult CustomerList()
        {
            var allcustomerlist = customerAction.GetAll();
            var jsonResult = Json(allcustomerlist, JsonRequestBehavior.AllowGet);
            jsonResult.MaxJsonLength = int.MaxValue;
            return jsonResult;
        }

        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(UserViewModel userViewModel)
           {
            if(true == customerAction.SignInCheck(userViewModel))
            {
                FormsAuthentication.SetAuthCookie(userViewModel.user_email, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.msg = "Wrong Password";
                return RedirectToAction("SignIn");
            }
        }

        [Authorize]
        [HttpGet]
        public ActionResult SignOut(UserViewModel model)
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("SignIn", "Home");
        }

        [Authorize]
        [HttpGet]
        public ActionResult AddCustomer()
        {
            return PartialView();
        }

        [Authorize]
        [HttpPost]
        public ActionResult AddCustomer(CustomerViewModel mod)
        {
            if (ModelState.IsValid)
            {
                int i = customerAction.Add(mod);
                if(i>=1)
                {
                    return RedirectToAction("Index", "Home");
                }

                ViewBag.msg = "Not Able To Add Customer";
                return View();
            }
            ViewBag.msg = "Model not valid";
            return View();
        }
    }
}