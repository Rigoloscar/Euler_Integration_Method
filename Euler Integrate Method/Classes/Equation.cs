using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Equation
    {
        string entry;
        double h;
        int NPoints;
        double Yo;
        double Xo;
        Pointt[] points;

        public void GetData(double h, int npoints, double x, double y)
        {
            //this.entry = entry;
            this.h = h;
            this.NPoints = npoints;
            this.Xo = x;
            this.Yo = y;
        }

        public Pointt[] ReturnData()
        {
            return this.points;
        }

        public void Compute()
        {
            double X = this.Xo;
            double Y = this.Yo;
            this.points = new Pointt[this.NPoints];

            for (int i = 0; i < NPoints; i++)
            {
                X = X + this.h;
                Y = Y + this.h * (1/X); // función de la forma  Y = Y + this.h * f(y,x)
                this.points[i] = new Pointt(X, Y);
            }
        }
    }
}
