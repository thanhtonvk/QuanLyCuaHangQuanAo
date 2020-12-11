using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyCuaHangQuanAo.Entities;
using QuanLyCuaHangQuanAo.BusinessLayer.Interface;

namespace QuanLyCuaHangQuanAo.DataAccess
{
    class QuanAo_BLL : IQuanAo
    {
        public void Hien(ArrayList arrayList)
        {
            Console.WriteLine("                                |{0,-20}|{1,-20}|{2,-20}|{3,-30}|{4,-40}|", "Tên quần áo","Loại quần áo","Xuất xứ","Số lượng","Giá bán");
            foreach(QuanAo quanao in arrayList)
            {
                display(quanao);
            }
        }
        public QuanAo findquanao(ArrayList arrayList,string keyword)
        {
            QuanAo kq = null;
            foreach(QuanAo quanao in arrayList)
            {
                if (quanao.Tenquanao.Equals(keyword))
                {
                    kq = quanao;
                }
            }
            return kq;
        }
        public void Sua(ArrayList arrayList)
        {
            Console.Write("                                Nhập tên quần áo cần sửa: ");
            string keyword = Console.ReadLine();
            QuanAo quanao = findquanao(arrayList, keyword); 
            Console.Write("                                Nhập tên quần áo : ");
            quanao.Tenquanao = Console.ReadLine();
            Console.Write("                                Nhập loại quần áo: ");
            quanao.Loaiquanao = Console.ReadLine();
            Console.WriteLine("                                NHập xuất xứ: ");
            quanao.Xuatxu = Console.ReadLine();
            Console.WriteLine("                                Nhập số lượng: ");
            quanao.Soluong = int.Parse(Console.ReadLine());
            Console.WriteLine("                                Nhập giá bán: ");
            quanao.Giaban = double.Parse(Console.ReadLine());
        }
        public void display(QuanAo quanao)
        {
            Console.WriteLine("                                |{0,-20}|{1,-20}|{2,-20}|{3,-30}|{4,-40}|", quanao.Tenquanao,quanao.Loaiquanao,quanao.Xuatxu,quanao.Soluong,quanao.Giaban);
        }
        public void Them(ArrayList arrayList)
        {
            //string tenquanao,string loaiquanao,string xuatxu,int soluong,double giaban
            Console.Write("                                Nhập tên quần áo: ");
            string tenquanao = Console.ReadLine();
            Console.Write("                                Nhập loại quần áo: ");
            string loaiquanao = Console.ReadLine();
            Console.Write("                                NHập xuất xứ: ");
            string xuatxu = Console.ReadLine();
            Console.Write("                                Nhập số lượng: ");
            int soluong = int.Parse(Console.ReadLine());
            Console.Write("                                Nhập giá bán: ");
            double gia = double.Parse(Console.ReadLine());
            arrayList.Add(new QuanAo(tenquanao, loaiquanao, xuatxu, soluong, gia));
        }

        public void Timkiem(ArrayList arrayList)
        {
            Console.Write("                                Nhập tên quần áo: ");
            string keyword = Console.ReadLine();
            display(findquanao(arrayList, keyword));

        }

        public void Xoa(ArrayList arrayList)
        {
            Console.Write("                                Nhập tên quần áo: ");
            string keyword = Console.ReadLine();
            arrayList.Remove(findquanao(arrayList, keyword));
        }
    }
}
