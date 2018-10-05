using System;
namespace pllug
{
    class Object
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

        public Object(double h, double w)
        {
            Height = h;
            Width = w;
        }
    }
}
