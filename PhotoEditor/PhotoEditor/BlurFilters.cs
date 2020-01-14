using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor
{
    class Blur3x3Filter : ConvolutionFilters
    {
        public override string Filtername
        {
            get { return "Blur3x3Filter"; }
        }

        private double factor = 1.0;

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
            new double[,] { { 0.0, 0.2, 0.0, },
                            { 0.2, 0.2, 0.2, },
                            { 0.0, 0.2, 0.2, }, };

        public override double[,] filterMatrix
        {
            get { return FilterMatrix; }
        }

    }

    class Blur5x5Filter : ConvolutionFilters
    {
        public override string Filtername
        {
            get { return "Blur5x5Filter"; }
        }

        private double factor = 1.0 / 13.0;

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
            new double[,] { { 0, 0, 1, 0, 0, },
                            { 0, 1, 1, 1, 0, },
                            { 1, 1, 1, 1, 1, },
                            { 0, 1, 1, 1, 0, },
                            { 0, 0, 1, 0, 0, }, };

        public override double[,] filterMatrix
        {
            get { return FilterMatrix; }
        }
    }

    class Gaussian3x3BlurFilter : ConvolutionFilters
    {
        public override string Filtername
        {
            get { return "Gaussian3x3BlurFilter"; }
        }

        private double factor = 1.0 / 16.0;

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
             new double[,] { { 1, 2, 1, },
                            { 2, 4, 2, },
                            { 1, 2, 1, }, };

        public override double[,] filterMatrix
        {
            get { return FilterMatrix; }
        }
    }

    class Gaussian5x5BlurFilter : ConvolutionFilters
    {
        public override string Filtername
        {
            get { return "Gaussian5x5BlurFilter"; }
        }

        private double factor = 1.0 / 159.0;

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
             new double[,] { { 2, 04, 05, 04, 2 },
                            { 4, 09, 12, 09, 4 },
                            { 5, 12, 15, 12, 5 },
                            { 4, 09, 12, 09, 4 },
                            { 2, 04, 05, 04, 2 }, };

        public override double[,] filterMatrix
        {
            get { return FilterMatrix; }
        }
    }

    class MotionBlurFilter : ConvolutionFilters
    {
        public override string Filtername
        {
            get { return "MotionBlurFilter"; }
        }

        private double factor = 1.0 / 18.0;

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
            new double[,] { {1, 0, 0, 0, 0, 0, 0, 0, 1,},
                            {0, 1, 0, 0, 0, 0, 0, 1, 0,},
                            {0, 0, 1, 0, 0, 0, 1, 0, 0,},
                            {0, 0, 0, 1, 0, 1, 0, 0, 0,},
                            {0, 0, 0, 0, 1, 0, 0, 0, 0,},
                            {0, 0, 0, 1, 0, 1, 0, 0, 0,},
                            {0, 0, 1, 0, 0, 0, 1, 0, 0,},
                            {0, 1, 0, 0, 0, 0, 0, 1, 0,},
                            {1, 0, 0, 0, 0, 0, 0, 0, 1,}, };

        public override double[,] filterMatrix
        {
            get { return FilterMatrix; }
        }
    }

    class MotionBlurLeftToRightFilter : ConvolutionFilters
    {
        public override string Filtername
        {
            get { return "MotionBlurLeftToRightFilter"; }
        }

        private double factor = 1.0 / 9.0;

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
            new double[,] { {1, 0, 0, 0, 0, 0, 0, 0, 0,},
                            {0, 1, 0, 0, 0, 0, 0, 0, 0,},
                            {0, 0, 1, 0, 0, 0, 0, 0, 0,},
                            {0, 0, 0, 1, 0, 0, 0, 0, 0,},
                            {0, 0, 0, 0, 1, 0, 0, 0, 0,},
                            {0, 0, 0, 0, 0, 1, 0, 0, 0,},
                            {0, 0, 0, 0, 0, 0, 1, 0, 0,},
                            {0, 0, 0, 0, 0, 0, 0, 1, 0,},
                            {0, 0, 0, 0, 0, 0, 0, 0, 1,}, };

        public override double[,] filterMatrix
        {
            get { return FilterMatrix; }
        }
    }

    class MotionBlurRightToLeftFilter : ConvolutionFilters
    {
        public override string Filtername
        {
            get { return "MotionBlurRightToLeftFilter"; }
        }

        private double factor = 1.0 / 9.0;

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
           new double[,] { {0, 0, 0, 0, 0, 0, 0, 0, 1,},
                            {0, 0, 0, 0, 0, 0, 0, 1, 0,},
                            {0, 0, 0, 0, 0, 0, 1, 0, 0,},
                            {0, 0, 0, 0, 0, 1, 0, 0, 0,},
                            {0, 0, 0, 0, 1, 0, 0, 0, 0,},
                            {0, 0, 0, 1, 0, 0, 0, 0, 0,},
                            {0, 0, 1, 0, 0, 0, 0, 0, 0,},
                            {0, 1, 0, 0, 0, 0, 0, 0, 0,},
                            {1, 0, 0, 0, 0, 0, 0, 0, 0,}, };

        public override double[,] filterMatrix
        {
            get { return FilterMatrix; }
        }
    }
}
