using System;
using System.Collections.Generic;
using pllug.Properties;


namespace pllug
{

    class MainClass
    {
        public static bool isRightSize(SquareDoor squareDoor ,RectangularObject rectangularObject)
        {
                if (rectangularObject.Height > squareDoor.Height)
                    return ((rectangularObject.Width < squareDoor.Width && rectangularObject.Depth < squareDoor.Height) ||
                            (rectangularObject.Width < squareDoor.Height && rectangularObject.Depth < squareDoor.Width));
                
                if (rectangularObject.Width > squareDoor.Width)
                    return rectangularObject.Width < squareDoor.Height && rectangularObject.Depth < squareDoor.Width;
            
                return true;
        }
        
        public static bool isRightSize(SquareDoor squareDoor, BarrelObject barrelObject )
        {
            if (barrelObject.Height > squareDoor.Height)
                return (barrelObject.Diameter < squareDoor.Width && barrelObject.Diameter < squareDoor.Height);

            if (barrelObject.Diameter > squareDoor.Width)
                return false;
            
            return true;
        }

        public static bool isRightSize(SquareDoor squareDoor, BallObject ballObject)
        {
            return squareDoor.Height > ballObject.Diameter && squareDoor.Width > ballObject.Diameter;
        }

        public static bool isRightSize(RoundDoor roundDoor, RectangularObject rectangularObject)
        {
            if (roundDoor.Diameter < rectangularObject.Height)
            {
                double diagonal =
                    Math.Sqrt(Math.Pow(rectangularObject.Width, 2) + Math.Pow(rectangularObject.Depth, 2));

                return roundDoor.Diameter > diagonal;
            }
            else
            {
                double diagonal =
                    Math.Sqrt(Math.Pow(rectangularObject.Width, 2) + Math.Pow(rectangularObject.Height, 2));

                return roundDoor.Diameter > diagonal;
            }
        }

        public static bool isRightSize(RoundDoor roundDoor, BarrelObject barrelObject)
        {
            if (roundDoor.Diameter < barrelObject.Height)
            {
                return roundDoor.Diameter > barrelObject.Diameter;
            }
            return true;
        }

        public static bool isRightSize(RoundDoor roundDoor, BallObject ballObject)
        {
            return roundDoor.Diameter > ballObject.Diameter;
        }

        public static void UserInterface()
        {

            Console.WriteLine("Enter the shape of a door. You can choose normal rectangular door or round door.");
            var doorChoice = Console.ReadLine();
            while (true)
            {
                if (doorChoice.ToLower() == "rectangular" || doorChoice.ToLower() == "round")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(
                        "Enter the shape of a door again. You can choose normal rectangular or round door.");
                    doorChoice = Console.ReadLine();
                }
            }

            Console.WriteLine("Enter Shape of Object");
            Console.WriteLine("Enter rectangle or barrel or ball");
            var objShape = Console.ReadLine();
            while (true)
            {
                if (objShape.ToLower() == "rectangle" || objShape.ToLower() == "barrel" || objShape.ToLower() == "ball")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter the shape of an object again. You can choose rectangle, barrel or ball.");
                    doorChoice = Console.ReadLine();
                }
            }


            if (doorChoice == "rectangular")
            {
                Console.WriteLine("Enter the size of door :");

                Console.WriteLine("Height : ");
                var input = Console.ReadLine();
                double height = double.Parse(input);

                Console.WriteLine("Width : ");
                input = Console.ReadLine();
                double width = double.Parse(input);

                var door = new SquareDoor(height, width);

                if (objShape == "rectangle")
                {
                    Console.WriteLine("Enter the size of Object :");
                    Console.WriteLine("Height : ");
                    input = Console.ReadLine();
                    height = double.Parse(input);

                    Console.WriteLine("Width : ");
                    input = Console.ReadLine();
                    width = double.Parse(input);

                    Console.WriteLine("Depth : ");
                    input = Console.ReadLine();
                    var depth = double.Parse(input);

                    var obj = new RectangularObject(height, width, depth);

                    Console.WriteLine(isRightSize(door, obj) ? "Everything is ok" : "Object is bigger");
                }
                else if (objShape == "barrel")
                {
                    Console.WriteLine("Enter the size of Object :");
                    Console.WriteLine("Height : ");
                    input = Console.ReadLine();
                    height = double.Parse(input);

                    Console.WriteLine("Diameter : ");
                    input = Console.ReadLine();
                    double diameter = double.Parse(input);

                    var obj = new BarrelObject(height, diameter);
                    
                    Console.WriteLine(isRightSize(door, obj) ? "Everything is ok" : "Object is bigger");

                }
                else
                {
                    Console.WriteLine("Enter the size of Object :");
                    Console.WriteLine("Diameter : ");
                    input = Console.ReadLine();
                    double diameter = double.Parse(input);
                    
                    var obj = new BallObject(diameter);

                    Console.WriteLine(isRightSize(door, obj) ? "Everything is ok" : "Object is bigger");
                }
            }
            else
            {
                Console.WriteLine("Enter the size of door :");
                Console.WriteLine("Diameter: ");
                var input = Console.ReadLine();
                double diameter = double.Parse(input);
                var door = new RoundDoor(diameter);

                if (objShape == "rectangle")
                {
                    Console.WriteLine("Enter the size of Object :");
                    Console.WriteLine("Height : ");
                    input = Console.ReadLine();
                    var height = double.Parse(input);

                    Console.WriteLine("Width : ");
                    input = Console.ReadLine();
                    var width = double.Parse(input);

                    Console.WriteLine("Depth : ");
                    input = Console.ReadLine();
                    var depth = double.Parse(input);

                    var obj = new RectangularObject(height, width, depth);
                    
                    Console.WriteLine(isRightSize(door, obj) ? "Everything is ok" : "Object is bigger");
                }
                
                else if (objShape == "barrel")
                {
                    Console.WriteLine("Enter the size of Object :");
                    Console.WriteLine("Height : ");
                    input = Console.ReadLine();
                    double height = double.Parse(input);

                    Console.WriteLine("Diameter : ");
                    input = Console.ReadLine();
                    diameter = double.Parse(input);

                    var obj = new BarrelObject(height, diameter);
                    
                    Console.WriteLine(isRightSize(door, obj) ? "Everything is ok" : "Object is bigger");
                }
                else
                {
                    Console.WriteLine("Enter the size of Object :");
                    Console.WriteLine("Diameter : ");
                    input = Console.ReadLine();
                    diameter = double.Parse(input);
                    
                    var obj = new BallObject(diameter);

                    Console.WriteLine(isRightSize(door, obj) ? "Everything is ok" : "Object is bigger");
                }
                
            }
        }

        public static void Main(string[] args)
        {
            UserInterface();
        }
    }
}
