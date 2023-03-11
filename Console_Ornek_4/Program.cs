using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Ornek_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Islem islem = new Islem();
            islem.topla(7, 8);
            islem.topla(9, 10);
            Console.Read();
        }
    }
}
