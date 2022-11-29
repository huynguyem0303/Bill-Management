using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManagement
{
    public class Khachhang
    {
        public Khachhang(int khachhangId, int soluong, double dongia, double thanhtien, string diachi, string hoTenKH)
        {
            KhachhangId = khachhangId;
            Soluong = soluong;
            Dongia = dongia;
            Thanhtien = thanhtien;
            Diachi = diachi;
            HoTenKH = hoTenKH;
        }

        public Khachhang()
        {
        }

        public int KhachhangId { get; set; }
        public int Soluong { get; set; }
        public double Dongia { get; set; }
        public double Thanhtien { get; set; }
        public String Diachi { get; set; }
        public String HoTenKH { get; set; }


        public virtual void Nhap()
        {
            Console.WriteLine($"Nhap ma khach hang:");
            KhachhangId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Nhap ho va ten khach hang:");
            HoTenKH = Console.ReadLine();
            Console.WriteLine($"Nhap dia chi:");
            Diachi = Console.ReadLine();
            Console.WriteLine($"Nhap so luong(KW):");
            Soluong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Nhap don gia:");
            Dongia = Convert.ToDouble(Console.ReadLine());
        }
        public override string ToString()
        {
            return "Ma KH:" + KhachhangId + ",Ho ten:" + HoTenKH + ",Dia chi:" + Diachi + ",So luong:" + Diachi + ",Don gia:" + Dongia;
        }
    }
}
