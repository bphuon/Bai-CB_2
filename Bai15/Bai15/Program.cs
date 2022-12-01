using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so phan tu cua mang:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[5];
            for (int i=0;i<5;i++)
            {
                Console.WriteLine("Nhap vao ma thu " + (i + 1));

            }
            if (n=("00[2-5]L\\d{4}"))
            {
                Console.WriteLine("Sai roi");
                return;
            }
            Console.WriteLine("Dung roi");
        }
        
    }
}
