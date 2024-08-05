using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest.classes
{
    public static class Validators
    {
        public static bool ValidatePhoneNumber(string phoneNumber) {
            return phoneNumber.StartsWith("05") && phoneNumber.Length == 10;
        }

        public static bool ValidateEmail(string email)
        {
            return email.EndsWith("@gmail.com");
        }
    }
}
