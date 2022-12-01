
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCB7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int sum = 0;
            Console.WriteLine("Nhap vao mot so nguyen");
            a=Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i < 20; i++)
                Console.WriteLine(a + "x" + i + "=" + a *i);
        }
    }
}
