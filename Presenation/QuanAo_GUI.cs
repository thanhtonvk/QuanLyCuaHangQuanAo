﻿using QuanLyCuaHangQuanAo.DataAccess;
using QuanLyCuaHangQuanAo.BusinessLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCuaHangQuanAo.Presenation
{
    class QuanAo_GUI
    {
        public static void Menu()
        {
            Console.WriteLine("                                 ══════════════════════════════════════════════════_");
            Console.WriteLine("                                 ║                       QUẢN LÝ QUẦN ÁO                 ║");
            Console.WriteLine("                                 ║══════════════════════════════════════════════════║");
            Console.WriteLine("                                 ║1. Nhập thêm quần áo                                   ║");
            Console.WriteLine("                                 ║2. Hiện thị danh sách                             ║");
            Console.WriteLine("                                 ║3. Sửa thông tin                                  ║");
            Console.WriteLine("                                 ║4. Xóa quần áo                                         ║");
            Console.WriteLine("                                 ║5. Tìm kiếm                                       ║");
            Console.WriteLine("                                 ║0.Thoát                                           ║");
            Console.WriteLine("                                 ║══════════════════════════════════════════════════║");
        }
        public static void Run(QuanAo_BLL quanao_BLL,QuanAo_DAL quanao_DAL,ArrayList arrayList)
        {
            int chon;
           

            while (true)
            {
                Menu();
                //chọn chức  năng
                chon = int.Parse(Console.ReadLine());
                //nếu nhập = 0 thì dừng chương trình
                if (chon == 0) break;
                switch (chon)
                {
                    case 1:
                        quanao_BLL.Them(arrayList);
                        quanao_DAL.ghiFile(arrayList);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        quanao_BLL.Hien(arrayList);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        quanao_BLL.Sua(arrayList);
                        quanao_DAL.ghiFile(arrayList);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        quanao_BLL.Xoa(arrayList);
                        quanao_DAL.ghiFile(arrayList);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        quanao_BLL.Timkiem(arrayList);
                        Console.WriteLine("                                 Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default: break;
                }
            }
        }
    }
}
