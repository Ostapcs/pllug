using System;

namespace pllug
{
    abstract class AbstractObject
    {
        public double Height { get;  set; }
        public double Width { get;  set; }
        public double Depth { get;  set; }
        public double Diameter { get;  set; }

        protected AbstractObject()
        {
            Height = double.NaN;
            Width = double.NaN;
            Depth = double.NaN;
            Diameter = double.NaN;
        }
    }
}