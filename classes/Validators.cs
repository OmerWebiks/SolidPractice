using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SolidTest.classes
{
    public static class Validators
    {
        public static bool ValidatePhoneNumber(string phoneNumber) {
            return phoneNumber.StartsWith("05") && phoneNumber.Length == 10;
        }

        public static bool ValidateEmail(string email)
        {
            // ^[^@\s]+@[^@\s]+\.(com|net|org|gov)$

            // ^
            // [^@\s]+
            // @
            // [^@\s]+
            // \.
            // (com|net|org|gov)$
            string emailRegex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";
            return Regex.IsMatch(email, emailRegex);
        }
    }
}
