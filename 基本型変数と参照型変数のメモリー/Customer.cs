using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基本型変数と参照型変数のメモリー
{
    class Customer
    {
        public string name;
        public int age;
        public string address;
        public string createTime;

        public Customer(string name, int age, string address, string createTime)
        {
            this.name = name;
            this.age = age;
            this.address = address;
            this.createTime = createTime;
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
