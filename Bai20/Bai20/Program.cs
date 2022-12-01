using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String chuoi;
            Console.WriteLine("Nhap vao mot chuoi: ");
            chuoi = Console.ReadLine();
            if (chuoi == ("^[A-Z][^\\s]{0,18}\\d$"))
                Console.WriteLine("Duyet");
            else
                Console.WriteLine("Khong duyet");

        }
    }
}
