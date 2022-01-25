using DiscountCalculator.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace DiscountCalculator.Models
{
   sealed class LoginDetails:ILoginDetails
    {
        private List<LoginStoreDetails> loginData = new List<LoginStoreDetails>();
        public List<LoginStoreDetails> SetLoginDetails()
        {
            loginData.Add(new LoginStoreDetails { UserName = "user1", password = "1234" });
            loginData.Add(new LoginStoreDetails { UserName = "user2", password = "1234" });
            loginData.Add(new LoginStoreDetails { UserName = "user3", password = "1234" });
            return loginData;
        }
    }
}
