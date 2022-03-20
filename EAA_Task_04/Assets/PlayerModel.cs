using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAA_Task_04.Assets
{
    class PlayerModel : BasicModel
    {
        public PlayerModel(int Hp, int Attack, string[] View) : base(Hp, Attack, View)
        {
        }

        public ActionResult BattleAction(BossModel boss, SummonedModel cat)
        {
          /*  ConsoleKeyInfo key = Console.ReadKey();
            string action = key.Key.ToString(); */
            string action = Console.ReadLine();
            ActionResult actionResult;

            switch (action)
            {
                case "1":
                    actionResult = BasicAtack(boss);
                    break;
                case "2":
                    actionResult = SummonCat(cat);
                    break;
                case "3":
                    actionResult = CatAtack(boss, cat);
                    break;
                case "4":
                    actionResult = SelfHeal();
                    break;
                case "5":
                    actionResult = OneShot(boss);
                    break;
                default:
                    actionResult = new ActionResult("Вы просто стояли", "Идиотизм", 100);
                    break;
            }

            return actionResult;
        }

        private ActionResult BasicAtack(BossModel boss)
        {
            string action = "Вы нанесли атаку боссу.";
            string result = "Урон";
            double intResult = DealDamage(1);

            var actionResult = new ActionResult(action, result, intResult);
            boss.TakeDamage(intResult);

            return actionResult;
        }

        private ActionResult SummonCat(SummonedModel cat)
        {
            string action = "Вы призвали кота.";
            string result = "Количество";
            double intResult = 1;

            var actionResult = new ActionResult(action, result, intResult);
            cat.Heal(100);
            cat.ShowModel(9, 12);

            return actionResult;
        }

        private ActionResult CatAtack(BossModel boss, SummonedModel cat)
        {
            if (cat.HpInfo() == 0)
            {
                string action = "Кот отсутствует";
                string result = "Урон";
                double intResult = cat.DealDamage(0);

                var actionResult = new ActionResult(action, result, intResult);

                return actionResult;
            }
            else
            {
                string action = "Вы атаковали котом.";
                string result = "Урон";
                double intResult = cat.DealDamage(1);

                var actionResult = new ActionResult(action, result, intResult);
                boss.TakeDamage(intResult);

                return actionResult;
            }
        }

        private ActionResult SelfHeal()
        {
            string action = "Вы поели корма.";
            string result = "Лечение";
            double intResult = DealDamage(2);

            var actionResult = new ActionResult(action, result, intResult);
            Heal(DealDamage(2));

            return actionResult;
        }

        private ActionResult OneShot(BossModel boss)
        {
            string action = "Вы пошипели на босса";
            string result = "Урон";
            double intResult = DealDamage(100);

            var actionResult = new ActionResult(action, result, intResult);
            boss.TakeDamage(intResult);

            return actionResult;
        }
    }
}
