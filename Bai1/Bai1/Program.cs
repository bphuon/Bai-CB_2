using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhanSo P1 = new PhanSo();
            PhanSo P2 = new PhanSo();
            PhanSo P3 = new PhanSo();
            PhanSo P4 = new PhanSo();
            PhanSo P5 = new PhanSo();
            PhanSo P6 = new PhanSo();

            Console.WriteLine("Nhap phan so 1");
            P1.NhapPhanSo();
            Console.WriteLine("Nhap phan so 2");
            P2.NhapPhanSo();
            P3 = P3.CongPhanSo(P1, P2);
            Console.WriteLine("Tong hai phan so la:");
            P3.InPhanSo();
            P4 = P4.TruPhanSo(P1, P2);
            Console.WriteLine("Hieu hai phan so la:");
            P4.InPhanSo();
            P5 = P5.NhanPhanSo(P1, P2);
            Console.WriteLine("Tich hai phan so la:");
            P5.InPhanSo();
            P6 = P6.ChiaPhanSo(P1, P2);
            Console.WriteLine("Thuong hai phan so la:");
            P6.InPhanSo();



        }
    }
}
