using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string chuoi;
            char kyTu;
            Boolean tonTai=false;

            Console.WriteLine("Nhap vao mot chuoi");
            chuoi = Console.ReadLine();
            Console.WriteLine("Nhap vao ky tu muon kiem tra");
            kyTu = Console.ReadLine().ElementAt(0);
            char[] mangKiTu = chuoi.ToCharArray();
            for (int i = 0; i < mangKiTu.Length; i++) 
            {
                {
                    if (kyTu == mangKiTu[i])
                    {
                        Console.WriteLine("Có");
                        tonTai = true;
                    }
                }
                if (tonTai == false)
                    Console.WriteLine("Không");
            }


        }
    }
}
