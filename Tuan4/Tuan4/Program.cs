using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan4
{
    class Program
    {
        static void Main(string[] args)
        {
            Toado td = new Toado();
            Hinhtron ht = new Hinhtron();
            td.nhap();
            ht.nhap();
            td.xuat();
            ht.xuat();
            Console.ReadLine();
        }
    }
}
