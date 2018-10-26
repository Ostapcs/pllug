using System;

namespace pllug
{
    class RoundDoor : AbstractDoor
    {
        public double Diameter { get; private set; }

        public RoundDoor(double diameter )
        {
            Diameter = diameter;
        }
        
        public override bool isRightSize(AbstractObject abstractObject)
        {
            var amountProperties = MainClass.GetPropertyCount(abstractObject);

            switch (amountProperties)
            {
                case 1:
                    if (Diameter < abstractObject.Height)
                    {
                        var diagonal =
                            Math.Sqrt(Math.Pow(abstractObject.Width, 2) + Math.Pow(abstractObject.Depth, 2));

                        return Diameter > diagonal;
                        
                    }
                    
                    if (Diameter < abstractObject.Width)
                    {
                        var diagonal =
                            Math.Sqrt(Math.Pow(abstractObject.Height, 2) + Math.Pow(abstractObject.Depth, 2));
                        
                        return Diameter > diagonal;   
                    }
                    else
                    {                  
                        var diagonal =
                            Math.Sqrt(Math.Pow(abstractObject.Width, 2) + Math.Pow(abstractObject.Height, 2));
                            
                        return Diameter > diagonal;
                        
                    }  
                case 2:
                    
                    return Diameter > abstractObject.Diameter;
                case 3:
                    
                    return Diameter > abstractObject.Diameter;
            }

            return false;
        }

    }
}