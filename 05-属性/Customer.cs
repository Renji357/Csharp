
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_属性
{
    class Customer
    {
        private string name;
        //private int age;
        private string address;
        private string createTime;

        public Customer()
        {
            Console.WriteLine("コンストラクタが起用されました");
        }

        //public Customer(string name, int age, string address, string createTime)
        //{
        //    this.name = name;
        //    this.age = age;
        //    this.address = address;
        //    this.createTime = createTime;
        //}

        // 読み取り専用と書き込み専用のプロパティ
        public string Name
        {
            get; set;
        }

        // 自動的にフィールドを生成する
        public int Age { get; set; }

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        //public int Age
        //{
        //    get { return age; }
        //    set { age = value; }
        //}

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
            Console.WriteLine("姓名：{0}，年龄：{1}，地址：{2}，创建时间：{3}", name, Age, address, createTime);
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