using System;
//Напишіть програму, котра буде перевіряти, чи можливо пронести шафу/холодильник через отвір дверей! Вибір варіанту реалізації за Вами.

namespace pllug
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Door a = new Door(2, 3);
            System.Console.WriteLine(a.Height);
            System.Console.WriteLine(a.Width);
            a.Height = 4;
            a.Width = 5;
            System.Console.WriteLine(a.Height);
            System.Console.WriteLine(a.Width);
        }
    }
}
