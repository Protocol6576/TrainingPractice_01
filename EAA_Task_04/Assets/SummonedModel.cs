using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAA_Task_04.Assets
{
    class SummonedModel : BasicModel
    {
        private string name;

        public SummonedModel(int Hp, int Attack, string[] View, string Name) : base(Hp, Attack, View) { name = Name; }

        private ActionResult BasicAtack(BossModel boss)
        {
            string action = name + " нанес атаку боссу.";
            string result = "Урон";
            double intResult = DealDamage(1);

            var actionResult = new ActionResult(action, result, intResult);
            boss.TakeDamage(intResult);

            return actionResult;
        }
    }
}
