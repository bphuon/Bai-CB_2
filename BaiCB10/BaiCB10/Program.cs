using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiCB10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MSSV;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nhap vao MSSV thu" + (i + 1) + ":");
                MSSV = Console.ReadLine();
            }
            for(int i = 0; i < 5; i++)
            {
                if (MSSV == ("B170[1-9]{4}"))
                    Console.WriteLine("MSSV thu" + (i + 1) + "sai dinh dang!");
            }

        }
    }
}
