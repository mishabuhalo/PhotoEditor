using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor
{
    class SoftenFilter :ConvolutionFilters
    {
        public override string Filtername
        {
            get { return "SoftenFilter"; }
        }

        private double factor = 1.0 / 8.0;

        public override double Factor
        {
            get { return factor; }
        }

        private double bias = 0.0;

        public override double Bias
        {
            get { return bias; }
        }

        private double[,] FilterMatrix =
             new double[,] { { 1, 1, 1, },
                            { 1, 1, 1, },
                            { 1, 1, 1, }, };

        public override double[,] filterMatrix
        {
            get { return FilterMatrix; }
        }
    }
}
