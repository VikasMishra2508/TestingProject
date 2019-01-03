using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingProject.Models
{
    public class IsValidCustomer
    {
        public IsValidCustomer()
        {

        }

        public bool isValid(int id)
        {
            if (id < 10) throw new Exception("This Is an Error");
            return true;
        }
    }
}