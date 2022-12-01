using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCB11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap vao mot so nguyen duong n:");
            n = Convert.ToInt32(Console.ReadLine());
            double[] arr=new double[n];
            double total=0;
            double average=0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Nhap vao gia tri cho phan tu thu {0}:", i + 1);
                arr[i]=Convert.ToDouble(Console.ReadLine ());
                for (int i = 0; i < arr.Length; i++)
                {
                    total += arr[i];
                }
                average = total / arr.Length;
                Console.WriteLine("\n\n Trung binh cong cac phan tu la: {0}", average);
            }

        }
    }
}
