using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Model
{
    public class Program
    {
        private static void Main(String[ args])
        {
            Person ps1 = new Person();
            Person ps2 = new Person();

            ps1.FullName = "Nguyen Van A";
            ps1.Address = "Ha Noi";
            ps1.Age = 18;

            ps1.Display();

            

            ps2.FullName = "Nguyen Van A";
            ps2.Address = "Ha Noi";
            ps2.Age = 18;

            ps2.Display();
        }
    }
}