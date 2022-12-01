using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao phan tu n=");
            int n = Convert.ToInt32(Console.ReadLine());
            int[]arr=new int[n];
            for (int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Nhap vao gia tri cho phan tu thu {0}:", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Cac phan tu trong mang la:");
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(arr[i]+"");
            }
            int max = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (max < arr[i])
                    max = arr[i];
            }
            Console.WriteLine("So lon nhat trong mang la: {0}", max);
        }
    }
}
