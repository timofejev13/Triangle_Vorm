using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Vorm
{
    public class Triangle
    {
        public double a;
        public double b;
        public double c;
        public double ah;
        public double bh;
        public double ch;
        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }
        public Triangle()
        {
        }
        public Triangle(double A, double AH)
        {
            a = A;
            ah = AH;
        }
        public string outputA()
        {
            return Convert.ToString(a);
        }
        public string outputB()
        {
            return Convert.ToString(b);
        }
        public string outputC()
        {
            return Convert.ToString(c);
        }
        public string outputAH()
        {
            return Convert.ToString(ah);
        }

        public double Perimeter()
        {
            double p = 0;
            p = a + b + c;
            return p;
        }
        public double Surface()
        {
            double s = 0;
            double p = 0;
            p = (a + b + c)/2;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }
        public double Surface2()
        {
            double s = 0;
            s = Math.Sqrt(((a*ah)/2));
            return s;
        }
        public double GetSetA
        {
            get
            { return a; }
            set
            { a = value; }
        }
        public double GetSetB
        {
            get
            { return b; }
            set
            { b = value; }
        }
        public double GetSetC
        {
            get
            { return c; }
            set
            { c = value; }
        }
        public double GetSetAH
        {
            get
            { return ah; }
            set
            { ah = value; }
        }
        public bool ExistTriangle
        {
            get
            {
                if ((a < b + c) && (b < a + c) && (c < a + b))
                return true;
                else return false;

            }
        }
    }
}
