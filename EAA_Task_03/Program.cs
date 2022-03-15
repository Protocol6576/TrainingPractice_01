using System;

namespace EAA_Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            const string message = "hello world!";
            const string password = "123";

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Чтоб увидеть скрытое сообщение введите пароль (Попытка " + (i + 1) + "/3): ");

                string passInput = Console.ReadLine();
                if (passInput == password)
                {
                    Console.WriteLine("\nСкрытое сообщение: " + message);
                    Console.ReadLine();
                }

            }
        }
    }
}
