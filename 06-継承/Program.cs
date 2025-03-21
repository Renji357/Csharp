namespace _06_継承
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BaseClass bc1 = new BaseClass();
            //bc1.Function1();
            //bc1.Function2();
            //bc1.data1 = 1;
            //bc1.data2 = "BaseClass";
            //Console.WriteLine(bc1.data1);
            //Console.WriteLine(bc1.data2);

            //DrivenClass1 dc1 = new DrivenClass1();
            //dc1.Function1();
            //dc1.Function2();
            //dc1.data1 = 2;
            //dc1.data2 = "DrivenClass1";
            //Console.WriteLine(dc1.data1);
            //Console.WriteLine(dc1.data2);

            //DrivenClass2 dc2 = new DrivenClass2();
            //dc2.Function1();
            //dc2.Function2();
            //dc2.data1 = 3;
            //dc2.data2 = "DrivenClass2";
            //Console.WriteLine(dc2.data1);
            //Console.WriteLine(dc2.data2);

            Boss boss1 = new Boss(100,100000,20);
            boss1.Print();

        }
    }
}
