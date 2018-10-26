using System;
using System.Reflection;

//рефлекція try catch 
namespace pllug
{
    class SquareDoor : AbstractDoor
    {
        public double Height { get; private set; }
        public double Width { get; private set; }

        public SquareDoor(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public override bool isRightSize(AbstractObject abstractObject)
        {
            var amountProperties = MainClass.GetPropertyCount(abstractObject);
            
            switch (amountProperties)
            {
                case 1:
                    if (abstractObject.Height >= Height)
                    {
                        return ((abstractObject.Width < Width && abstractObject.Depth < Height) ||
                                (abstractObject.Width < Height && abstractObject.Depth < Width));
                    }

                    if (abstractObject.Width >= Width)
                    {
                        return (abstractObject.Width < Height || abstractObject.Depth < Width);
                    }

                    return true;

                case 2:
                    return (abstractObject.Diameter < Width);

                case 3:
                    return Height > abstractObject.Diameter && Width > abstractObject.Diameter;

            }

            return false;
        }
    }


}

