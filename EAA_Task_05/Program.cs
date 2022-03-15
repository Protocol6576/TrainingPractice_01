using System;

namespace EAA_Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            WorldInteraction make = new WorldInteraction();

            make.StatCreation();
            make.ShowMap();

            int bruh = 0;

            while (bruh == 0)
            {
                make.Stepment();
                bruh = make.Move();
            }

            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("((Вставить экран победы))");
        }
    }
}
