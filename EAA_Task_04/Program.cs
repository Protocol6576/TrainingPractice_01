using EAA_Task_04.Assets;
using System;

namespace EAA_Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] p1 =
            {
                " 0 ",
                "/|\\",
                "/ \\",
            };
            string[] b1 =
            {
                " 0 ",
                "/|\\",
                "/ \\",
            };
            string[] s1 =
            {
            "          />___/>",
             "         | _  _ |",
             "        ／ = _x =",
             "      /        |",
             "  __ / .      /",
             " / __|  |  | |",
             "| (  \\___\\_)_)",
             " \\_>"
            };

            PlayerModel Player = new PlayerModel(100, 5, p1);
            BossModel Boss = new BossModel(100, 25, b1);
            SummonedModel Cat = new SummonedModel(0, 1, s1, "Кот");

            ActionResult[] actionLogs = new ActionResult[4];
            ActionResult action;

            Interface intfBuild = new Interface();
            intfBuild.showInterface(1, 1);
            Boss.ShowModel(35, 4);

            while((Boss.HpInfo() != 0) && (Player.HpInfo() != 0)) {
                ShowAllHp(Player, Boss, Cat);

                Console.SetCursorPosition(1, 1);
                action = Player.BattleAction(Boss, Cat);
                addLog(actionLogs, action);
                ShowLogs(53, 3, actionLogs);

                action = Boss.BossAI(Player, Cat);
                addLog(actionLogs, action);
                ShowLogs(53, 3, actionLogs);
            }

            Console.Clear();
            if(Boss.HpInfo() == 0)
            {
                Console.Write("Вы победили!");
            }
            else
            {
                Console.Write("Вы проиграли!");
            }
            Console.WriteLine("\n");

        }

        static void addLog(ActionResult[] actionLogs, ActionResult newAction)
        {
            for (int i = 0; i < actionLogs.Length - 1; i++)
            {
                actionLogs[i] = actionLogs[i + 1];
            }
            actionLogs[actionLogs.Length - 1] = newAction;
        }

        static void ShowLogs(int posX, int posY, ActionResult[] actionLogs)
        {
            for (int i = 0; i < 4; i++)
            {
                if( actionLogs[i] != null)
                {
                    actionLogs[i].ShowResult(posX, posY + i * 3);
                }
            }
        }

        static void ShowAllHp(PlayerModel Player, BossModel Boss, SummonedModel Cat)
        {

            Console.SetCursorPosition(69, 15); Console.Write("     ");
            Console.SetCursorPosition(69, 15); Console.Write(Player.HpInfo());
            Console.SetCursorPosition(69, 16); Console.Write("     ");
            Console.SetCursorPosition(69, 16); Console.Write(Boss.HpInfo());
            Console.SetCursorPosition(69, 17); Console.Write("     ");
            Console.SetCursorPosition(69, 17); Console.Write(Cat.HpInfo());
        }
    }
}
