using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Penjelasan : Hardware
    {
        public override void PenggolonganMenurutPerangkat()
        {
            Console.WriteLine("Hardware merupakan suatu komponen yang ada pada komputer, bisa dilihat secara kasat mata dan mampu disentuh secara fisik.");
        }
    }
}