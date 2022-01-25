using DiscountCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscountCalculator.Interfaces
{
    public interface ISetInMemory
    {
        public void SetInMemoryDetails();
        public void SetLoginDetails(LoginModel login);
    }
}
