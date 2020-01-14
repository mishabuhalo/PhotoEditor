using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor
{
    class EdgeDetectionFilter : ConvolutionFilters
    {
        public override string Filtername
        {
            get { return "EdgeDetecionFilter"; }
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
                            { -1,  8, -1, },
                            { -1, -1, -1, }, };

        public override double[,] filterMatrix
        {
            get { return FilterMatrix; }
        }

    }

    class EdgeDetection45DegreeFilter : ConvolutionFilters
    {
        public override string Filtername
        {
            get { return "EdgeDetection45DegreeFilter"; }
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
            new double[,] { { -1,  0,  0,  0,  0, },
                            {  0, -2,  0,  0,  0, },
                            {  0,  0,  6,  0,  0, },
                            {  0,  0,  0, -2,  0, },
                            {  0,  0,  0,  0, -1, }, };

        public override double[,] filterMatrix
        {
            get { return FilterMatrix; }
        }

    }

    class HorizontalEdgeDetectionFilter : ConvolutionFilters
    {
        public override string Filtername
        {
            get { return "HorizontalEdgeDetectionFilter"; }
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
            new double[,] { {  0,  0,  0,  0,  0, },
                            {  0,  0,  0,  0,  0, },
                            { -1, -1,  2,  0,  0, },
                            {  0,  0,  0,  0,  0, },
                            {  0,  0,  0,  0,  0, }, };

        public override double[,] filterMatrix
        {
            get { return FilterMatrix; }
        }

    }

    class VerticalEdgeDetectionFilter : ConvolutionFilters
    {
        public override string Filtername
        {
            get { return "VerticalEdgeDetectionFilter"; }
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
            new double[,] { {  0,  0, -1,  0,  0, },
                            {  0,  0, -1,  0,  0, },
                            {  0,  0,  4,  0,  0, },
                            {  0,  0, -1,  0,  0, },
                            {  0,  0, -1,  0,  0, }, };

        public override double[,] filterMatrix
        {
            get { return FilterMatrix; }
        }

    }


    class EdgeDetectionTopLeftBottomRightFilter : ConvolutionFilters
    {
        public override string Filtername
        {
            get { return "EdgeDetectionTopLeftBottomRightFilter"; }
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
            new double[,] { { -5,  0,  0, },
                            {  0,  0,  0, },
                            {  0,  0,  5, }, };

        public override double[,] filterMatrix
        {
            get { return FilterMatrix; }
        }

    }
}
