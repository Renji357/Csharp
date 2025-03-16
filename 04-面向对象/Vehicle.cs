using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_面向对象
{
    class Vehicle
    {
        public string brand;
        public int speed;
        public int maxSpeed;
        public double weight;

        public void Run()
        {
            Console.WriteLine("车辆正在行驶中...");
        }
        public void Stop()
        {
            Console.WriteLine("车辆已停止行驶...");
        }
    }
}
