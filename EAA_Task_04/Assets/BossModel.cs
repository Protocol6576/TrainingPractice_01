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

       public void BossAI(int enemyNum)
       {
            if(enemyNum == 1)
            {

            }
       }
    }
}
