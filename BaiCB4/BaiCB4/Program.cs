using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCB4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Kiem tra loai tam giac");
            Console.WriteLine("Nhap canh a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap canh b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap canh c:");
            c = Convert.ToInt32(Console.ReadLine());
            if ((a * a) == (b * b) + (c * c) || ((b * b) == (a * a) + (c * c)) && ((c * c) == (a * a) + (b * b)))
            {
                Console.WriteLine("Day la tam giac vuong");

            }
            else
            {
                Console.WriteLine("Day khong phai la tam giac vuong");
            }
        }
    }
}
