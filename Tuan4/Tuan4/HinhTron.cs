using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan4
{
    class Hinhtron
    {
        private Toado tam;
        private double bankinh;

        public Hinhtron(Toado tam, double banKinh)
        {
            this.tam = tam;
            this.bankinh = banKinh;
        }

        public Hinhtron()
        {
            this.tam = new Toado();
            this.bankinh = 0.0;
        }

        public Toado Tam
        {
            get { return tam; }
            set { tam = value; }
        }

        public double BanKinh
        {
            get { return bankinh; }
            set { bankinh = value; }
        }

        public double TinhChuVi()
        {
            return 2 * Math.PI * bankinh;
        }

        public double TinhDienTich()
        {
            return Math.PI * bankinh * bankinh;
        }
        public void nhap()
        {
            Console.WriteLine("Nhap ban kinh: ");
            bankinh = double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine(" voi ban kinh {0}", bankinh);
            Console.WriteLine("Chu vi hinh tron la: {0}", TinhChuVi());
            Console.WriteLine("Dien tich hinh tron la: {0}", TinhDienTich());
        }
    }
}
