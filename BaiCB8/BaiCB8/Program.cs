using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCB8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool soNguyenTo=false;
            Console.WriteLine("Nhap vao mot so nguyen");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1 2");
            for (int i = 3; i < = n; i++)
            {
                soNguyenTo=true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        soNguyenTo = false;
                }
                Console.WriteLine(i + "");
            }

        }
    }
}
