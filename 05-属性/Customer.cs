using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_属性
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

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
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
