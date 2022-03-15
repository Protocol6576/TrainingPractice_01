using System;

namespace EAA_Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            const int exchange = 3;

            int gold = 0;
            int crystal = 0;

            
            ShowData(gold, crystal, exchange);
            while (gold == 0) // Ввод золота с проверкой
            {
                Console.Write("Введите начальное количество золота: ");

                string goldInput = Console.ReadLine();
                if (int.TryParse(goldInput, out int i)) {
                    if (i >= exchange)
                        gold = i;
                    else if ((i < exchange) && (i > 0)){
                        ShowData(gold, crystal, exchange);
                        Console.WriteLine("// Данного количества золота не хватит для покупки одного кристала, введите другое число //");
                    }
                    else
                    {

                        ShowData(gold, crystal, exchange);
                        Console.WriteLine("!!! Число должно быть натуральным, повторите попытку !!!");
                    }
                }
                else
                {
                    
                    ShowData(gold, crystal, exchange);
                    Console.WriteLine("!!! Некорректный ввод, повторите попытку !!!");
                }
            }

            
            ShowData(gold, crystal, exchange);
            while (crystal == 0) // Покупка кристалов с првоеркой
            {
                Console.Write("Введите количество кристалов, которые вы хотите купить: ");

                string crystalInput = Console.ReadLine();
                if (int.TryParse(crystalInput, out int i))
                {
                    if (i > 0)
                    {
                        if (i * exchange > gold)
                        {
                            
                            ShowData(gold, crystal, exchange);
                            Console.WriteLine("// Вам не хватает золота чтоб купить " + i + " кристалов, введите другое число //");
                            crystal = 0;
                        }
                        else
                        {
                            crystal = i;
                        }
                    }
                    else
                    {
                        
                        ShowData(gold, crystal, exchange);
                        Console.WriteLine("!!! Число должно быть натуральным, повторите попытку !!!");
                    }
                }
                else
                {
                    
                    ShowData(gold, crystal, exchange);
                    Console.WriteLine("!!! Некорректный ввод, повторите попытку !!!");
                }
            }

            gold -= crystal * exchange;

            
            ShowData(gold, crystal, exchange);
            Console.WriteLine("Вы успешно купили кристалы!");
            Console.ReadLine();
        }

        static void ShowData(int goldD, int crystalD, int exchangeD)
        {
            Console.Clear();
            Console.WriteLine("Курс золота к кристалам: " + exchangeD + ":1");
            Console.WriteLine("Количество золота: " + goldD);
            Console.WriteLine("Количество кристалов: " + crystalD);
            Console.Write("\n***\n");
        }
    }
}
