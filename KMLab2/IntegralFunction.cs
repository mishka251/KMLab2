using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMLab2
{

    public delegate double Func(double x);

    class IntegralFunction
    {
        public IntegralFunction()
        {

        }

        public IntegralFunction(Func func, double a, double b)
        {
            this.func = func ?? throw new ArgumentNullException(nameof(func));
            this.a = a;
            this.b = b;
        }

        public  Func func;
        public double a { get; set; }
        public double b { get; set; }
    }
}
