namespace _02_异常处理
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [1, 2, 3, 4];
            try
            {
                int a = arr[4];
                Console.WriteLine(a);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("数组越界");
            }


        }
    }
}
