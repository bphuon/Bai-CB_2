using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCB3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double  canha, canhb, canhc;
            Console.WriteLine("Kiem tra tam giac");
            Console.WriteLine("Nhap canh a:");
            canha=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap canh b:");
            canhb=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap canh c:");
            canhc=Convert.ToInt32(Console.ReadLine());
            if (canha+canhb>canhc  ||canha+canhc>canhb || canhb+canhc>canha)
            {
                Console.WriteLine("Day la ba canh cua mot tam giac");
            }
            else
            {
                Console.WriteLine("Khong phai la ba canh cua tam giac");
            }
            Console.ReadKey();

        }
    }
}
