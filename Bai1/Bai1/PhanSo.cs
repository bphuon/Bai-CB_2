using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class PhanSo
    {
        public int tuso { get; set; }
        public int mauso { get; set; }
        public void NhapPhanSo()
        {
            Console.WriteLine("Tu so la:");
            this.tuso = int.Parse(Console.ReadLine());
            Console.WriteLine("Mau so la:");
            do
                this.mauso = int.Parse(Console.ReadLine());
            while (this.mauso == 0);
        }
        public void InPhanSo()
        {
            Console.WriteLine( tuso + "/" + mauso);
        }
        public PhanSo CongPhanSo(PhanSo PS1,PhanSo PS2)
        {
            PhanSo PS3 = new PhanSo();
            PS3.tuso = PS1.tuso * PS2.mauso + PS2.tuso * PS1.mauso;
            PS3.mauso = PS1.mauso * PS2.mauso;
            return PS3;
        }
        public PhanSo TruPhanSo(PhanSo PS1,PhanSo PS2)
        {
            PhanSo PS4 = new PhanSo();
            PS4.tuso = PS1.tuso * PS2.mauso - PS2.tuso * PS1.mauso;
            PS4.mauso = PS1.mauso * PS2.mauso;
            return PS4;
        }
        public PhanSo NhanPhanSo(PhanSo PS1,PhanSo PS2)
        {
            PhanSo PS5 = new PhanSo();
            PS5.tuso = PS1.tuso * PS2.tuso;
            PS5.mauso = PS1.mauso * PS2.mauso;
            return PS5;
        }
        public PhanSo ChiaPhanSo(PhanSo PS1, PhanSo PS2)
        {
            PhanSo PS6 = new PhanSo();
            PS6.tuso = PS1.tuso * PS2.mauso;
            PS6.mauso= PS1.mauso * PS2.tuso;
            return PS6;
        }
            
    }
}
