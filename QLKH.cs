using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManagement
{
    public class QLKH
    {
        public static void Main(String[] args)
        {
            Listkhachhang listKH=new Listkhachhang();
            int x;
            do {
                Console.WriteLine($"1.Them khach hang Viet");
                Console.WriteLine($"2.Them khach hang nuoc ngoai");
                Console.WriteLine($"3.Hien thi danh sach khach hang");
                Console.WriteLine($"4.Xem tong KW cua cac khach hang");
                Console.WriteLine($"5.Xem trung binh thanh tien cua khach hang nuoc ngoai");
                Console.WriteLine($"Lua chon cua ban:");
                x =Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        listKH.KhachhangAdd(1);
                        break;
                    case 2:
                        listKH.KhachhangAdd(2);
                        break;
                    case 3:
                        listKH.Hienthi();
                        break;
                    case 4:
                        listKH.TongSL();
                        break;
                    case 5:
                        listKH.Trungbinh();
                        break;
                }
            } while (x != 0);
        }
    }
}
