using System;

namespace EAA_Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 2, 3, 4, 5 };

            Console.Write("Старый массив: ");
            Concl(arr);

            Console.WriteLine("");

            shuffle(arr);
            Console.Write("Новый массив: ");
            Concl(arr);

            Console.ReadLine();

        }

        static void shuffle (int[] arr1)
        {
            Random rnd = new Random();

            for (int i = arr1.Length - 1; i >= 1; i--)
            {
                int j = rnd.Next(i + 1);
                int tmp = arr1[j];
                arr1[j] = arr1[i];
                arr1[i] = tmp;
            }
        }

        static void Concl (int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(arr[i] + ";");
            }
        }
    }
}
