using System.Text;
using System;
using QuanLyCuaHangQuanAo.Presenation;
using System.Collections;

namespace QuanLyCuaHangQuanAo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            ArrayList arrayList = new ArrayList();
            DangNhap_GUI.Chon(arrayList);
            
        }
    }
}
