using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManagement
{
    public class Khachhangnuocngoai : Khachhang

    {
        private String Quoctich { get; set; }
        public Khachhangnuocngoai(int khachhangId, int soluong, double dongia, double thanhtien, string diachi, string hoTenKH) : base(khachhangId, soluong, dongia, thanhtien, diachi, hoTenKH)
        {
            this.Quoctich = Quoctich;
        }

        public Khachhangnuocngoai()
        {
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine($"Nhap quoc tich");
            Quoctich = Console.ReadLine();
        }
        public override string ToString()
        {
            return "Khach Hang nuoc ngoai:{"+base.ToString()+",Quoc Tich:"+ Quoctich+ "}";
        }
        public double TTien()
        {
            return this.Soluong * this.Dongia;
        }
    }
}
