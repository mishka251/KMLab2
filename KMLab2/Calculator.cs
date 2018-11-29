using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMLab2
{
    class Calculator
    {
        (List<double> u, List<double> x, List<double> y, double mid) CalcInt(IntegralFunction f, int n)
        {
            double I = 0;
            Random r = new Random();
            List<double> u_l = new List<double>();
            List<double> x = new List<double>();
            List<double> y = new List<double>();
            for (int i = 0; i < n; i++)
            {
                var u = r.NextDouble();
                double xi = f.a + (f.b - f.a) * u;
                var yi = f.func(xi);

                I += yi;

                u_l.Add(u);
                x.Add(xi);
                y.Add(yi);
            }
            return (u_l, x, y, (f.b - f.a) * I / n);
        }



        double Dispersion(List<double> l, double I)
        {
            double sum = 0;
           
            for (int i = 0; i < l.Count; i++)
                sum += (l[i] - I) * (l[i] - I);
            return sum / (l.Count - 1);
        }


        public ResultValues CalculateAll(IntegralFunction int_f, int n)
        {
            (var u_l, var x, var y,double I) = CalcInt(int_f, n);
            ResultValues res = new ResultValues();
            res.u = u_l;
            res.x = x;
            res.y = y;
            res.I = I;

            res.d = Dispersion(y, I);
            res.sigma = Math.Sqrt(res.d);
            (res.I_min, res.I_max) = Interval(n, I, res.d);

            return res;
        }
        public double err(double I, double realVal)
        {
            return Math.Abs(I - realVal);
        }
        public (double I_min, double I_max) Interval( int n, double I, double d)
        {          
            const double z = 1.96;
            double I_min = I - z * Math.Sqrt(d / n);
            double I_max = I + z * Math.Sqrt(d / n);
            return (I_min, I_max);
        }
    }
}
