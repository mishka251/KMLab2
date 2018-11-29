using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMLab2
{
    class ResultValues
    {
        public double I;
        public List<double> y;
        public List<double> x;
        public List<double> u;
        public double d;
        public double sigma;
        public double I_min;
        public double I_max;

        public ResultValues()
        {

        }

        public ResultValues(double i, List<double> x, List<double> u, double d, double sigma, double i_min, double i_max)
        {
            I = i;
            this.x = x ?? throw new ArgumentNullException(nameof(x));
            this.u = u ?? throw new ArgumentNullException(nameof(u));
            this.d = d;
            this.sigma = sigma;
            I_min = i_min;
            I_max = i_max;
        }
    }
}
