using System;
using System.Collections;
using System.Text;

namespace QuanLyCuaHangQuanAo.BusinessLayer.Interface
{
    interface IQuanAo
    {
        void Them(ArrayList arrayList);
        void Hien(ArrayList arrayList);
        void Sua(ArrayList arrayList);
        void Xoa(ArrayList arrayList);
        void Timkiem(ArrayList arrayList);
    }
}
