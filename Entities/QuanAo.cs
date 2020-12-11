using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyCuaHangQuanAo.Entities
{
    class QuanAo
    {
        private string tenquanao, loaiquanao, xuatxu;
        private int soluong;
        private double giaban;
        public QuanAo(string tenquanao,string loaiquanao,string xuatxu,int soluong,double giaban)
        {
            this.tenquanao = tenquanao;
            this.loaiquanao = loaiquanao;
            this.xuatxu = xuatxu;
            this.soluong = soluong;
            this.giaban = giaban;
        }
        override
        public  string ToString()
        {
            return tenquanao + "#" + loaiquanao + "#" + xuatxu + "#" + soluong + "#" + giaban;
        }
        public string Tenquanao { get => tenquanao; set => tenquanao = value; }
        public string Loaiquanao { get => loaiquanao; set => loaiquanao = value; }
        public string Xuatxu { get => xuatxu; set => xuatxu = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public double Giaban { get => giaban; set => giaban = value; }
    }
}
