using System;
namespace pllug
{
    class SquareDoor
    {
        public double Height { get; private set; }
        public double Width { get; private set; }

        public SquareDoor()
        {
            
        }

        public SquareDoor(double h, double w)
        {
            Height = h;
            Width = w;
        }
    }
}
