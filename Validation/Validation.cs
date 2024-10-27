﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab.Validation
{
    public static class Validations
    {
        public static bool ValidateEmail(this string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        public static bool ValidatePassword(this string password)
        {
            return password.Length >= 6;
        }

        public static bool ValidateName(this string name)
        {
            return name.Length >= 3;
        }
    }
}
