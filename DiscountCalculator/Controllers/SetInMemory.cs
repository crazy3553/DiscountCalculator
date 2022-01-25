using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscountCalculator.Interfaces;
using DiscountCalculator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace DiscountCalculator.Controllers
{
    public class SetInMemory : Controller, ISetInMemory
    {
        private LoginDetails loginData = new LoginDetails();
        private readonly IMemoryCache memoryCache;
        private List<LoginStoreDetails> userStore = new List<LoginStoreDetails>();
        private string keyUser = "UserCache";
        private string keyLogin = "login";
        public SetInMemory(IMemoryCache memo)
        {
            memoryCache = memo;
        }
        public void SetInMemoryDetails()
        {
            userStore=loginData.SetLoginDetails();
            var entry=memoryCache.CreateEntry(keyUser);
            entry.SetValue(userStore);
            entry.Dispose();
        }
        public void SetLoginDetails(LoginModel login)
        {
            userStore = loginData.SetLoginDetails();
            var entry = memoryCache.CreateEntry(keyLogin);
            entry.SetValue(login);
            entry.Dispose();
        }
    }
}
