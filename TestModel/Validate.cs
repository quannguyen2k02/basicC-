
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BasicC_.TestModel
{
    class Validate
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public void Input()
        {
            Console.Write("Nhap email: ");
            Email = Console.ReadLine() ?? string.Empty;
            Console.Write("Nhap password: ");
            Password = Console.ReadLine() ?? string.Empty;
        }
        public (string, string, List<string>) Login()
        {
            var result = new List<string>();
            bool checkLength = ValidLengthPassword(Password);
            bool checkUpperCase = ValidUpperCase(Password);
            bool checkLowerCase = ValidLowerCase(Password);
            bool checkNumber = ValidNumber(Password);
            bool checkEmail = ValidEmail(Email);
            bool checkSpecialChar = ValidSpecialCharacter(Password);
            if (!checkEmail)
            {
                result.Add("Email khong hop le");

            }
            if (!checkLength)
            {
                result.Add("Do dai toi thieu 6 ky tu");
            }
            if (!checkUpperCase)
            {
                result.Add("Toi thieu 1 chu cai viet hoa");
            }
            if (!checkLowerCase)
            {
                result.Add("Toi thieu 1 chu cai viet thuong");

            }
            if (!checkNumber)
            {
                result.Add("Toi thieu co 1 so");
            }
            if (!checkSpecialChar)
            {
                result.Add("Toi thieu co 1 ky tu dac biet");
            }
            if (result.Count > 0)
            {
                return ("That bai", "", result);
            }
            else
            {
                return ("Thanh cong", GenerateOTP(), result);
            }
        }
        private bool ValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        private bool ValidLengthPassword(string password) => password.Length >= 6;
        //{
        //    //    if(password.Length >= 6)
        //    //    {
        //    //        return true;
        //    //    }
        //    //    else
        //    //    {
        //    //        return false;
        //    //    }
        //    return password.Length >= 6;
        //}
        private bool ValidUpperCase(string password)
        {
            return Regex.IsMatch(password, @"[A-Z]");
        }
        private bool ValidLowerCase(string password)
        {
            return Regex.IsMatch(password, @"[a-z]");
        }
        private bool ValidNumber(string password)
        {
            return Regex.IsMatch(password, @"\d");
        }
        private bool ValidSpecialCharacter(string password)
        {
            return Regex.IsMatch(password, @"[!@#$%^&*(),.?\:{ }|<>]");
        }
        public string GenerateOTP()
        {
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            char[] result = new char[6];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = letters[random.Next(letters.Length)];
            }

            return new string(result);
        }
    }
}
