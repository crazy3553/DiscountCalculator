using DiscountCalculator.Interfaces;
using DiscountCalculator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscountCalculator.Controllers
{
    [Route("/Discount/")]
    [Route("{action=Home}")]
    public class Discount:Controller
    {
        SetInMemory obj;
        private readonly IMemoryCache inMemoCache;
        public Discount(IMemoryCache memoCache)
        {
            inMemoCache = memoCache;
            obj = new SetInMemory(memoCache); 
        }
        public IActionResult Home()
        {
            ViewBag.InValidLogin = false;
            obj.SetInMemoryDetails();
            return View("Home");
        }
        [Route("Login")]
        public IActionResult Login(LoginModel loginData)
        {           
            try{
                if (ModelState.IsValid)
                {
                    List<LoginStoreDetails> data= inMemoCache.Get<List<LoginStoreDetails>>("UserCache");
                    foreach(var item in data)
                    {
                        if((item.UserName.ToUpper() == loginData.UserName.ToUpper()) && item.password.ToUpper()== loginData.Password.ToUpper())
                        {
                            ViewBag.InValidLogin = false;
                            obj.SetLoginDetails(loginData);
                            return View("Login");
                        }
                        else
                        {
                            ViewBag.InValidLogin = true;
                        }
                    }
                    
                }
                else
                {
                    throw new InvalidOperationException("Please check your details");
                }
            }
            catch(Exception er)
            {
                
            }
            return View("Home");
        }
        [HttpPost]
        [Route("DisCalculator")]
        public IActionResult DisCalculator(DiscountModel discount)
        {
            return View("Login");
        }
    }
}
