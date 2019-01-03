using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProject.Models;

namespace TestingProject.Tests.Model
{
    [TestClass()]
    public class IsValidCustomerTest
    {

        [TestMethod]
        public void isValid()
        {
            IsValidCustomer customer = new IsValidCustomer();
            customer.isValid(1);
        }
    }
   
}
