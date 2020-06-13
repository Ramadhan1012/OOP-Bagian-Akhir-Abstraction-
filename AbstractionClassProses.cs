using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Proses : Hardware
    {
        public override void PenggolonganMenurutPerangkat()
        {
            Console.WriteLine("Proses (perangkat proses) adalah perangkat keras yang berguna untuk memproses masukan yang telah diberikan oleh pengguna.");
            Console.WriteLine("Contohnya seperti processor.");
        }
    }
}