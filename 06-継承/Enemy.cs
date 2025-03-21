using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_継承
{
    internal class Enemy
    {
        protected int hp;
        protected int speed;

        public void AI()
        {
            Console.WriteLine("AI");
        }
        

        public void Move()
        {
            Console.WriteLine("Move");
        }
    }
}
