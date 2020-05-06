using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorpishm
{
    class LaserJet : PrinterWindows
    {
        public override void show()
        {
            Console.WriteLine("LaserJet display dimension : 12*12");
        }
        public override void print()
        {
            Console.WriteLine("LaserJet printer printing....");
        }
    }
}
