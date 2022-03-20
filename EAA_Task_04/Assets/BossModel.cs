using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAA_Task_04.Assets
{
    class BossModel : BasicModel
    {

        public BossModel(int Hp, int Attack, string[] View) : base(Hp, Attack, View) { }

        public ActionResult BossAI(PlayerModel Player, SummonedModel Cat)
        {
            ActionResult actionResult;

            if (Cat.HpInfo() == 0)
            {
                actionResult = SingleAtack(Player);
            }
            else
            {
                actionResult = MassAtack(Player, Cat);
            }

            return actionResult;
        }

        private ActionResult SingleAtack(PlayerModel Player)
        {
            string action = "Босс нанеc вам атаку";
            string result = "Урон";
            double intResult = DealDamage(1);

            var actionResult = new ActionResult(action, result, intResult);
            Player.TakeDamage(intResult);

            return actionResult;
        }

        private ActionResult MassAtack(PlayerModel Player, SummonedModel Cat)
        {
            string action = "Босс нанеc всем атаку";
            string result = "Урон всем";
            double intResult = DealDamage(0.2);

            var actionResult = new ActionResult(action, result, intResult);
            Player.TakeDamage(intResult);
            Cat.TakeDamage(intResult);

            if(Cat.HpInfo() == 0)
            {
                Cat.UnShowModel(9, 12);
            }

            return actionResult;
        }
    }
}
