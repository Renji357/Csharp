using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_面向对象
{
    class Customer
    {
        private string name;
        private int age;
        private string address;
        private string createTime;

        public Customer()
        {
            Console.WriteLine("构造函数被调用了");
        }

        public Customer(string name, int age, string address, string createTime)
        {
            this.name = name;
            this.age = age;
            this.address = address;
            this.createTime = createTime;
        }

        public void setName(string temp)
        {
            name = temp;
        }

        public void setAge(int temp)
        {
            if (temp < 0)
            {
                return;
            }
            age = temp;
        }

        public void setAddress(string temp)
        {
            address = temp;
        }

        public void setCreateTime(string temp)
        {
            createTime = temp;
        }
        public void Show()
        {
            Console.WriteLine("姓名：{0}，年龄：{1}，地址：{2}，创建时间：{3}", name, age, address, createTime);
        }
    }

    //struct CustomerStruct
    //{
    //    public string name;
    //    public int age;
    //    public string address;
    //    public string createTime;
    //    public void Show()
    //    {
    //        Console.WriteLine("姓名：{0}，年龄：{1}，地址：{2}，创建时间：{3}", name, age, address, createTime);
    //    }
    //}
}
