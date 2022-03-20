using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAA_Task_04.Assets
{
    class BasicModel
    {
        private int hp;
        private int attack;
        private string[] view;

        public BasicModel(int Hp, int Attack, string[] View)
        {
            hp = Hp;
            attack = Attack;
            view = View;
        }

        public void TakeDamage(int damage)
        {
            hp -= damage;
        }

        public int DealDamage()
        {
            return attack;
        }

        public void ShowModel(int posX, int posY)
        {
            for ( int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(posX + i, posY);
                Console.Write(view[i]);
            }
        }
    }
}
