using System;


namespace pllug
{
    class UserInterface
    {
        

        public static void usrinterface()
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
                    continue;
                    
                }
            }

            Console.WriteLine("Enter Shape of Object: rectangle, barrel or ball");
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
                    objShape = Console.ReadLine();
                    continue;
                    
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

                    Console.WriteLine(door.isRightSize(obj)  ? "Everything is ok" : "Object is bigger");
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
                    
                    Console.WriteLine(door.isRightSize(obj) ? "Everything is ok" : "Object is bigger");

                }
                else
                {
                    Console.WriteLine("Enter the size of Object :");
                    Console.WriteLine("Diameter : ");
                    input = Console.ReadLine();
                    double diameter = double.Parse(input);
                    
                    var obj = new BallObject(diameter);

                    Console.WriteLine(door.isRightSize(obj) ? "Everything is ok" : "Object is bigger");
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
                    
                    Console.WriteLine(door.isRightSize(obj) ? "Everything is ok" : "Object is bigger");
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
                    
                    Console.WriteLine(door.isRightSize(obj) ? "Everything is ok" : "Object is bigger");
                }
                else
                {
                    Console.WriteLine("Enter the size of Object :");
                    Console.WriteLine("Diameter : ");
                    input = Console.ReadLine();
                    diameter = double.Parse(input);
                    
                    var obj = new BallObject(diameter);

                    Console.WriteLine(door.isRightSize(obj) ? "Everything is ok" : "Object is bigger");
                }
                
            }
        }
    }
}