using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_継承
{
    internal class Boss : Enemy
    {
        private int attack;

        public Boss(int attack,int hp,int speed)
        {
            this.attack = attack;
            base.hp = hp;
            base.speed = speed;
        }

        public void Skill()
        {
            Console.WriteLine("Boss Skill");
        }

        public void Print()
        {
            Console.WriteLine("HP: " + hp);
            Console.WriteLine("Speed: " + speed);
            Console.WriteLine("Attack: " + attack);
        }
    }
}
