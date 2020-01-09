using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor
{
    public abstract class ConvolutionFilters
    {
        public abstract string Filtername { get; }

        public abstract double Factor { get; }

        public abstract double Bias { get; }

        public abstract double[,] filterMatrix { get; }
    }
}
