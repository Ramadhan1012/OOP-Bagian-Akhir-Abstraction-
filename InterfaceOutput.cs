using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Output : IHardware
    {
        public override void PenggolonganMenurutMakanan()
        {
            Console.WriteLine("Output (perangkat keluaran) adalah perangkat keras yang digunakan untuk menampilkan hasil yang telah diolah oleh komputer dan selanjutnya diberikan kepada pengguna.");
            Console.WriteLine("Contohnya seperti speaker, monitor, printer, proyektor, plotter.");
        }
    }
}