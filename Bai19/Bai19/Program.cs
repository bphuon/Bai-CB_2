
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String chuoi;
            int soLan = 0;
            Console.WriteLine("Nhap vao mot chuoi: ");
            chuoi = Console.ReadLine();

            char[] mangKiTu= chuoi.ToCharArray();
            for (int i = 0; i < mangKiTu.Length; i++)
            {
                if ('a' == mangKiTu[i])
                {
                    soLan++;
                }
            }
            Console.WriteLine(soLan);
        }
    }
}
