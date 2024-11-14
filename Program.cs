using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace HelloWorld
{

    public class PhanSo
    {
        private int tuso, mauso;
        public int Tuso
        {
            set { tuso = value; }
            get { return this.tuso; }
        }

        public int Mauso
        {
            set
            {
                try
                {
                    if (value == 0)
                    {
                        Exception MauBangKhong = new Exception("Mau phai khac 0");
                        throw MauBangKhong;
                    }
                    else
                    {
                        this.mauso = value;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    throw ex;
                }
            }
            get { return this.mauso; }
        }
        public PhanSo(int tu, int mau)
        {
            Tuso = tu;
            Mauso = mau;
        }
        public PhanSo() { }
        public void Rutgon()
        {
            int a = this.Tuso;
            int b = this.Mauso;
            int ucln;
            if (a < 0)
            {
                a = a * (-1);
            }
            if (b < 0)
            {
                b = b * (-1);
            }
            if (a == 0)
            {
                ucln = a + b;
            }
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            ucln = a;
            this.Tuso /= ucln;
            this.Mauso /= ucln;
        }
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.Mauso = a.Mauso * b.Mauso;
            c.Tuso = a.Tuso * b.Mauso + b.Tuso * a.Mauso;
            c.Rutgon();
            return c;
        }
        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.Mauso = a.Mauso * b.Mauso;
            c.Tuso = a.Tuso * b.Mauso - b.Tuso * a.Mauso;
            c.Rutgon();
            return c;
        }
        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.Mauso = a.Mauso * b.Mauso;
            c.Tuso = a.Tuso * b.Tuso;
            c.Rutgon();
            return c;
        }
        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            try
            {
                if (b.Tuso == 0)
                {
                    Exception ThuongBangKhong = new Exception("Thuong phai khac 0");
                    throw ThuongBangKhong;
                }
                else
                {
                    c.Tuso = a.Tuso * b.Mauso;
                    c.Mauso = a.Mauso * b.Tuso;
                    c.Rutgon();
                    return c;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }
        public override string ToString()
        {
            return Convert.ToString(this.Tuso) + "/" + Convert.ToString(this.Mauso);
        }

    }
    class Calculator
    {
        public int a { set; get; }
        public int b { set; get; }
        public Calculator(int a, int b) {
            this.a = a;
            this.b = b;
        }
        public int Cong()
        {
            return a + b;
        }
        public int Tru()
        {
            return a - b;
        }
        public  int Nhan()
        {
            return a * b;
        }
        public double Chia()
        {
            try
            {
                if(b == 0)
                {
                    Exception bbang0 = new Exception("b phai khac 0");
                    throw bbang0;
                }
                else
                {
                    return (double)a / b;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw ex;
            }
        }
    }
    class Validate
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public void Input()
        {
            Console.Write("Nhap email: ");
            Email = Console.ReadLine();
            Console.Write("Nhap password: ");
            Password = Console.ReadLine();
        }
        public void Login()
        {
            List<String> result = new List<string>();
            bool checkLength = ValidLengthPassword(Password);
            bool checkUpperCase = ValidUpperCase(Password);
            bool checkLowerCase = ValidLowerCase(Password);
            bool checkNumber = validNumber(Password);
            bool checkSpecialChar = ValidSpecialCharacter(Password);

            if(!checkLength)
            {
                result.Add("Do dai toi thieu 6 ky tu");
            }
            if(!checkUpperCase)
            {
                result.Add("Toi thieu 1 chu cai viet hoa");
            }
            if (!checkLowerCase)
            {
                result.Add("Toi thieu 1 chu cai viet thuong");

            }
            if(!checkNumber) {
                result.Add("Toi thieu co 1 so");
            }
            if(!checkSpecialChar)
            {
                result.Add("Toi thieu co 1 ky tu dac biet");
            }
            if (result.Count > 0)
            {
                foreach(String s in result)
                {
                    Console.WriteLine($"{s}");
                }
            }
            else
            {
                Console.WriteLine("Hop le");
                Console.WriteLine(GenerateOTP());
            }
        }
        private bool IsValidEmail(string email)
        {
            // Regular expression để kiểm tra định dạng email
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        private bool ValidLengthPassword(string password)
        {
            if(password.Length >= 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ValidUpperCase(string password)
        {
            string pattern = @"[A-Z]";
            return Regex.IsMatch(password, pattern);
        }
        private bool ValidLowerCase(string password)
        {
            string pattern = @"[a-z]";
            return Regex.IsMatch(password, pattern);
        }
        private bool validNumber(string password)
        {
            string pattern = @"\d";
            return Regex.IsMatch(password, pattern);
        }
        private bool ValidSpecialCharacter(string password)
        {
            string pattern = @"[!@#$%^&*(),.?\:{ }|<>]";
            return Regex.IsMatch(password, pattern);
        }
        public  string GenerateOTP()
        {
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Random random = new Random();
            char[] result = new char[6];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = letters[random.Next(letters.Length)];
            }

            return new string(result);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator cal = new Calculator(5, 3);
            //Console.WriteLine(cal.Chia());
            //PhanSo a = new PhanSo(5, 8);
            //PhanSo b = new PhanSo(6, 7);
            //PhanSo c = a + b;
            //Console.WriteLine(c.ToString());
            Validate a = new Validate();
            a.Input();
            a.Login();
        }
    }
}