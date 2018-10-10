using System;
namespace pllug
{
    class RectangularObject
    {
        public double Height { get; private set; }
        public double Width { get; private set; }
        public double Depth { get; private set; }

        public RectangularObject(double h, double w,double d)
        {
            Height = h;
            Width = w;
            Depth = d;
        }
    }
}
