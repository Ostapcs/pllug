using System;


namespace pllug
{
    class UserInterface
    {

        public static double[] InputRectangularDoor()
        {
            Console.WriteLine("Enter the size of door :");

            Console.WriteLine("Height : ");
            var input = Console.ReadLine();
            double height = double.Parse(input);

            Console.WriteLine("Width : ");
            input = Console.ReadLine();
            double width = double.Parse(input);

            return new[] {height, width};
        }

        public static double InputRoundDoor()
        {
            Console.WriteLine("Enter the size of door :");
            Console.WriteLine("Diameter: ");
            var input = Console.ReadLine();
            var diameter = double.Parse(input);
            return diameter;
        }

        public static double[] InputRectangularObject()
        {
            Console.WriteLine("Enter the size of Object :");
            Console.WriteLine("Height : ");
            var input = Console.ReadLine();
            var height = double.Parse(input);

            Console.WriteLine("Width : ");
            input = Console.ReadLine();
            var width = double.Parse(input);

            Console.WriteLine("Depth : ");
            input = Console.ReadLine();
            var depth = double.Parse(input);

            return new[] {height, width, depth};
        }

        public static double[] InputBarrelObject()
        {
            Console.WriteLine("Enter the size of Object :");
            Console.WriteLine("Height : ");
            var input = Console.ReadLine();
            var height = double.Parse(input);

            Console.WriteLine("Diameter : ");
            input = Console.ReadLine();
            var diameter = double.Parse(input);

            return new[] {height, diameter};
        }

        public static double InputBallObject()
        {
            Console.WriteLine("Enter the size of Object :");
            Console.WriteLine("Diameter : ");
            var input = Console.ReadLine();
            var diameter = double.Parse(input);

            return diameter;
        }

        public static void usrinterface()
        {

            Console.WriteLine("Enter the shape of a door. You can choose normal rectangular door or round door.");
            AbstractDoor door;
            var doorChoice = Console.ReadLine();
            while (true)
            {
                if (doorChoice.ToLower() == "rectangular")
                {

                    var res = InputRectangularDoor();
                    door = new SquareDoor(res[0], res[1]);
                    break;
                }
                else if (doorChoice.ToLower() == "round")
                {
                    var res = InputRoundDoor();
                    door = new RoundDoor(res);
                    break;
                }
                else
                {
                    Console.WriteLine(
                        "Enter the shape of a door again. You can choose normal rectangular or round door.");
                    doorChoice = Console.ReadLine();

                }
            }



            Console.WriteLine("Enter Shape of Object: rectangle, barrel or ball");
            AbstractObject abstractObject;
            var objShape = Console.ReadLine();
            while (true)
            {

                if (objShape == "rectangle")
                {
                    var res = InputRectangularObject();
                    abstractObject = new RectangularObject(res[0], res[1], res[2]);

                    break;
                }

                if (objShape == "barrel")
                {
                    var res = InputBarrelObject();
                    abstractObject = new BarrelObject(res[0], res[1]);
                    break;
                }

                if (objShape == "ball")
                {
                    var res = InputBallObject();
                    abstractObject = new BallObject(res);
                    break;
                }
                else
                {
                    Console.WriteLine("Enter the shape of an object again. You can choose rectangle, barrel or ball.");
                    objShape = Console.ReadLine();
                }
            }

            Console.WriteLine(door.isRightSize(abstractObject));

        }
    }
}