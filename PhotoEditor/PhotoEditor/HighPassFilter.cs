using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor
{
    class HighPassFilter : ConvolutionFilters
    {
        public override string Filtername
        {
            get { return "HighPassFilter"; }
        }

        private double factor = 1.0/16.0;

        public override double Factor
        {
            get { return factor; }
        }

        private double bias = 128.0;

        public override double Bias
        {
            get { return bias; }
        }

        private double[,] FilterMatrix =
              new double[,] { { -1, -2, -1, },
                            { -2, 12, -2, },
                            { -1, -2, -1, }, };


        public override double[,] filterMatrix
        {
            get { return FilterMatrix; }
        }
    }
}
