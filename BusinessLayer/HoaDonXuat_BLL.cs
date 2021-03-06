﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyCuaHangQuanAo.Entities;
using QuanLyCuaHangQuanAo.BusinessLayer.Interface;
namespace QuanLyCuaHangQuanAo.BusinessLayer
{
    class HoaDonXuat_BLL : IHoaDonXuat
    {
        private int getSLBanChay(ArrayList arrayList)
        {
            int kq = int.MinValue;
            foreach(HoaDonXuat hoaDonXuat in arrayList)
            {
                if (kq < hoaDonXuat.Soluong) kq = hoaDonXuat.Soluong;
            }
            return kq;
        }
        private int getSLBanE(ArrayList arrayList)
        {
            int kq = int.MaxValue;
            foreach (HoaDonXuat hoaDonXuat in arrayList)
            {
                if (kq > hoaDonXuat.Soluong) kq = hoaDonXuat.Soluong;
            }
            return kq;
        }
        public void ThongKe(ArrayList arrayList)
        {
            Console.WriteLine("Thống kê loại Quanao bán chạy");
            foreach(HoaDonXuat hoaDonXuat in arrayList)
            {
                if (hoaDonXuat.Soluong == getSLBanChay(arrayList))
                {
                    Console.Write(hoaDonXuat.LoaiQuanao);
                }
            }
            foreach (HoaDonXuat hoaDonXuat in arrayList)
            {
                if (hoaDonXuat.Soluong == getSLBanE(arrayList))
                {
                    Console.Write(hoaDonXuat.LoaiQuanao);
                }
            }
        }
        public void Hien(ArrayList arrayList)
        {
            Console.WriteLine("                                |{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Mã hóa đơn", "Tên Quanao", "Loại Quần áo", "Số lượng", "Giá bán", "Tổng tiền");
            foreach (HoaDonXuat hoaDon in arrayList)
            {
                Console.WriteLine("                                |{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", hoaDon.Mahoadonxuat, hoaDon.TenQuanao, hoaDon.LoaiQuanao, hoaDon.Soluong, hoaDon.Tongtien);
            }
        }

        public void Them(ArrayList arrayList)
        {
            //string mahoadonxuat,string tenQuanao,string loaiQuanao,int soluong,double giaban,double tongtien

            string mahoadon = (arrayList.Count + 1000).ToString();
            Console.Write("                                Nhập tên quần áo: ");
            string tenQuanao = Console.ReadLine();
            Console.Write("                                Nhập loại quần áo: ");
            string loaiQuanao = Console.ReadLine();
            Console.Write("                                Nhập số lượng: ");
            int sl = int.Parse(Console.ReadLine());
            Console.Write("                                Nhập giá bán: ");
            double giaban = double.Parse(Console.ReadLine());
            double tong = sl * giaban;
         
          
            arrayList.Add(new HoaDonXuat(mahoadon, tenQuanao, loaiQuanao, sl, giaban, tong));
        }
    }
}
