using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtStruct
{
    internal class Program
    {
      
        struct SinhVien
        {
            public int MaSV_120;
            public string HoTen_120;
            public int Gioi_120;
            public double DiemToan_120;
            public double DiemLy_120;
            public double DiemVan_120;
        }
        enum GioiTinh
        {
            Nam,
            Nu
        }

        static void NhapThongTinSinhVien(out SinhVien SV)
        {
            Console.Write(" Ma so: ");
            SV.MaSV_120 = int.Parse(Console.ReadLine());
            Console.Write(" Ho ten: ");
            SV.HoTen_120 = Console.ReadLine();
            Console.Write(" Gioi: ");
            SV.Gioi_120 = int.Parse(Console.ReadLine());
            Console.Write(" Diem toan: ");
            SV.DiemToan_120 = Double.Parse(Console.ReadLine());
            Console.Write(" Diem ly: ");
            SV.DiemLy_120 = Double.Parse(Console.ReadLine());
            Console.Write(" Diem van: ");
            SV.DiemVan_120 = Double.Parse(Console.ReadLine());
        }

        static double DiemTBSinhVien(SinhVien SV)
        {
            return (SV.DiemToan_120 + SV.DiemLy_120 + SV.DiemVan_120) / 3;
        }
        static void XuatThongTinSinhVien(SinhVien SV)
        {
            Console.WriteLine("Thong tin sinh vien");
            Console.WriteLine(" Ma so: " + SV.MaSV_120);
            Console.WriteLine(" Ho ten: " + SV.HoTen_120);
            Console.WriteLine(" Gioi: " + SV.Gioi_120);
            Console.WriteLine(" Diem toan: " + SV.DiemToan_120);
            Console.WriteLine(" Diem ly: " + SV.DiemLy_120);
            Console.WriteLine(" Diem van: " + SV.DiemVan_120);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int so_sv;
            
            Console.WriteLine("Nhap so sv: ");
            so_sv = int.Parse(Console.ReadLine());
            SinhVien[] sinhViens = new SinhVien[so_sv];
            for (int i = 0; i < sinhViens.Length; i++)
            {
                sinhViens[i] = new SinhVien();
                Console.WriteLine(" Nhap thong tin sinh vien: ");

                NhapThongTinSinhVien(out sinhViens[i]);
                Console.WriteLine("*********");
                Console.WriteLine(" Thong tin sinh vien vua nhap la: ");
                XuatThongTinSinhVien(sinhViens[i]);
                Console.WriteLine(" Diem TB cua sinh vien la: " + DiemTBSinhVien(sinhViens[i]));
            }
            
            foreach(SinhVien i in sinhViens)
            {
                XuatThongTinSinhVien(i);
            }
            

            Console.ReadLine();
        }
    }
}
