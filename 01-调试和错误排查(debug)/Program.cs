namespace _01_调试和错误排查_debug_
{
    internal class Program
    {
        static int add(int a,int b)
        {
            int res = a + b;
            return res;
        }
        static void Main(string[] args)
        {
            int result = add(40, 20);

            int a = 123;
            int b = 456;

            Console.WriteLine(a);
            int c = 789;
            Console.WriteLine(b);
            Console.WriteLine(result);
        }
    }
}
