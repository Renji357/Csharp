namespace _04_面向对象
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 利用类创建对象，customer就是对象名，new Customer()就是创建对象的语句
            Customer customer = new Customer();
            customer.setName("张三");
            customer.setAge(20);
            customer.setAddress("北京市朝阳区");
            customer.setCreateTime("2020-01-01");
            Customer customer2 = new Customer("李四", 30, "上海市浦东区", "2020-01-02");

            customer.Show();

            // 利用类创建对象，vehicle就是对象名，new Vehicle()就是创建对象的语句
            Vehicle vehicle = new Vehicle();
            vehicle.brand = "奔驰";
            vehicle.speed = 60;
            vehicle.maxSpeed = 120;
            vehicle.weight = 1.5;

            vehicle.Run();
            vehicle.Stop();

            Vector3 vector3 = new Vector3();
            vector3.setX(1);
            vector3.setY(2);
            vector3.setZ(3);
            Console.WriteLine(vector3.getLength());
        }
    }
}
