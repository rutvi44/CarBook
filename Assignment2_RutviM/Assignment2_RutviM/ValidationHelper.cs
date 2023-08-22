
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment2_RutviM
{
    public static class ValidationHelper
    {
        // Method to capitalize the first letter of each word in a string
        public static string Capitalize(string inputstr)
        {
            if (string.IsNullOrEmpty(inputstr))
                return string.Empty;

            string[] inputArray = inputstr.ToLower().Split(' ');

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length > 1 || i == 0)
                    inputArray[i] = char.ToUpper(inputArray[i][0]) + inputArray[i][1..];
            }

            return string.Join(' ', inputArray);
        }

        // Method to validate a Canadian postal code
        public static bool IsValidPostalCode(string postalCode)
        {
            if (string.IsNullOrEmpty(postalCode))
            {
                return false;
            }

            string validation = @"^[A-Za-z]\d[A-Za-z] \d[A-Za-z]\d$";
            return Regex.IsMatch(postalCode, validation);
        }

        // Method to validate a Canadian province code
        public static bool IsValidProvinceCode(string provinceCode)
        {
            if (string.IsNullOrEmpty(provinceCode))
            {
                return false;
            }

            string[] validProvinceCode = { "AB", "BC", "MB", "NB", "NL", "NS", "NT", "NU", "ON", "PE", "QC", "SK", "YT" };
            return Array.IndexOf(validProvinceCode, provinceCode.ToUpper()) != -1;
        }

        // Method to validate a phone number in the format '123-123-1234'
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
            {
                return false;
            }

            string phoneNumberValidation = @"^\d{3}-\d{3}-\d{4}$";
            return Regex.IsMatch(phoneNumber, phoneNumberValidation);
        }

        // Method to validate if a year is within a valid range
        public static bool IsYearValid(string year)
        {
            if (!int.TryParse(year, out int parsedYear))
                return false;

            int currentYear = DateTime.Now.Year;
            return parsedYear >= 1900 && parsedYear <= currentYear + 1;
        }

        // Method to format a postal code by adding a space in the middle
        public static string FormatPostalCode(string postalCode)
        {
            if (string.IsNullOrEmpty(postalCode))
            {
                return string.Empty;
            }

            postalCode = postalCode.ToUpper().Replace(" ", "");

            if (postalCode.Length == 6)
            {
                postalCode = postalCode.Insert(3, " ");
            }

            return postalCode;
        }

        // Method to format a phone number by adding dashes
        public static string FormatPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
            {
                return string.Empty;
            }

            phoneNumber = phoneNumber.Replace("-", "");

            if (phoneNumber.Length == 10)
            {
                phoneNumber = phoneNumber.Insert(3, "-").Insert(7, "-");
            }

            return phoneNumber;
        }


    }
}
