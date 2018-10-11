namespace pllug
{
    class BarrelObject
    {
        

        public double Height { get; private set; }
        public double Diameter { get; private set; }
        public BarrelObject(double h,double d)
        {
            Height = h;
            Diameter = d;
        }
    }
}