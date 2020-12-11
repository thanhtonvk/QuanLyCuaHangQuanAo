using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCuaHangQuanAo.Entities
{
    class HoaDonXuat
    {
        private string mahoadonxuat, tenQuanao, loaiQuanao;
        private int soluong;
        private double giaban, tongtien;
        public HoaDonXuat(string mahoadonxuat,string tenQuanao,string loaiQuanao,int soluong,double giaban,double tongtien)
        {
            this.mahoadonxuat = mahoadonxuat;
            this.tenQuanao = tenQuanao;
            this.loaiQuanao = loaiQuanao;
            this.soluong = soluong;
            this.giaban = giaban;
            this.tongtien = tongtien;
        }
        override
            public string ToString()
        {
            return mahoadonxuat + "#" + tenQuanao + "#" + loaiQuanao + "#" + soluong + "#" + giaban + "#" + tongtien;
        }
        public string Mahoadonxuat { get => mahoadonxuat; set => mahoadonxuat = value; }
        public string TenQuanao { get => tenQuanao; set => tenQuanao = value; }
        public string LoaiQuanao { get => loaiQuanao; set => loaiQuanao = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public double Giaban { get => giaban; set => giaban = value; }
        public double Tongtien { get => tongtien; set => tongtien = value; }
    }
}
