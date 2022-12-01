using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so phan tu cua mang:");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int i = 0, j = 0, temp;
            for(i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Nhap vao gia tri cho phan tu thu {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            j = i - 1;
            i = 0;
            while (i < j)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
            Console.WriteLine("Mang  sau khi dao nguoc la: ");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}
