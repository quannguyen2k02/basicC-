using System;
using System.Collections;

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
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator cal = new Calculator(5, 3);
            //Console.WriteLine(cal.Chia());
            PhanSo a = new PhanSo(5, 8);
            PhanSo b = new PhanSo(6, 7);
            PhanSo c = a + b;
            Console.WriteLine(c.ToString());
        }
    }
}