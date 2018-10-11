using System;
namespace pllug
{
    class SquareDoor : AbstractDoor
    {
        public SquareDoor(double height, double width) : base(height, width)
        {
            
        }
        

        public override bool isRightSize (RectangularObject rectangularObject)
        {
            if (rectangularObject.Height >= Height)
                return ((rectangularObject.Width < Width && rectangularObject.Depth < Height) ||
                        (rectangularObject.Width < Height && rectangularObject.Depth < Width));

            if (rectangularObject.Width >= Width)
                return (rectangularObject.Width < Height || rectangularObject.Depth < Width);
            
            return true;
        }

        public override bool isRightSize(BarrelObject barrelObject)
        {
            return (barrelObject.Diameter < Width);
        }

        public override bool isRightSize(BallObject ballObject)
        {
            return Height > ballObject.Diameter && Width > ballObject.Diameter;        }

        
    }
}
