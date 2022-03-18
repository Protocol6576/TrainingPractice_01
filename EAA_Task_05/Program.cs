using System;

namespace EAA_Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            WorldInteraction make = new WorldInteraction();

            make.StatCreation();
            make.AddEnemy();
            make.ShowMap();
            make.ShowHP();

            int bruh = 0;

            while (bruh == 0)
            {
                make.Stepment();
                bruh = make.Move();
            }

            Console.Clear();
            Console.SetCursorPosition(0, 0);

            if (bruh == 1)
                Console.WriteLine("// Вы победили! //");
            else
                Console.WriteLine("// Вы проиграли! //");
        }
    }
}
