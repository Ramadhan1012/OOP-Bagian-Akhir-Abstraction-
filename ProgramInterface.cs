﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public interface IHardware
    {
        void PenggolonganMenurutPerangkat();
    }

    public class Penjelasan : IHardware
    {
        public void PenggolonganMenurutPerangkat()
        {
            Console.WriteLine("Hardware merupakan suatu komponen yang ada pada komputer, bisa dilihat secara kasat mata dan mampu disentuh secara fisik.");
        }
    }

    public class Proses : IHardware
    {
        public void PenggolonganMenurutPerangkat()
        {
            Console.WriteLine("Proses (perangkat proses) adalah perangkat keras yang berguna untuk memproses masukan yang telah diberikan oleh pengguna.");
            Console.WriteLine("Contohnya seperti processor.");
        }
    }

    public class Input : IHardware
    {
        public void PenggolonganMenurutPerangkat()
        {
            Console.WriteLine("Input (perangkat masukan adalah perangkat keras yang digunakan untuk memasukkan (inout) dari pengguna yang akan diproses oleh komputer.");
            Console.WriteLine("Contohnya seperti mouse, keyboard, joystick, touchpad, lightpen, barcode, scanner, microphone.");
        }
    }

    public class Output : IHardware
    {
        public void PenggolonganMenurutPerangkat()
        {
            Console.WriteLine("Output (perangkat keluaran) adalah perangkat keras yang digunakan untuk menampilkan hasil yang telah diolah oleh komputer dan selanjutnya diberikan kepada pengguna.");
            Console.WriteLine("Contohnya seperti speaker, monitor, printer, proyektor, plotter.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IHardware hardware;

            Console.WriteLine();
            hardware = new Penjelasan();
            hardware.PenggolonganMenurutPerangkat();

            Console.WriteLine();
            Console.WriteLine("Penggolongan Hardware Menurut Jenis Perangkatnya : ");

            Console.WriteLine();
            hardware = new Proses();
            hardware.PenggolonganMenurutPerangkat();

            Console.WriteLine();
            hardware = new Input();
            hardware.PenggolonganMenurutPerangkat();

            Console.WriteLine();
            hardware = new Output();
            hardware.PenggolonganMenurutPerangkat();

            Console.ReadKey();
        }
    }
}