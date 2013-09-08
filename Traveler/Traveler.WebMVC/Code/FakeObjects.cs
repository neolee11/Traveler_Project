using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Traveler.Domain;

namespace Traveler.WebMVC.Code
{
    public class FakeObjects
    {
        public static User GetUser()
        {
            var user = new User();
            user.FirstName = "Daniel";
            user.LastName = "Li";
            user.Gender = GenderTypes.Male;
            user.Birthday = new DateTime(1980, 1, 1);
            user.HomeAddress = GetAddress();

            return user;
        }

        public static Address GetAddress()
        {
            var address = new Address();
            address.Street = "23rd Street";
            address.HouseNum = "201";
            address.City = "Arlington";
            address.State = "VA";
            address.Country = "USA";
            address.ZipCode = "22202";

            return address;
        }
    }
}