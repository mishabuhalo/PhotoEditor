﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor
{
    class SharpenFilter : ConvolutionFilters
    {
        public override string Filtername
        {
            get { return "SharpenFilter"; }
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
             new double[,] { { -1, -1, -1, },
                            { -1,  9, -1, },
                            { -1, -1, -1, }, };

        public override double[,] filterMatrix
        {
            get { return FilterMatrix; }
        }
    }

    class Sharpen3x3Filter : ConvolutionFilters
    {
        public override string Filtername
        {
            get { return "Sharpen3x3Filter"; }
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
             new double[,] { { 0,-1, 0, },
                            { -1, 5, -1, },
                            { 0,-1, 0, }, };

        public override double[,] filterMatrix
        {
            get { return FilterMatrix; }
        }
    }

    class Sharpen3x3FactorFilter : ConvolutionFilters
    {
        public override string Filtername
        {
            get { return "Sharpen3x3FactorFilter"; }
        }

        private double factor = 1.0/3.0;

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
             new double[,] { {  0, -2,  0, },
                            { -2, 11, -2, },
                            {  0, -2,  0, }, };

        public override double[,] filterMatrix
        {
            get { return FilterMatrix; }
        }
    }

    class Sharpen5x5Filter : ConvolutionFilters
    {
        public override string Filtername
        {
            get { return "Sharpen5x5Filter"; }
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
             new double[,] { { -1, -1, -1, -1, -1, },
                            { -1,  2,  2,  2, -1, },
                            { -1,  2,  8,  2,  1, },
                            { -1,  2,  2,  2, -1, },
                            { -1, -1, -1, -1, -1, }, };

        public override double[,] filterMatrix
        {
            get { return FilterMatrix; }
        }
    }

    class IntenseSharpenFilter : ConvolutionFilters
    {
        public override string Filtername
        {
            get { return "IntenseSharpenFilter"; }
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
             new double[,] { { 1,  1,  1, },
                            { 1, -7,  1, },
                            { 1,  1,  1, }, };

        public override double[,] filterMatrix
        {
            get { return FilterMatrix; }
        }
    }
}
