using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.TestModel
{
    public class PhanSo
    {
        private int tuso, mauso;
        public PhanSo(int tu, int mau)
        {
                if (mau == 0)
                {
                    throw new DivideByZeroException();
                }
                tuso = tu;
                mauso = mau;
                Rutgon();
        }
        public void Rutgon()
        {

            int ucln = gcd(tuso, mauso);
            this.tuso /= ucln;
            this.mauso /= ucln;
        }
        public int gcd(int a, int b)
        {
            if (b == 0) return a;
            return gcd(b, a % b);
        }
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            int mauso = a.mauso * b.mauso;
            int tuso = a.tuso * b.mauso + b.tuso * a.mauso;
            
            return new PhanSo(tuso,mauso);
        }
        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            int mauso = a.mauso + b.mauso;
            int tuso = a.tuso * b.mauso - b.tuso * a.mauso;
            
            return new PhanSo(tuso,mauso);
        }
        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            int tuso = a.tuso * b.tuso;
            int mauso = a.mauso * b.mauso;
            return new PhanSo(tuso, mauso);
        }
        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            int tuso = a.tuso * b.mauso;
            int mauso = a.mauso * b.tuso;

            return new PhanSo(tuso, mauso);
        }
        public override string ToString()
        {
            return $"{this.tuso}/{this.mauso}";
        }

    }
}
