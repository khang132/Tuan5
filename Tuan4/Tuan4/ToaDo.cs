using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan4
{
    class Toado
    {
        private string ten;
        private float x;
        private float y;

        public Toado(float x, float y)
        {
            this.x = x;
            this.y = y;
            this.ten = "";
        }

        public Toado()
        {
            this.x = 0.0f;
            this.y = 0.0f;
            this.ten = "";
        }

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public float getX()
        {
            return x;
        }

        public float getY()
        {
            return y;
        }

        public void setX(float x)
        {
            this.x = x;
        }

        public void setY(float y)
        {
            this.y = y;
        }

        public void nhap()
        {
            Console.WriteLine("Nhap tam toa do: ");
            x = float.Parse(Console.ReadLine());
            y = float.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.Write("Tam O({0},{1})", x, y);
        }
    }
}
