namespace _07_仮想メソッド
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Boss boss1 = new Boss();
            //boss1.Move();

            Enemy enemy1;
            enemy1 = new Boss();
            enemy1 = new Type1Enemy();
        }
    }
}
