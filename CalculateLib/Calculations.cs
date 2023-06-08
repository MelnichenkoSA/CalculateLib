using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLib
{
    public class Calculations
    {
        static public List<double> CalculateSumSeries(double x, double eps)
        {
            List<double> A = new List<double>();
            List<double> S = new List<double>();
            double a = 1;
            double s = 1;
            for(int i = 1; i <= eps; i++)
            {
                a = (a * x) / i;
                A.Add(a);
                s += a;
                S.Add(s);
            }
            //Ебни-ка массив дружище
            return A;
        }
    }
}
