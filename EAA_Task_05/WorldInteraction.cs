using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAA_Task_05
{
    class WorldInteraction
    {
        char[,] map = new char[100, 100];
        int[] position = new int[2] { 1, 1 };
        int[] futPosition = new int[2] { 1, 1 };
        int[,] orient = new int[4, 2] { { 0, -1 }, { 1, 0 }, { 0, 1 }, { -1, 0 } };
        int dir = 1;
        char charModel = '▲';
        string step;
        ConsoleKeyInfo key;
        int size = 29;

        public void chekDir()
        {
            switch (dir)
            {
                case 0:
                    charModel = '◄';
                    break;
                case 1:
                    charModel = '▲';
                    break;
                case 2:
                    charModel = '►';
                    break;
                case 3:
                    charModel = '▼';
                    break;
            }
        }

        public void Stepment()
        {
            key = Console.ReadKey();
            step = key.Key.ToString();
            switch (step)
            {
                case "W":
                    futPosition[0] -= orient[dir, 0];
                    futPosition[1] += orient[dir, 1];
                    break;
                case "S":
                    futPosition[0] += orient[dir, 0];
                    futPosition[1] -= orient[dir, 1];
                    break;
                case "A":
                    dir = (dir + 4 - 1) % 4;
                    chekDir();
                    break;
                case "D":
                    dir = (dir + 4 + 1) % 4;
                    chekDir();
                    break;

            }
        }

        public int Move()
        {
            int exit = 0;

            Console.SetCursorPosition(position[1], position[0] + 1);
            Console.Write(map[position[0], position[1]]);

            switch (map[futPosition[0], futPosition[1]])
            {

                case '█':
                    futPosition[0] = position[0];
                    futPosition[1] = position[1];
                    break;
                case ' ':
                    position[0] = futPosition[0];
                    position[1] = futPosition[1];
                    break;
                case '$':
                    position[0] = futPosition[0];
                    position[1] = futPosition[1];
                    exit = 1;
                    break;

            }

            Console.SetCursorPosition(position[1], position[0] + 1);
            Console.Write(charModel);

            Console.SetCursorPosition(size, size);
            return exit;
        }

        public void RandCreation()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((i % 2 == 0) || (j % 2 == 0))
                    {
                        map[i, j] = '█';
                    }
                    else
                    {
                        map[i, j] = ' ';
                    }
                }
            }

            Random rand = new Random(); int choise;
            for (int i = 3; i < size; i += 2)
            {
                for (int j = 3; j < size; j += 2)
                {
                    choise = rand.Next(0, 2);
                    if (choise == 0)
                    {
                        map[i - 1, j] = ' ';
                    }
                    else
                    {
                        map[i, j - 1] = ' ';
                    }
                }
            }

            for (int i = 2; i < size - 1; i += 2)
            {
                map[1, i] = ' ';
                map[i, 1] = ' ';
            }

            map[size - 2, size - 2] = '$';
        }

        public void StatCreation()
        {
            string[] readMap = File.ReadAllLines(@"D:\map.txt");
            for (int i = 0; i < readMap.Length; i++)
            {
                for (int j = 0; j < readMap[i].Length; j++)
                {
                    map[i, j] = readMap[i][j];
                }
            }

            //map[readMap.Length - 2, readMap.Length - 2] = '$';
        }

        public void ShowMap()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < size; j++)
                {
                    Console.Write(map[i, j]);
                }
            }

            Console.SetCursorPosition(position[1], position[0] + 1);
            Console.Write(charModel);
            Console.SetCursorPosition(size, size);
        }
    }
}
