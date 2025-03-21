using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_継承
{
    internal class DrivenClass1 : BaseClass
    {
        public int data3;

        public void Function3()
        {
            Console.WriteLine("派生クラス1のFunction3メソッド");
        }
    }
}
