using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyCuaHangQuanAo.Entities;

namespace QuanLyCuaHangQuanAo.DataAccess
{
    class QuanAo_DAL
    {
        static string path = "Quanao.txt";
        public void docFile(ArrayList arrayList)
        {
            if (File.Exists(path))
            {
                string line;
                StreamReader streamReader = new StreamReader(path);
                while((line = streamReader.ReadLine()) != null)
                {
                    string[] arr = line.Split("#");
                    arrayList.Add(new QuanAo(arr[0], arr[1], arr[2], int.Parse(arr[3]), double.Parse(arr[4])));
                }
                streamReader.Close();
            }
        }
        public void ghiFile(ArrayList arrayList)
        {
            StreamWriter streamWriter = new StreamWriter(path);
            foreach(QuanAo Quanao in arrayList)
            {
                streamWriter.WriteLine(Quanao.ToString());
            }
            streamWriter.Close();
        }
    }
}
