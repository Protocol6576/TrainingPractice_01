using System;

namespace EAA_Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stay = true;
            int count = 0;
            while (stay)
            {
                count++;

                Console.WriteLine("\nПрогон №" + count + ". Напиште << exit >> для выхода из цикла.");
                Console.Write("|| ");

                string action = Console.ReadLine();
                if (action == "exit")
                    stay = false;

                Console.WriteLine("\n***");
            }

            Console.WriteLine("\nВы вышли из цикла! Количество прогонов: " + count);
            Console.ReadLine();
        }
    }
}
