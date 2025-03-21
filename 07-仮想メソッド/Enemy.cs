using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_仮想メソッド
{
    internal class Enemy
    {
        public virtual void Move()
        {
            Console.WriteLine("敵が移動中です");
        }
    }
}
