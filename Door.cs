using System;
namespace pllug
{
    class Door
    {
        private double height;
        private double width;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public Door(double h, double w)
        {
            Height = h;
            Width = w;
        }
    }
}
