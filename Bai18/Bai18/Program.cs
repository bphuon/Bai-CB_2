using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string chuoi;
            Console.WriteLine("Nhap vao mot chuoi");
            chuoi = Console.ReadLine();
            if  (chuoi== ".*\\d.*")
                Console.WriteLine("Co");
            else
                Console.WriteLine("Khong");
        }
    }
}
