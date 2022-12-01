using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String chuoi;
            char kiTu;
            Boolean tonTai = false;

            Console.WriteLine("Nhap vao mot chuoi: ");
            chuoi = Console.ReadLine();
            Console.WriteLine("Nhap vao ky tu muon kiem tra:");
            kiTu = Console.ReadLine().ElementAt(0);

            char [] mangKiTu = chuoi.ToCharArray();
            for (int i = 0; i < mangKiTu.Length; i++)
            {
                if (kiTu == mangKiTu[i])
                {
                    Console.WriteLine((i + 1));
                    tonTai = true;
                }
            }
            if (tonTai == false)
                Console.WriteLine("Khong ton tai trong chuoi");
        }
    }
}
