using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAA_Task_04.Assets
{

    class Interface
    {
        private int borders = 3;

        public void showInterface(int posX, int posY)
        {

            int indent = borders;

            string[] mainArea = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"" + "mainArea.txt");
            for (int i = 0; i < mainArea.Length; i++)
            {
                Console.SetCursorPosition(posX + indent, posY + i);
                Console.Write(mainArea[i]);
            }
            indent += mainArea[1].Length + borders;

            string[] logsArea = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"" + "logsArea.txt");
            for(int i = 0; i < logsArea.Length; i++)
            {
                Console.SetCursorPosition(posX + indent, posY + i);
                Console.Write(logsArea[i]);
            }
            indent += logsArea[1].Length + borders;

            Console.SetCursorPosition(53, 15); Console.Write("Ваше здоровье : ");
            Console.SetCursorPosition(53, 16); Console.Write("Здоровье босса: ");
            Console.SetCursorPosition(53, 17); Console.Write("Здоровье кота : ");

             string[] helpArea = File.ReadAllLines(@"D:\helpArea.txt");
             for (int i = 0; i < helpArea.Length; i++)
             {
                 Console.SetCursorPosition(posX + indent, posY + i);
                 Console.Write(helpArea[i]);
             }

            Console.SetCursorPosition(posX + indent + 2, posY + 2);
            Console.Write("1. - Обычная атака");

            Console.SetCursorPosition(posX + indent + 2, posY + 3);
            Console.Write("2. - призыв Кота");

            Console.SetCursorPosition(posX + indent + 2, posY + 4);
            Console.Write("3. - Атака Котом");

            Console.SetCursorPosition(posX + indent + 2, posY + 5);
            Console.Write("4. - Лечение");

            Console.SetCursorPosition(posX + indent + 2, posY + 6);
            Console.Write("5. - Убить босса");

            indent += helpArea[1].Length - borders;
            Console.SetCursorPosition(posX + borders, mainArea.Length + 3);
            for (int i = 0; i < indent; i++)
                Console.Write("═");
        }
    }
}
