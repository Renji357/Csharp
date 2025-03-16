namespace _03_编程题2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入两个数字，每行一个");
            int a = 0;
            int b = 0;
            while (true)
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("输入不合法，请重新输入");
                }
                Console.WriteLine("两个数字的和是：" + (a + b));
            }

        }
    }
}
