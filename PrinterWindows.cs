using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorpishm
{
    class PrinterWindows
    {
        public string namaPrinter { get; set; }
        public virtual void show()
        {
            Console.WriteLine("ini printer");
        }
        public virtual void print()
        {
            Console.WriteLine("printer printing....");
        }
    }
}
