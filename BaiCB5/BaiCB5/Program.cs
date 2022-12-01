using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCB5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MSSV;
            Console.WriteLine("Nhap vao MSSV");
            MSSV = Console.ReadLine();
            Console.WriteLine("Ma so sinh vien la:" + MSSV);
            if (MSSV == "B\\d{7}")
            {
                Console.WriteLine("Phu hop");
            }
            else
            {
                Console.WriteLine("Khong phu hop");
            }
        }
    }
}
