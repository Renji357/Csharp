using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_面向对象
{
    class Vector3
    {
        private double x;
        private double y;
        private double z;

        public void setX(double temp)
        {
            if(temp < 0)
            {
                return;
            }
            x = temp;
        }

        public void setY(double temp)
        {
            if (temp < 0)
            {
                return;
            }
            y = temp;
        }

        public void setZ(double temp)
        {
            if (temp < 0)
            {
                return;
            }
            z = temp;
        }

        public double getX() { return x; }
        public double getY() { return y; }
        public double getZ() { return z; }
        public double getLength()
        {
            return Math.Sqrt(x*x + y*y + z*z);
        }
    }
}
