using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_仮想メソッド
{
    internal class Boss:Enemy
    {
        override public void Move()
        {
            Console.WriteLine("ボスが移動中です");
        }

        public void BossSkill()
        {
            Console.WriteLine("ボスがスキルを使ってきた");
        }
    }
}
