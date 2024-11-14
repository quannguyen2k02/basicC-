using BasicC_.TestModel;
using System;
using System.Collections;
using System.Text;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator cal = new Calculator(5, 3);
            //Console.WriteLine(cal.Chia());
            PhanSo a = new PhanSo(5, 0);
            PhanSo b = new PhanSo(6, 7);
            PhanSo c = a + b;
            Console.WriteLine(c);
            //Validate a = new Validate();
            //a.Input();
            //var result = a.Login();
            //var ListResult = result.Item3;
            //Console.WriteLine(result.Item1);
            //Console.WriteLine($"OTP:{result.Item2}");
            //foreach(var i in ListResult) { Console.WriteLine(i); }

            //var testResult = a.Tesst();
            //Console.WriteLine($"{testResult.Item1} : {testResult.Item2}");

            //var b = new StringBuilder();
            //b.Append("hello");
            //b.Append("5");
            //Console.WriteLine(b.ToString());
        }
    }
}