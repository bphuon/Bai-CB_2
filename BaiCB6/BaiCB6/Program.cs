using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCB6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int sum = 0;
            Console.WriteLine("Nhap vao so nguyen");
            a=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
                if (i%2==0)
                    sum+=i;
            Console.WriteLine(sum);
        }
    }
}
