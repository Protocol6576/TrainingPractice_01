using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAA_Task_04.Assets
{
    class BasicModel
    {
        private double hp;
        private double attack;
        private string[] view;

        public BasicModel(int Hp, int Attack, string[] View)
        {
            hp = Hp;
            attack = Attack;
            view = View;
        }

        public double HpInfo()
        {
            return hp;
        }

        public void TakeDamage(double damage)
        {
            hp -= damage;
            if (hp < 0)
                hp = 0;
        }

        public void Heal(double heal)
        {
            hp += heal;
        }

        public double DealDamage(double modifier)
        {
            return (attack * modifier);
        }

        public void ShowModel(int posX, int posY)
        {
            for ( int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(posX, posY + i);
                Console.WriteLine(view[i]);
            }
        }

        public void UnShowModel(int posX, int posY)
        {
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(posX, posY + i);
                for(int j = 0; j < view[i].Length; j++)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
