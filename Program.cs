using System;
//Напишіть програму, котра буде перевіряти, чи можливо пронести шафу/холодильник через отвір дверей! Вибір варіанту реалізації за Вами.

namespace pllug
{

    class MainClass
    {


        public static bool isRightSize(Door door,Object obj)
        {
            if (obj.Height < door.Height && obj.Width < door.Width)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the size of door :");

            System.Console.WriteLine("Height : ");
            string input  = System.Console.ReadLine();
            double height = double.Parse(input);

            System.Console.WriteLine("Width : ");
            input = System.Console.ReadLine();
            double width = double.Parse(input);
           
            Door door = new Door(height,width);

            System.Console.WriteLine("Enter the size of Object :");
            System.Console.WriteLine("Height : ");
            input = System.Console.ReadLine();
            height = double.Parse(input);

            System.Console.WriteLine("Width : ");
            input = System.Console.ReadLine();
            width = double.Parse(input);

            Object obj = new Object(height, width);

            if (isRightSize(door,obj))
            {
                System.Console.WriteLine("Everything is ok");
            }
            else
            {
                System.Console.WriteLine("Your Object is to big for your doors ");
            }

        }
    }
}
