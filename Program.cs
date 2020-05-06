using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorpishm
{
    class Program
    {
        static void Main(string[] args)
        {
            atas :

            PrinterWindows printer;
            Console.WriteLine("\nPilih Printer :");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");
            Console.Write("Nomor Printer [1,2,3] : ");

            int pilihPrinter = Convert.ToInt32(Console.ReadLine());

            if (pilihPrinter == 1)
            {
                printer = new Epson();
            }
            else if (pilihPrinter == 2)
            {
                printer = new Canon();
            }
            else
            {
                printer = new LaserJet();
            }

            printer.show();
            printer.print();
            Console.ReadKey();

            goto atas;
        }
    }
}
