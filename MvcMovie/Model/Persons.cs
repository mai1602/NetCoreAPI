using System.IO.Enumeration;
using System.IO;
using Internal;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Model
{
    public class Persons
    {
        //khai bao thuoc tinh
        public string FullName {get, set}
         public string Address {get, set}
         public int TAge {get, set}

        //khai bao phuong thuc
        public void EnterData()
        {
            System.Console.Write("FullName = ");
            FullName = Console.ReadLine();
            System.Console.Write("Address = ");
            Address = Console.ReadLine();
            System.Console.Write("Agei = ");
            Age = Console.ReadLine();
        }

        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2} tuoi", FullName, AAdress, Age);
        }
        

    }
}