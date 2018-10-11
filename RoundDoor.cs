using System;

namespace pllug
{
    class RoundDoor : AbstractDoor
    {
        public RoundDoor(double diameter) : base(diameter)
        {
            
        }

        public override bool isRightSize(RectangularObject rectangularObject)
        {
            if (Diameter < rectangularObject.Height)
            {
                double diagonal =
                    Math.Sqrt(Math.Pow(rectangularObject.Width, 2) + Math.Pow(rectangularObject.Depth, 2));

                return Diameter > diagonal;
            }
            if (Diameter < rectangularObject.Width)
            {
                double diagonal =
                    Math.Sqrt(Math.Pow(rectangularObject.Height, 2) + Math.Pow(rectangularObject.Depth, 2));

                return Diameter > diagonal;
            }
            else
            {
                double diagonal =
                    Math.Sqrt(Math.Pow(rectangularObject.Width, 2) + Math.Pow(rectangularObject.Height, 2));

                return Diameter > diagonal;
            }        
        }

        public override bool isRightSize(BarrelObject barrelObject)
        {
            return Diameter > barrelObject.Diameter;
            
        }

        public override bool isRightSize(BallObject ballObject)
        {
            return Diameter > ballObject.Diameter;
        }
    }
}