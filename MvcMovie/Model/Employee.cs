using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Model
{
    public class Employee
    {
        //khai bao thuoc tinh
        public int MaNV {get, set}
         public string TenNV {get, set}
         public int Age {get, set}
         public float Luong {get, set}

        //khai bao phuong thuc
        public void EnterData()
        {
            System.Console.Write("MaNV = ");
            MaNV = Console.ReadLin
            e();
            System.Console.Write("TenNV = ");
            TenNV = Console.ReadLine();
            System.Console.Write("Age = ");
            Age = Console.ReadLine();
             System.Console.Write("Luong = ");
            Luong = Console.ReadLine();
        }

        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2} tuoi - Luong {3}", MaNV, TenNV, Age, Luong);
        }
        

    }
}