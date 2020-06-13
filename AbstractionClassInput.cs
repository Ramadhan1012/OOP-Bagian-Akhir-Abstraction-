using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Input : Hardware
    {
        public override void PenggolonganMenurutPerangkat()
        {
            Console.WriteLine("Input (perangkat masukan adalah perangkat keras yang digunakan untuk memasukkan (inout) dari pengguna yang akan diproses oleh komputer.");
            Console.WriteLine("Contohnya seperti mouse, keyboard, joystick, touchpad, lightpen, barcode, scanner, microphone.");
        }
    }
}