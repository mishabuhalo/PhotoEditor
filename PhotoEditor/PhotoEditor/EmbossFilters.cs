using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor
{
    class EmbossFilter : ConvolutionFilters
    {
        public override string Filtername
        {
            get { return "EmbossFilter"; }
        }

        private double factor = 1.0;

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
             new double[,] { { 2, 0, 0, },
                            { 0,-1, 0, },
                            { 0, 0,-1, }, };

        public override double[,] filterMatrix
        {
            get { return FilterMatrix; }
        }
    }

    class Emboss45DegreeFilter : ConvolutionFilters
    {
        public override string Filtername
        {
            get { return "Emboss45DegreeFilter"; }
        }

        private double factor = 1.0;

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
             new double[,] { { -1, -1, 0, },
                            { -1,  0, 1, },
                            {  0,  1, 1, }, };

        public override double[,] filterMatrix
        {
            get { return FilterMatrix; }
        }
    }

    class EmbossTopLeftBottomRightFilter : ConvolutionFilters
    {
        public override string Filtername
        {
            get { return "EmbossTopLeftBottomRightFilter"; }
        }

        private double factor = 1.0;

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
              new double[,] { { -1, 0, 0, },
                            {  0, 0, 0, },
                            {  0, 0, 1, }, };

        public override double[,] filterMatrix
        {
            get { return FilterMatrix; }
        }
    }

    class IntenseEmbossFilter : ConvolutionFilters
    {
        public override string Filtername
        {
            get { return "IntenseEmbossFilter"; }
        }

        private double factor = 1.0;

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
              new double[,] { { -1, -1, -1, -1,  0, },
                            { -1, -1, -1,  0,  1, },
                            { -1, -1,  0,  1,  1, },
                            { -1,  0,  1,  1,  1, },
                            {  0,  1,  1,  1,  1, }, };


        public override double[,] filterMatrix
        {
            get { return FilterMatrix; }
        }
    }
}
