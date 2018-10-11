namespace pllug
{
     class AbstractDoor
    {
        protected  double Height { get;}
        protected  double Width { get;}
        protected  double Diameter { get;}

        public virtual bool isRightSize( RectangularObject rectangularObject)
        {
            return true;
        }

        public virtual bool isRightSize( BarrelObject barrelObject)
        {
            return true;
        }

        public virtual bool isRightSize(BallObject ballObject)
        {
            return true;
        }
        protected AbstractDoor(double height, double width)// для квадратних
        {
            Height = height;
            Width = width;
        }
        
        protected AbstractDoor(double diameter)// для круглих
        {
            Diameter = diameter;
        }     
    }
}