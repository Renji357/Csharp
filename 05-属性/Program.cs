
namespace _05_属性
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Name = "张三";
            c1.Age = 20;
            c1.Address = "北京";
            c1.CreateTime = "2018-01-01";

            // 匿名型（とくめいかた）
            var age2 = 45;
            var name2 = "shiki";
        }
    }
}