using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManagement
{
    public class Khachhangviet : Khachhang
    {
        private int LoaiKH { get; set; }
        private int Dinhmuc { get; set; }
        public Khachhangviet(int khachhangId, int soluong, double dongia, double thanhtien, string diachi, string hoTenKH) : base(khachhangId, soluong, dongia, thanhtien, diachi, hoTenKH)
        {
            this.LoaiKH = LoaiKH;
            this.Dinhmuc = Dinhmuc;
        }

        public Khachhangviet()
        {
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine($"Nhap loai khach hang(1.sinh hoat, 2.kinh doanh,3.san xuat):");
            LoaiKH=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Nhap dinh muc:");
            Dinhmuc = Convert.ToInt32(Console.ReadLine());
        }
        public double TTien()
        {
            if (Soluong <= Dinhmuc)
            {
                return this.Soluong * this.Dongia;
            }
            else
            {
                return this.Dinhmuc * this.Dongia + (this.Soluong - this.Dinhmuc) * this.Dongia * 2.5;
            }
        }
        public override string ToString()
        {
            String temp = null;
            if (LoaiKH == 1)
            {
                temp = "Sinh hoat";
            }
            else if (LoaiKH == 2)
            {
                temp = "Kinh doanh";
            }
            else if (LoaiKH == 3)
            {
                temp = "San xuat";
            }
            return "Khach Hang Viet:{" + base.ToString() + ",Loai KH:" + temp + ",Dinh muc:" + Dinhmuc+ "}";
        }
        
    }
}
