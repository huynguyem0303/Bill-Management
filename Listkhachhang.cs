using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManagement
{
    public class Listkhachhang
    {
        private Khachhang[] kh = new Khachhang[100];
        private int count, sum1 = 0, sum2 = 0, dem = 0;
        private double sumtien = 0;
        public void KhachhangList()
        {
            count=0;
            for(int i = 0; i < 100; i ++)
            {
                kh[i] = new Khachhang();
            }
        }
        public void KhachhangAdd(int temp)
        {
            if (count >= 100)
            {
                Console.WriteLine($"Bo nho day");
            }else if (temp == 1)
            {
                kh[count]=new Khachhangviet();
                Khachhangviet khv = new Khachhangviet();
                khv.Nhap();
                khv.Thanhtien=khv.TTien();
                kh[count]=khv;
                sum1 += khv.Soluong;
            }
            else
            {
                kh[count] = new Khachhangnuocngoai();
                Khachhangnuocngoai khnn = new Khachhangnuocngoai();
                khnn.Nhap();
                khnn.Thanhtien = khnn.TTien();
                kh[count] = khnn;
                sum2 += khnn.Soluong;
                sumtien += khnn.Thanhtien;            
             }
            dem++;
            count++;

            
        }
        public void Hienthi()
        {
            for(int i=0;i<count; i++)
            {
                Console.WriteLine($"So TT:" + (i + 1));
                Console.WriteLine(kh[i].ToString());
            }
        }
        public void TongSL()
        {
            Console.WriteLine($"Tong so luong (KW) dien cua khach hang Viet Nam:"+sum1);
            Console.WriteLine($"Tong so luong (KW) dien cua khach hang nuoc ngoai:" + sum2);
        }
        public void Trungbinh()
        {
            Console.WriteLine($"Trung binh thanh tien cua khach hang nuoc ngoai:" + (sumtien/dem));
        }
    }
}
