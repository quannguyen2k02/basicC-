using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.TestModel
{
    class Calculator
    {
        public double a { set; get; }
        public double b { set; get; }
        public Calculator(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double Cong()
        {
            return a + b;
        }
        public double Tru()
        {
            return a - b;
        }
        public double Nhan()
        {
            return a * b;
        }
        public double Chia()
        {
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException();
                }
                else
                {
                    return a / b;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 0;
            }
        }
    }
}
